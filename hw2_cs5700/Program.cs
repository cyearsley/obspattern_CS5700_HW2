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

            StockApplication stockApp = new StockApplication(ref communicator);
            Application.Run(stockApp);
            communicator.Stop();
        }

        static void runStockApplication(ref StockApplication stockApp)
        {
            Application.Run(stockApp);
        }
    }
}
