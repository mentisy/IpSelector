﻿using System;
using System.Collections.Generic;

namespace IpSelector
{
    public class IpAddressesCollection
    {
        private readonly string filename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\IpSelector\\ip_address_list.txt";

        public List<IpAddress> items = new List<IpAddress>();

        public IpAddressesCollection()
        {
            if (System.IO.File.Exists(filename))
            {
                string[] addressLines = System.IO.File.ReadAllLines(filename);
                foreach (string line in addressLines)
                {
                    string[] parts = line.Split(';');
                    IpAddress ipAddress = new IpAddress(parts[0], parts[1], parts[2]);
                    this.items.Add(ipAddress);
                }
            }
        }

        public void AddItem(string name, string ipAddress, string subnetMask)
        {
            this.items.Add(new IpAddress(name, ipAddress, subnetMask));
            CompileNewFile();
        }

        public void EditItem(int index, string name, string ipAddress, string subnetMask)
        {
            this.items.Insert(index, new IpAddress(name, ipAddress, subnetMask));
            this.items.RemoveAt(index + 1);
            CompileNewFile();
        }

        public void DeleteItem(int index)
        {
            this.items.RemoveAt(index);
            CompileNewFile();
        }

        private void CompileNewFile()
        {
            string content = "";
            foreach (IpAddress ipAddress in this.items)
            {
                content += string.Format("{0};{1};{2}\n", ipAddress.name, ipAddress.ipAddress, ipAddress.subnetMask);
            }
            System.IO.File.WriteAllText(filename, content);
        }
    }
}
