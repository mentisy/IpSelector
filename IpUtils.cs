using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace IpSelector
{
    class IpUtils
    {
        public static bool SetIP(string networkInterfaceName, string ipAddress, string subnetMask, string gateway = null)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
            var ipProperties = networkInterface.GetIPProperties();
            var ipInfo = ipProperties.UnicastAddresses.FirstOrDefault(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            var currentIPaddress = ipInfo.Address.ToString();
            var currentSubnetMask = ipInfo.IPv4Mask.ToString();
            var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            if (!isDHCPenabled && currentIPaddress == ipAddress && currentSubnetMask == subnetMask)
            {
                return true;    // no change necessary
            }


            var process = new Process();
            string command = $"interface ip set address \"{networkInterfaceName}\" static {ipAddress} {subnetMask}" + (string.IsNullOrWhiteSpace(gateway) ? "" : $" {gateway} 1");
            process.StartInfo = new ProcessStartInfo("netsh", command) { Verb = "runas" };
            process.Start();
            process.WaitForExit();
            var successful = process.ExitCode == 0;
            process.Dispose();
            return successful;
        }

        public static bool SetDHCP(string networkInterfaceName)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
            var ipProperties = networkInterface.GetIPProperties();
            var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            if (isDHCPenabled)
            {
                return true;    // no change necessary
            }

            string command = $"interface ip set address \"{networkInterfaceName}\" source=dhcp";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", command) { Verb = "runas" }
            };
            process.Start();
            process.WaitForExit();
            var successful = process.ExitCode == 0;
            process.Dispose();
            return successful;
        }

        public static string GetLocalIp(string networkInterfaceName)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);

            var ipProperties = networkInterface.GetIPProperties();
            var unicastIps = ipProperties.UnicastAddresses;

            foreach (UnicastIPAddressInformation unicastIp in unicastIps)
            {
                if (unicastIp.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return unicastIp.Address.ToString();
                }
            }

            return "Unknown";
        }
    }
}
