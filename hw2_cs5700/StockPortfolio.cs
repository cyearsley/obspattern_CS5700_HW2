using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panels;

namespace StockSim
{
    public class StockPortfolio : Dictionary<String, Stock>
    {
        public List<IPanels> observers = new List<IPanels>();
        public void Update(TickerMessage message)
        {
            if (message == null) return;

            if (ContainsKey(message.Symbol))
                this[message.Symbol].Update(message);

            notifyObservers(message);
        }

        private void notifyObservers(TickerMessage message)
        {
            for (int i = 0; i < observers.Count; i++)
            {
                //Console.WriteLine("TYPE: " + this.observers[i].GetType().ToString());
                List<Stock> stockList = new List<Stock>();
                foreach (KeyValuePair<String, Stock> entry in this)
                {
                    stockList.Add(entry.Value);
                }
                if (this.observers[i].GetType().ToString() == "Panels.StockPriceGrid")
                {
                    this.observers[i] = new StockPriceGrid(stockList, this.observers[i].getStocks());
                }

                this.observers[i].update(message);
            }
        }

        public void addStockList(List<Stock> stocks)
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                Console.WriteLine("Symbol: " + stocks[i].Symbol);
                this.Add(stocks[i].Symbol, stocks[i]);
            }
        }

        public void addStock(Stock stock)
        {
            this.Add(stock.Symbol, stock);
        }
    }
}
