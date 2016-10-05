namespace StockSim
{
    partial class introGetIpPort
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
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipaddressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startApplicationButton = new System.Windows.Forms.Button();
            this.portWarning = new System.Windows.Forms.Label();
            this.ipWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IpTextBox
            // 
            this.IpTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.IpTextBox.Location = new System.Drawing.Point(43, 108);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(116, 20);
            this.IpTextBox.TabIndex = 0;
            this.IpTextBox.TextChanged += new System.EventHandler(this.IpTextBox_TextChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(215, 108);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(116, 20);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.TextChanged += new System.EventHandler(this.portTextBox_TextChanged);
            // 
            // ipaddressLabel
            // 
            this.ipaddressLabel.AutoSize = true;
            this.ipaddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ipaddressLabel.Location = new System.Drawing.Point(38, 80);
            this.ipaddressLabel.Name = "ipaddressLabel";
            this.ipaddressLabel.Size = new System.Drawing.Size(108, 25);
            this.ipaddressLabel.TabIndex = 2;
            this.ipaddressLabel.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(210, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port Number";
            // 
            // startApplicationButton
            // 
            this.startApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startApplicationButton.Location = new System.Drawing.Point(98, 174);
            this.startApplicationButton.Name = "startApplicationButton";
            this.startApplicationButton.Size = new System.Drawing.Size(180, 78);
            this.startApplicationButton.TabIndex = 4;
            this.startApplicationButton.Text = "Start Application";
            this.startApplicationButton.UseVisualStyleBackColor = true;
            this.startApplicationButton.Click += new System.EventHandler(this.startApplicationButton_Click);
            // 
            // portWarning
            // 
            this.portWarning.AutoSize = true;
            this.portWarning.ForeColor = System.Drawing.Color.Red;
            this.portWarning.Location = new System.Drawing.Point(212, 131);
            this.portWarning.Name = "portWarning";
            this.portWarning.Size = new System.Drawing.Size(120, 13);
            this.portWarning.TabIndex = 5;
            this.portWarning.Text = "Enter Valid Port Number";
            // 
            // ipWarning
            // 
            this.ipWarning.AutoSize = true;
            this.ipWarning.ForeColor = System.Drawing.Color.Red;
            this.ipWarning.Location = new System.Drawing.Point(40, 131);
            this.ipWarning.Name = "ipWarning";
            this.ipWarning.Size = new System.Drawing.Size(112, 13);
            this.ipWarning.TabIndex = 6;
            this.ipWarning.Text = "Enter Valid IP Address";
            // 
            // introGetIpPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(383, 376);
            this.Controls.Add(this.ipWarning);
            this.Controls.Add(this.portWarning);
            this.Controls.Add(this.startApplicationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipaddressLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.IpTextBox);
            this.Name = "introGetIpPort";
            this.Text = "introGetIpPort";
            this.Load += new System.EventHandler(this.introGetIpPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label ipaddressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startApplicationButton;
        private System.Windows.Forms.Label portWarning;
        private System.Windows.Forms.Label ipWarning;
    }
}