using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IpSelector
{
    public partial class IpAddressesForm : Form
    {
        private readonly MainForm mainForm;

        private const int ACTION_NEW = 0;
        private const int ACTION_EDIT = 1;

        private int currentAction = ACTION_NEW;

        public IpAddressesForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Owner = mainForm;
            UpdateIpAddressesListBox();
        }

        private void UpdateIpAddressesListBox()
        {
            IpAddressesListBox.Items.Clear();
            foreach (IpAddress ipAddress in this.mainForm.ipAddressesCollection.items)
            {
                IpAddressesListBox.Items.Add(ipAddress.name);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            StartEditIpAddress();
        }

        private void IpAddressesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartEditIpAddress();
        }

        private void StartEditIpAddress()
        {
            int selectedIndex = IpAddressesListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            IpAddress selectedIpAddress = this.mainForm.ipAddressesCollection.items[selectedIndex];

            actionLabel.Text = "Editing";
            EditingIpLabel.Text = selectedIpAddress.name;
            EditingIpLabel.Visible = true;

            NameTextBox.Text = selectedIpAddress.name;
            IpAddressTextBox.Text = selectedIpAddress.ipAddress;
            CancelEditButton.Visible = true;
            this.currentAction = ACTION_EDIT;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = IpAddressesListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            this.mainForm.ipAddressesCollection.DeleteItem(selectedIndex);
            this.mainForm.DrawIpButtons();
            CancelEdit();

            UpdateIpAddressesListBox();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AutoValidate = new AutoValidate();

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            if (currentAction == ACTION_NEW)
            {
                this.mainForm.ipAddressesCollection.AddItem(NameTextBox.Text, IpAddressTextBox.Text);
            }
            if (currentAction == ACTION_EDIT)
            {
                int selectedIndex = IpAddressesListBox.SelectedIndex;
                this.mainForm.ipAddressesCollection.EditItem(selectedIndex, NameTextBox.Text, IpAddressTextBox.Text);
            }
            UpdateIpAddressesListBox();
            this.mainForm.DrawIpButtons();
            CancelEdit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelEdit();
        }

        private void CancelEdit()
        {
            actionLabel.Text = "Add New";
            EditingIpLabel.Visible = false;
            NameTextBox.Text = "";
            IpAddressTextBox.Text = "";
            CancelEditButton.Visible = false;
            this.currentAction = ACTION_NEW;
            NameErrorProvider.Clear();
            IpAddressErrorProvider.Clear();
            AutoValidate = AutoValidate.Disable;
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                e.Cancel = true;
                NameErrorProvider.SetError(NameTextBox, "Name cannot be left blank.");

                return;
            }
            if (this.currentAction == ACTION_NEW)
            {
                foreach (IpAddress address in this.mainForm.ipAddressesCollection.items)
                {
                    if (NameTextBox.Text == address.name)
                    {
                        e.Cancel = true;
                        NameErrorProvider.SetError(NameTextBox, "Name already exists in list.");

                        return;
                    }
                }
            }
            if (NameTextBox.Text.Contains(";"))
            {
                e.Cancel = true;
                NameErrorProvider.SetError(NameTextBox, "Name cannot contain ';'. Why? Because I said so.");

                return;
            }

            e.Cancel = false;
            NameErrorProvider.Clear();
        }

        private void IpAddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(IpAddressTextBox.Text))
            {
                e.Cancel = true;
                IpAddressErrorProvider.SetError(IpAddressTextBox, "IP address cannot be left blank.");

                return;
            }
            if (!Regex.IsMatch(IpAddressTextBox.Text, @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"))
            {
                e.Cancel = true;
                IpAddressErrorProvider.SetError(IpAddressTextBox, "This doesn't look like an IP address.");

                return;
            }

            e.Cancel = false;
            IpAddressErrorProvider.Clear();
        }

        private void IpAddressesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Enabled = true;
        }
    }
}
