using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockSim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            List<Stock> stocksRead = parseCsvFile();
            StockPortfolio portfolio = new StockPortfolio();

            stocksRead.ForEach(delegate (Stock stock)
            {
                Console.WriteLine("The Symbol is: " + stock.Symbol);
                Console.WriteLine("The Company name is: " + stock.CompanyName);
            });

            //portfolio.Add("AAPL", new Stock() { });
            //portfolio.Add("AMZN", new Stock() { });
            //portfolio.Add("GOOGL", new Stock() { });
            //portfolio.Add("MSFT", new Stock() { });
            
            IPEndPoint simulatorEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 12099);

            Communicator communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };
            communicator.RemoteEndPoint = simulatorEndPoint;

            communicator.Start();
            System.Threading.Thread.Sleep(10000);
            communicator.Stop();
        }

        static List<Stock> parseCsvFile()
        {
            List<Stock> stockList = new List<Stock>();
            var reader = new StreamReader(File.OpenRead(@"../../CompanyList.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(new char[] { ',' }, 2);
                stockList.Add(new Stock() {Symbol = values[0], CompanyName = values[1] });
            }


            return stockList;
        }
    }
}
