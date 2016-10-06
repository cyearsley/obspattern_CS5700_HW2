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
        StockContainer sc;

        public StockApplication()
        {
            InitializeComponent();
            this.sc = new StockContainer();
            this.Controls.Add(sc);
        }

        private void StockApplication_Load(object sender, EventArgs e)
        {

        }

        private void appStockCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockPriceButton_Click(object sender, EventArgs e)
        {
            sc.Controls.Add(new StockPanel());
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

        }

        private void appListOfSymbolsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
