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
            StockPortfolio portfolio = new StockPortfolio();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            appIntro startApp = new appIntro();
            introGetIpPort getIpPort = new introGetIpPort();
            Application.Run(startApp);
            Application.Run(getIpPort);

            portfolio.addStockList(startApp.SelectedStocks);

            IPEndPoint simulatorEndPoint = new IPEndPoint(System.Net.IPAddress.Parse(getIpPort.ipAddress), getIpPort.port);
            Communicator communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };
            communicator.RemoteEndPoint = simulatorEndPoint;

            communicator.Start();

            StockApplication stockApp = new StockApplication();
            Application.Run(stockApp);

            //var appThread = new Thread(new ThreadStart(() => runStockApplication(portfolio, getIpPort.ipAddress, getIpPort.port, ref communicator)));
            //appThread.Start();

            //while (appThread.IsAlive) { Thread.Sleep(1000); }
            communicator.Stop();
        }

        static void runStockApplication(StockPortfolio portfolio, String ipAddress, int port, ref Communicator communicator)
        {
            communicator.Start();
            StockApplication run = new StockApplication();
            Application.Run(run);
        }
    }
}
