using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IpSelector
{
    class Settings
    {
        public static string GetNetworkInterface()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            try
            {
                return config.AppSettings.Settings["SelectedNetworkInterface"].Value;
            }
            catch
            {
                return "";
            }
        }

        public static void SetNetworkInterface(string networkInterface)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["SelectedNetworkInterface"].Value = networkInterface;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static IpAddress[] GetIpAddresses()
        {
            IpAddress[] ipAddresses = {};

            return ipAddresses;
        }
    }
}
