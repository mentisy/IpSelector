
namespace IpSelector
{
    partial class IpAddressesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpAddressesForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.IpAddressesListBox = new System.Windows.Forms.ListBox();
            this.SubnetMaskTextBox = new System.Windows.Forms.TextBox();
            this.subnetMaskLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.actionLabel = new System.Windows.Forms.Label();
            this.EditingIpLabel = new System.Windows.Forms.Label();
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IpAddressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SubnetMaskErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpAddressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubnetMaskErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(337, 254);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(244, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(334, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(337, 129);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(244, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(337, 173);
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(244, 20);
            this.IpAddressTextBox.TabIndex = 5;
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(334, 157);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddressLabel.TabIndex = 6;
            this.ipAddressLabel.Text = "IP Address:";
            this.ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IpAddressesListBox
            // 
            this.IpAddressesListBox.FormattingEnabled = true;
            this.IpAddressesListBox.Location = new System.Drawing.Point(45, 26);
            this.IpAddressesListBox.Name = "IpAddressesListBox";
            this.IpAddressesListBox.Size = new System.Drawing.Size(247, 251);
            this.IpAddressesListBox.TabIndex = 0;
            this.IpAddressesListBox.UseTabStops = false;
            this.IpAddressesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IpAddressesListBox_MouseDoubleClick);
            // 
            // subnetMaskLabel
            // 
            this.subnetMaskLabel.AutoSize = true;
            this.subnetMaskLabel.Location = new System.Drawing.Point(334, 203);
            this.subnetMaskLabel.Name = "subnetMaskLabel";
            this.subnetMaskLabel.Size = new System.Drawing.Size(73, 13);
            this.subnetMaskLabel.TabIndex = 7;
            this.subnetMaskLabel.Text = "Subnet Mask:";
            this.subnetMaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubnetMaskTextBox
            // 
            this.SubnetMaskTextBox.Location = new System.Drawing.Point(337, 219);
            this.SubnetMaskTextBox.Name = "SubnetMaskTextBox";
            this.SubnetMaskTextBox.Size = new System.Drawing.Size(244, 20);
            this.SubnetMaskTextBox.TabIndex = 8;
            this.SubnetMaskTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IpAddressTextBox_Validating);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(45, 283);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(217, 283);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.Location = new System.Drawing.Point(332, 26);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(98, 25);
            this.actionLabel.TabIndex = 10;
            this.actionLabel.Text = "Add New";
            // 
            // EditingIpLabel
            // 
            this.EditingIpLabel.AutoSize = true;
            this.EditingIpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditingIpLabel.Location = new System.Drawing.Point(333, 55);
            this.EditingIpLabel.Name = "EditingIpLabel";
            this.EditingIpLabel.Size = new System.Drawing.Size(106, 20);
            this.EditingIpLabel.TabIndex = 11;
            this.EditingIpLabel.Text = "IP Name here";
            this.EditingIpLabel.Visible = false;
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.CausesValidation = false;
            this.CancelEditButton.Location = new System.Drawing.Point(337, 283);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(244, 23);
            this.CancelEditButton.TabIndex = 12;
            this.CancelEditButton.Text = "Cancel";
            this.CancelEditButton.UseVisualStyleBackColor = true;
            this.CancelEditButton.Visible = false;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // IpAddressErrorProvider
            // 
            this.IpAddressErrorProvider.ContainerControl = this;
            // 
            // SubnetMaskErrorProvider
            // 
            this.SubnetMaskErrorProvider.ContainerControl = this;
            // 
            // IpAddressesForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 330);
            this.Controls.Add(this.EditingIpLabel);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelEditButton);
            this.Controls.Add(this.IpAddressesListBox);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.IpAddressTextBox);
            this.Controls.Add(this.subnetMaskLabel);
            this.Controls.Add(this.SubnetMaskTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IpAddressesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Addresses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IpAddressesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpAddressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubnetMaskErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IpAddressTextBox;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label subnetMaskLabel;
        private System.Windows.Forms.TextBox SubnetMaskTextBox;
        private System.Windows.Forms.ListBox IpAddressesListBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelEditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label EditingIpLabel;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider IpAddressErrorProvider;
        private System.Windows.Forms.ErrorProvider SubnetMaskErrorProvider;
    }
}