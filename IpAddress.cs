using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpSelector
{
    public class IpAddress
    {
        public string name = "";
        public string ipAddress = "";
        public string subnetMask = "255.255.255.0";

        public IpAddress(string name, string ipAddress, String subnetMask)
        {
            this.name = name;
            this.ipAddress = ipAddress;
            this.subnetMask = subnetMask;
        }
    }
}
