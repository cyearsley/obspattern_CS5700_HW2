using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSim
{
    public partial class appIntro : Form
    {
        private StockLoader stockLoader;
        public String durp = "I haven't been set yet :(";
        StockPortfolio portfolio = new StockPortfolio();
        public appIntro()
        {
            this.stockLoader = new StockLoader();
            List<Stock> stocksRead = stockLoader.parseCsvFile();
            Console.WriteLine("Some symbol: " + stocksRead[25].Symbol);
            Console.WriteLine("Some C name: " + stocksRead[25].CompanyName);

            InitializeComponent();
            introSymbolCombo.Hide();
            symbolIntroList.Hide();
            introCreatePortfolioButton.Hide();
            introPromptLabel.Hide();

            for (int i = 0; i < stockLoader.listOfSymbols.Count(); i++)
            {
                introSymbolCombo.Items.Add(stockLoader.listOfSymbols[i]);
            }
        }

        private void appIntro_Load(object sender, EventArgs e)
        {
            
        }

        private void newPortfolioButton_Click(object sender, EventArgs e)
        {
            introSymbolCombo.Show();
            symbolIntroList.Show();
            introCreatePortfolioButton.Show();
            introPromptLabel.Show();
            newPortfolioButton.Hide();
            loadPortfolioButton.Hide();
        }

        private void loadPortfolioButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            byte[] b = new byte[1024];
                            UTF8Encoding temp = new UTF8Encoding(true);
                            String fileContents = ""; ;

                            while (myStream.Read(b, 0, b.Length) > 0)
                            {
                                fileContents += temp.GetString(b).ToString();
                            }
                            fileContents.Trim(new Char[] { ' ', '?', '.' });
                            string[] words = fileContents.Split(',');

                            foreach (string s in words)
                            {
                                symbolIntroList.Items.Add(s);
                            }

                            introSymbolCombo.Show();
                            symbolIntroList.Show();
                            introCreatePortfolioButton.Show();
                            introPromptLabel.Show();
                            newPortfolioButton.Hide();
                            loadPortfolioButton.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void introSymbolCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbolIntroList.Items.Add(introSymbolCombo.Text);
        }

        private void symbolIntroList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void introPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void introCreatePortfolioButton_Click(object sender, EventArgs e)
        {
            if (symbolIntroList.Items.Count == 0){}
            else
            {
                this.durp = "I have been set!";
                this.Close();
            }
        }
    }
}
