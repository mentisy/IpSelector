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

        public IpAddress(string name, string ipAddress)
        {
            this.name = name;
            this.ipAddress = ipAddress;
        }
    }
}
