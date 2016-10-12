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
        Dictionary<String, int> getStocks();
        PanelStruct create();
    }

    public class PanelStruct : Panel
    {
        public String symbol;
        public bool updating_p = false;
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
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "stockPanel";
            this.Size = new System.Drawing.Size(287, 278);
            this.TabIndex = 13;
        }
    }

    public class stockList : ListBox
    {
        public stockList()
        {
            this.FormattingEnabled = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "stockList";
            this.Size = new System.Drawing.Size(287, 278);
            this.TabIndex = 0;
        }
    }
    public class StockPriceGrid : PanelStruct, IPanels
    {
        public Dictionary<String, int> stocks;
        private bool increase_p;
        private stockList list;
        public StockPriceGrid(List<Stock> stocksList, Dictionary<String, int> stocks)
        {
            this.list = new stockList();
            this.Controls.Add(list);
            if (stocks.Count.Equals(0))
            {
                Console.WriteLine("This is empty!");
                for (int i = 0; i < stocksList.Count; i++)
                {
                    list.Items.Add(" ");
                    stocks[stocksList[i].Symbol] = 0;
                }
            }
            else
            {
                this.stocks = stocks;
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
            Console.WriteLine("The length of stocks: " + stocks.Count);
            foreach (KeyValuePair<String, int> entry in stocks)
            {
                // do something with entry.Value or entry.Key
                Console.WriteLine(entry.Key + ": " + entry.Value + " --- Increased: " + this.increase_p);
                String stockString = entry.Key + ": " + entry.Value + " --- Increased: " + this.increase_p;
                Console.WriteLine("this::::: " + this.list.Items[0]);
                //this.list.Items[0] = "durp";
                this.list.Items[dicIndex] = stockString;
                //Console.WriteLine(entry.Key + ": " + entry.Value + " --- Increased: " + this.increase_p);
                dicIndex++;
            }
            this.Controls.Add(list);
            Console.WriteLine("this list: " + this.list.Items[0]);
            //this.display();
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
