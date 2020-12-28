using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IpSelector
{
    public partial class MainForm : Form
    {
        public const string USE_SUBNET_MASK = "255.255.255.0";
        public const string GATEWAY_IP_END = "1";

        public InterfacesForm settingsForm;

        public IpAddressesCollection ipAddressesCollection = new IpAddressesCollection();
        public string useInterface = "";

        private DrawButtons drawButtons;

        public MainForm()
        {
            InitializeComponent();

            string configuredInterface = Settings.GetNetworkInterface();
            if (configuredInterface.Length > 0)
            {
                this.useInterface = configuredInterface;
                CurrentIpTextBox.Text = IpUtils.GetLocalIp(this.useInterface);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawIpButtons();
        }

        public void DrawIpButtons()
        {
            if (this.drawButtons != null)
            {
                this.drawButtons.DisposeButtons();
            }
            drawButtons = new DrawButtons(this, this.ipAddressesCollection.items);
        }

        public void SetRegisteredIpButton_Click(object sender, EventArgs e)
        {
            string ip = sender.GetType().GetProperty("Name").GetValue(sender).ToString();

            ChangeIp(ip);
        }

        private void CopyCurrentIpButton_Click(object sender, EventArgs e)
        {
            string currentValue = CurrentIpTextBox.Text;

            Clipboard.SetText(currentValue);
        }

        private void DHCPButton_Click(object sender, EventArgs e)
        {
            if (this.useInterface.Length == 0)
            {
                OpenInterfacesForm();
                return;
            }
            IpUtils.SetDHCP(this.useInterface);
            CurrentIpTextBox.Text = IpUtils.GetLocalIp(this.useInterface);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OpenInterfacesForm();
        }

        private void OpenInterfacesForm()
        {
            this.settingsForm = new InterfacesForm(this);
            this.settingsForm.Show();
            this.Enabled = false;
        }

        private void ChangeIp(string ip)
        {
            if (this.useInterface.Length == 0)
            {
                OpenInterfacesForm();
                return;
            }
            string gateway = GetGatewayFromIp(ip);
            IpUtils.SetIP(this.useInterface, ip, USE_SUBNET_MASK, gateway);
            CurrentIpTextBox.Text = IpUtils.GetLocalIp(this.useInterface);
            CustomIpTextbox.Text = ip;
        }

        private string GetGatewayFromIp(string ip)
        {
            string pattern = @"^((?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3})(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            
            return string.Format("{0}{1}", Regex.Replace(ip, pattern, "$1"), GATEWAY_IP_END);
        }

        private void SaveCustomIp_Click(object sender, EventArgs e)
        {
            string customIp = CustomIpTextbox.Text;
            ChangeIp(customIp);
        }

        private void IpsButton_Click(object sender, EventArgs e)
        {
            IpAddressesForm ipAddresses = new IpAddressesForm(this);
            ipAddresses.Show();
            this.Enabled = false;
        }

        internal void ChangeInterface(string useInterface)
        {
            this.useInterface = useInterface;
            this.CurrentIpTextBox.Text = IpUtils.GetLocalIp(useInterface);
        }
    }
}
