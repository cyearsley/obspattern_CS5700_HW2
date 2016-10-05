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
        private List<Stock> selectedStocks = new List<Stock>();
        public List<Stock> SelectedStocks
        {
            get
            {
                return this.selectedStocks;
            }
        }
        public appIntro()
        {
            this.stockLoader = new StockLoader();
            List<Stock> stocksRead = stockLoader.parseCsvFile();

            InitializeComponent();
            introSymbolCombo.Hide();
            symbolIntroList.Hide();
            introCreatePortfolioButton.Hide();
            introPromptLabel.Hide();
            removeSelectedSymbols.Hide();

            for (int i = 0; i < stockLoader.stocksRead.Count(); i++)
            {
                introSymbolCombo.Items.Add(stockLoader.stocksRead[i].Symbol);
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
            removeSelectedSymbols.Show();
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
                            string[] words = fileContents.Split(',','{','}');

                            foreach (string s in words)
                            {
                                symbolIntroList.Items.Add(s);
                            }

                            introSymbolCombo.Show();
                            symbolIntroList.Show();
                            introCreatePortfolioButton.Show();
                            introPromptLabel.Show();
                            removeSelectedSymbols.Show();
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
                for (int i = 0; i < symbolIntroList.Items.Count; i++)
                {
                    for (int j = 0; j < stockLoader.stocksRead.Count; j++)
                    {
                        if (symbolIntroList.Items[i].ToString() == stockLoader.stocksRead[j].Symbol.ToString())
                        {
                            selectedStocks.Add(stockLoader.stocksRead.Find(x => x.Symbol == symbolIntroList.Items[i].ToString()));
                        }
                    }
                }
                this.Close();
            }
        }

        private void removeSelectedSymbols_Click(object sender, EventArgs e)
        {
            // Referenced from: https://social.msdn.microsoft.com/Forums/en-US/8cabccca-f2b9-40c4-9cf5-89cbcbc06f03/remove-selected-items-from-listbox-when-pressed-delete-button?forum=csharplanguage
            for (int i = symbolIntroList.SelectedIndices.Count - 1; i >= 0; i--) {
                symbolIntroList.Items.RemoveAt(symbolIntroList.SelectedIndices[i]);
            }
        }
    }
}
