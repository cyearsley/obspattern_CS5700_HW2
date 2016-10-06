using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSim
{
    public class StockPortfolio : Dictionary<String, Stock>
    {
        public void Update(TickerMessage message)
        {
            if (message == null) return;

            if (ContainsKey(message.Symbol))
                this[message.Symbol].Update(message);
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
