using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpSelector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateIpAddressFolder();
            Application.Run(new MainForm());
        }

        private static void CreateIpAddressFolder()
        {
            string folderName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\IpSelector";
            System.IO.Directory.CreateDirectory(folderName);
        }
    }
}
