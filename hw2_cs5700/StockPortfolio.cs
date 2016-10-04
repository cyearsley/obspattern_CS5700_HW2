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
    }
}
