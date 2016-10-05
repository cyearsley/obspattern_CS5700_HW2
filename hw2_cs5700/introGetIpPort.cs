using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSim
{
    public partial class introGetIpPort : Form
    {
        public String ipAddress = "127.0.0.1";
        public int port = 12099;
        public introGetIpPort()
        {
            InitializeComponent();
            IpTextBox.Text = this.ipAddress;
            portTextBox.Text = this.port.ToString();
            portWarning.Hide();
            ipWarning.Hide();
        }

        private void introGetIpPort_Load(object sender, EventArgs e)
        {

        }

        private void IpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void portTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startApplicationButton_Click(object sender, EventArgs e)
        {
            this.ipAddress = IpTextBox.Text;

            int testPort;
            if (Int32.TryParse(portTextBox.Text, out testPort))
            {
                this.port = Int32.Parse(portTextBox.Text);
                portWarning.Hide();

                System.Net.IPAddress testIp;
                if (System.Net.IPAddress.TryParse(IpTextBox.Text, out testIp))
                {
                    //Valid IP, with address containing the IP
                    this.ipAddress = IpTextBox.Text;
                    this.Close();
                }
                else
                {
                    ipWarning.Show();
                }
            }
            else
            {
                Console.WriteLine("You must enter a number for the port!");
                portWarning.Show();
            }

        }
    }
}
