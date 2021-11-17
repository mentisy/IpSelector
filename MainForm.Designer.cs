
namespace IpSelector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderText = new System.Windows.Forms.Label();
            this.CurrentIpLabel = new System.Windows.Forms.Label();
            this.CurrentIpTextBox = new System.Windows.Forms.TextBox();
            this.CustomIpTextbox = new System.Windows.Forms.TextBox();
            this.CustomSubnetMaskTextbox = new System.Windows.Forms.TextBox();
            this.SetIpLabel = new System.Windows.Forms.Label();
            this.SaveCustomIp = new System.Windows.Forms.Button();
            this.CopyCurrentIpButton = new System.Windows.Forms.Button();
            this.DHCPButton = new System.Windows.Forms.Button();
            this.InterfacesButton = new System.Windows.Forms.Button();
            this.IpsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(278, 9);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(258, 55);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "IP Selector";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentIpLabel
            // 
            this.CurrentIpLabel.AutoSize = true;
            this.CurrentIpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIpLabel.Location = new System.Drawing.Point(350, 93);
            this.CurrentIpLabel.Name = "CurrentIpLabel";
            this.CurrentIpLabel.Size = new System.Drawing.Size(98, 24);
            this.CurrentIpLabel.TabIndex = 2;
            this.CurrentIpLabel.Text = "Current IP:";
            // 
            // CurrentIpTextBox
            // 
            this.CurrentIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIpTextBox.Location = new System.Drawing.Point(335, 120);
            this.CurrentIpTextBox.Name = "CurrentIpTextBox";
            this.CurrentIpTextBox.ReadOnly = true;
            this.CurrentIpTextBox.Size = new System.Drawing.Size(123, 24);
            this.CurrentIpTextBox.TabIndex = 3;
            this.CurrentIpTextBox.Text = "Set interface first";
            this.CurrentIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomIpTextbox
            // 
            this.CustomIpTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomIpTextbox.Location = new System.Drawing.Point(339, 227);
            this.CustomIpTextbox.Name = "CustomIpTextbox";
            this.CustomIpTextbox.Size = new System.Drawing.Size(123, 24);
            this.CustomIpTextbox.TabIndex = 6;
            this.CustomIpTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomSubnetMaskTextbox
            // 
            this.CustomSubnetMaskTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSubnetMaskTextbox.Location = new System.Drawing.Point(339, 257);
            this.CustomSubnetMaskTextbox.Name = "CustomSubnetMaskTextbox";
            this.CustomSubnetMaskTextbox.Size = new System.Drawing.Size(123, 24);
            this.CustomSubnetMaskTextbox.TabIndex = 7;
            this.CustomSubnetMaskTextbox.Text = "255.255.255.0";
            this.CustomSubnetMaskTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetIpLabel
            // 
            this.SetIpLabel.AutoSize = true;
            this.SetIpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetIpLabel.Location = new System.Drawing.Point(334, 200);
            this.SetIpLabel.Name = "SetIpLabel";
            this.SetIpLabel.Size = new System.Drawing.Size(132, 24);
            this.SetIpLabel.TabIndex = 8;
            this.SetIpLabel.Text = "Set Custom IP:";
            // 
            // SaveCustomIp
            // 
            this.SaveCustomIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCustomIp.Location = new System.Drawing.Point(358, 287);
            this.SaveCustomIp.Name = "SaveCustomIp";
            this.SaveCustomIp.Size = new System.Drawing.Size(86, 31);
            this.SaveCustomIp.TabIndex = 9;
            this.SaveCustomIp.Text = "Set";
            this.SaveCustomIp.UseVisualStyleBackColor = true;
            this.SaveCustomIp.Click += new System.EventHandler(this.SaveCustomIp_Click);
            // 
            // CopyCurrentIpButton
            // 
            this.CopyCurrentIpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyCurrentIpButton.Location = new System.Drawing.Point(358, 150);
            this.CopyCurrentIpButton.Name = "CopyCurrentIpButton";
            this.CopyCurrentIpButton.Size = new System.Drawing.Size(86, 31);
            this.CopyCurrentIpButton.TabIndex = 4;
            this.CopyCurrentIpButton.Text = "Copy";
            this.CopyCurrentIpButton.UseVisualStyleBackColor = true;
            this.CopyCurrentIpButton.Click += new System.EventHandler(this.CopyCurrentIpButton_Click);
            // 
            // DHCPButton
            // 
            this.DHCPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DHCPButton.Location = new System.Drawing.Point(53, 93);
            this.DHCPButton.Name = "DHCPButton";
            this.DHCPButton.Size = new System.Drawing.Size(246, 58);
            this.DHCPButton.TabIndex = 1;
            this.DHCPButton.Text = "DHCP";
            this.DHCPButton.UseVisualStyleBackColor = true;
            this.DHCPButton.Click += new System.EventHandler(this.DHCPButton_Click);
            // 
            // InterfacesButton
            // 
            this.InterfacesButton.Location = new System.Drawing.Point(665, 12);
            this.InterfacesButton.Name = "InterfacesButton";
            this.InterfacesButton.Size = new System.Drawing.Size(92, 23);
            this.InterfacesButton.TabIndex = 10;
            this.InterfacesButton.Text = "Interfaces";
            this.InterfacesButton.UseVisualStyleBackColor = true;
            this.InterfacesButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // IpsButton
            // 
            this.IpsButton.Location = new System.Drawing.Point(665, 41);
            this.IpsButton.Name = "IpsButton";
            this.IpsButton.Size = new System.Drawing.Size(92, 23);
            this.IpsButton.TabIndex = 11;
            this.IpsButton.Text = "IP Addresses";
            this.IpsButton.UseVisualStyleBackColor = true;
            this.IpsButton.Click += new System.EventHandler(this.IpsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.IpsButton);
            this.Controls.Add(this.InterfacesButton);
            this.Controls.Add(this.DHCPButton);
            this.Controls.Add(this.CopyCurrentIpButton);
            this.Controls.Add(this.SaveCustomIp);
            this.Controls.Add(this.CustomIpTextbox);
            this.Controls.Add(this.CustomSubnetMaskTextbox);
            this.Controls.Add(this.SetIpLabel);
            this.Controls.Add(this.CurrentIpTextBox);
            this.Controls.Add(this.CurrentIpLabel);
            this.Controls.Add(this.HeaderText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Selector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label CurrentIpLabel;
        private System.Windows.Forms.TextBox CurrentIpTextBox;
        private System.Windows.Forms.TextBox CustomIpTextbox;
        private System.Windows.Forms.TextBox CustomSubnetMaskTextbox;
        private System.Windows.Forms.Label SetIpLabel;
        private System.Windows.Forms.Button SaveCustomIp;
        private System.Windows.Forms.Button CopyCurrentIpButton;
        private System.Windows.Forms.Button DHCPButton;
        private System.Windows.Forms.Button InterfacesButton;
        private System.Windows.Forms.Button IpsButton;
    }
}

