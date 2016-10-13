using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockSim;

namespace Panels
{
    public interface IPanels
    {
        void display();
        void update(TickerMessage message);
        bool remove_p();
        Dictionary<String, int> getStocks();
        PanelStruct create();
    }

    public abstract class PanelStruct : Panel
    {
        public String symbol;
        public bool deleteMe_p;
        public void display()
        {
            this.Refresh();
        }

        public PanelStruct create()
        {
            return this;
        }

        public PanelStruct()
        {
            deleteMe_p = false;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "stockPanel";
            this.Size = new System.Drawing.Size(287, 278);
            this.TabIndex = 13;
            this.Click += new EventHandler(this.panel1_Click);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.deleteMe_p = true;
        }

        public bool remove_p()
        {
            return this.deleteMe_p;
        }
    }

    public class stockList : ListBox
    {
        public stockList()
        {
            this.FormattingEnabled = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "stockList";
            this.Size = new System.Drawing.Size(287, 250);
            this.TabIndex = 0;
        }
    }

    public class StockPriceGrid : PanelStruct, IPanels
    {
        public Dictionary<String, int> stocks;
        private bool increase_p;
        private stockList list;
        public StockPriceGrid(List<Stock> stocksList, Dictionary<String, int> stocksParam)
        {
            this.list = new stockList();
            this.Controls.Add(list);
            this.stocks = stocksParam;
            if (this.stocks.Count <= 0)
            {
                for (int i = 0; i < stocksList.Count; i++)
                {
                    list.Items.Add(" ");
                    this.stocks[stocksList[i].Symbol] = 0;
                }
            }
        }

        public Dictionary<String, int> getStocks()
        {
            return this.stocks;
        }

        public void update(TickerMessage message)
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks.ContainsKey(message.Symbol))
                {
                    if (stocks[message.Symbol] > message.CurrentPrice)
                    {
                        this.increase_p = false;
                    }
                    else
                    {
                        this.increase_p = true;
                    }
                    stocks[message.Symbol] = message.CurrentPrice;
                }
            }

            int dicIndex = 0;
            foreach (KeyValuePair<String, int> entry in stocks)
            {
                String stockString = entry.Key + ": " + entry.Value + "\t --- Increased: " + this.increase_p;
                this.list.Items.Add(stockString);
                dicIndex++;
            }
        }
    }

    public class StockPriceGrpah : PanelStruct, IPanels
    {
        public Dictionary<String, int> getStocks()
        {
            return new Dictionary<String, int>();
        }

        public void update(TickerMessage message)
        {

        }
    }

    public class StockVolumeGraph : PanelStruct, IPanels
    {
        public Dictionary<String, int> getStocks()
        {
            return new Dictionary<String, int>();
        }

        public void update(TickerMessage message)
        {

        }
    }
}
