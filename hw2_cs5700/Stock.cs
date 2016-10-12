using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSim
{
    public class Stock
    {
        private String symbol;
        public String Symbol { get { return this.symbol; } set { this.symbol = value; } }
        private String companyName;
        public String CompanyName { get { return this.companyName; } set { this.companyName = value; } }
        private double openingPrice;
        private double previousClosingPrice;
        private double currentPrice;
        private double bidPrice;
        private double askPrice;
        private double currentVolume;
        private double averageVolume;
        //private List<ObserverDecorater>;

        // TODO: Design and implement the properties and behaviors of this class.
        public void Notify()
        {

        }

        public void Update(TickerMessage message)
        {
            // TODO: Update the state of the stock object

            // For the moment, we'll have it simply write the new stock info to the console.  This code needs to be remove.
            // The observers will be responsible to presenting stock information to the user

            //Console.WriteLine($"{message.Symbol}\tprice={message.CurrentPrice}\t\tvolume={message.CurrentVolume}");

            // Update the current Stock
            this.openingPrice = message.OpeningPrice;
            this.previousClosingPrice = message.PreviousClosingPrice;
            this.currentPrice = message.CurrentPrice;
            this.bidPrice = message.BidPrice;
            this.askPrice = message.AskPrice;
            this.currentVolume = message.CurrentVolume;
            this.averageVolume = message.AverageVolume;

            //Console.WriteLine("=================================");
            //Console.WriteLine("Name: " + this.CompanyName);
            //Console.WriteLine("Symbol: " + this.Symbol);
            //Console.WriteLine("Current Price: " + this.currentPrice);
            //Console.WriteLine("=================================");
        }
    }
}
