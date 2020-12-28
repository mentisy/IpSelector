using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace IpSelector
{

    public partial class InterfacesForm : Form
    {
        public MainForm mainForm;

        public InterfacesForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Owner = mainForm;
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var currentInterface in interfaces)
            {
                NetworkInterfaceList.Items.Add(currentInterface.Name);
            }
            NetworkInterfaceList.Refresh();

            string configuredInterface = Settings.GetNetworkInterface();
            if (configuredInterface.Length > 0)
            {
                this.mainForm.useInterface = configuredInterface;
                int foundItemInList = NetworkInterfaceList.FindStringExact(configuredInterface);
                NetworkInterfaceList.SetSelected(foundItemInList, true);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedInterface = NetworkInterfaceList.SelectedItem.ToString();
                SetSelectedNetworkInterface(selectedInterface);
                NetworkInterfaceError.Clear();
                ErrorLabel.Visible = false;
            } catch
            {
                NetworkInterfaceError.SetError(NetworkInterfaceList, ErrorLabel.Text);
                ErrorLabel.Visible = true;
                return;
            }
        }

        private void NetworkInterfaceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedInterface = sender.GetType().GetProperty("SelectedItem").GetValue(sender, null).ToString();
            SetSelectedNetworkInterface(selectedInterface);
        }

        private void SetSelectedNetworkInterface(string selectedInterface)
        {
            this.mainForm.ChangeInterface(selectedInterface);
            Settings.SetNetworkInterface(selectedInterface);

            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Enabled = true;
        }
    }
}
