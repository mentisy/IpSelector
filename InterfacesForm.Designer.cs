
namespace IpSelector
{
    partial class InterfacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacesForm));
            this.NetworkInterfaceList = new System.Windows.Forms.ListBox();
            this.NetworkInterfaceLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.NetworkInterfaceError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NetworkInterfaceError)).BeginInit();
            this.SuspendLayout();
            // 
            // NetworkInterfaceList
            // 
            this.NetworkInterfaceList.FormattingEnabled = true;
            this.NetworkInterfaceList.Location = new System.Drawing.Point(25, 40);
            this.NetworkInterfaceList.Name = "NetworkInterfaceList";
            this.NetworkInterfaceList.Size = new System.Drawing.Size(246, 160);
            this.NetworkInterfaceList.TabIndex = 0;
            this.NetworkInterfaceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NetworkInterfaceList_MouseDoubleClick);
            // 
            // NetworkInterfaceLabel
            // 
            this.NetworkInterfaceLabel.AutoSize = true;
            this.NetworkInterfaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkInterfaceLabel.Location = new System.Drawing.Point(26, 13);
            this.NetworkInterfaceLabel.Name = "NetworkInterfaceLabel";
            this.NetworkInterfaceLabel.Size = new System.Drawing.Size(135, 20);
            this.NetworkInterfaceLabel.TabIndex = 1;
            this.NetworkInterfaceLabel.Text = "Network Interface";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(25, 207);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(246, 39);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(43, 258);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(211, 20);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "You must select an interface";
            this.ErrorLabel.Visible = false;
            // 
            // NetworkInterfaceError
            // 
            this.NetworkInterfaceError.ContainerControl = this;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 290);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NetworkInterfaceLabel);
            this.Controls.Add(this.NetworkInterfaceList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NetworkInterfaceError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NetworkInterfaceList;
        private System.Windows.Forms.Label NetworkInterfaceLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ErrorProvider NetworkInterfaceError;
    }
}