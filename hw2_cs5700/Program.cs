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
            appIntro startApp = new appIntro();
            introGetIpPort getIpPort = new introGetIpPort();
            Application.Run(startApp);
            Application.Run(getIpPort);

            for (int i = 0; i < startApp.SelectedStocks.Count; i++)
            {
                Console.WriteLine("Symbol: " + startApp.SelectedStocks[i].Symbol);
                portfolio.Add(startApp.SelectedStocks[i].Symbol, startApp.SelectedStocks[i]);
            }
            //var introThread = new Thread(new ThreadStart(() => startLoadSaveGui(ref startApp)));
            //introThread.Start();

            //while (introThread.IsAlive){ System.Threading.Thread.Sleep(1000); }

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

            IPEndPoint simulatorEndPoint = new IPEndPoint(System.Net.IPAddress.Parse(getIpPort.ipAddress), getIpPort.port);

            Communicator communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };
            communicator.RemoteEndPoint = simulatorEndPoint;

            communicator.Start();
            System.Threading.Thread.Sleep(5000);
            communicator.Stop();
            //t.Abort();
        }
    }
}
