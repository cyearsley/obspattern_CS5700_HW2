using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panels;

namespace StockSim
{
    public partial class StockApplication : Form
    {
        Communicator comm;
        public StockApplication(ref Communicator communicator)
        {
            InitializeComponent();
            this.comm = communicator;
            this.comm.Start();
            
            foreach (KeyValuePair<String, Stock> entry in comm.Portfolio)
            {
                this.appPortfolioList.Items.Add(entry.Value.CompanyName);
            }
        }

        private void StockApplication_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 500);
            timer.Tick += new EventHandler(updateDisplay);
            timer.Start();
        }

        private void appStockCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockPriceButton_Click(object sender, EventArgs e)
        {
            List<Stock> stockList = new List<Stock>();
            foreach (KeyValuePair<String, Stock> entry in comm.Portfolio)
            {
                stockList.Add(entry.Value);
            }
            comm.Portfolio.observers.Add(new StockPriceGrid(stockList, new Dictionary<String, int>()));
}

        private void priceGraphButton_Click(object sender, EventArgs e)
        {

        }

        private void volumeGraphButton_Click(object sender, EventArgs e)
        {

        }

        private void appAddStock_Click(object sender, EventArgs e)
        {

        }

        private void appRemoveStock_Click(object sender, EventArgs e)
        {

        }

        private void appSavePortfolioButton_Click(object sender, EventArgs e)
        {
            String stocksFileString = "{";
            foreach (KeyValuePair<String, Stock> entry in comm.Portfolio)
            {
                stocksFileString += entry.Key + ",";
            }
            stocksFileString = stocksFileString.TrimEnd(',');
            stocksFileString += "}";
            System.IO.File.WriteAllText(@"../StockSim/../../savedFile.txt", stocksFileString);
        }

        private void appListOfSymbolsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void updateDisplay(object sender, EventArgs e)
        {
            this.stockContainer.Controls.Clear();
            for (int i = 0; i < comm.Portfolio.observers.Count; i++)
            {
                this.stockContainer.Controls.Add(comm.Portfolio.observers[i].create());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
