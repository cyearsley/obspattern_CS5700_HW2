using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

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
            //var t = new Thread(new ThreadStart(testingThread));
            //t.Start();

            //Application.Run(new appIntro());

            StockPortfolio portfolio = new StockPortfolio();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new appIntro());

            //stocksRead.ForEach(delegate (Stock stock)
            //{
            //    Console.WriteLine("The Symbol is: " + stock.Symbol);
            //    Console.WriteLine("The Company name is: " + stock.CompanyName);
            //});

            //portfolio.Add(stocksRead[50].Symbol, stocksRead[50]);
            //portfolio.Add(stocksRead[100].Symbol, stocksRead[100]);
            //portfolio.Add(stocksRead[150].Symbol, stocksRead[150]);
            //portfolio.Add(stocksRead[200].Symbol, stocksRead[200]);

            //portfolio.Add("AAPL", new Stock() { });
            //portfolio.Add("AMZN", new Stock() { });
            //portfolio.Add("GOOGL", new Stock() { });
            //portfolio.Add("MSFT", new Stock() { });

            IPEndPoint simulatorEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 12099);

            Communicator communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };
            communicator.RemoteEndPoint = simulatorEndPoint;

            communicator.Start();
            System.Threading.Thread.Sleep(1000);
            communicator.Stop();
            //t.Abort();
        }

        

        static void testingThread()
        {
            
        }
    }
}
