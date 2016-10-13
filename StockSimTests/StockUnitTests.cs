using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockSim;
using System.Collections.Generic;
using System.Net;

namespace StockSimTests
{
    [TestClass]
    public class StockUnitTests
    {
        [TestMethod]
        public void TestStockLoader()
        {
            StockLoader stockLoader = new StockLoader();
            List<Stock> stocks = new List<Stock>();
            stocks = stockLoader.parseCsvFile();
            Assert.AreEqual(stocks.GetType(), new List<Stock>().GetType());
            Assert.IsTrue(stockLoader.stocksRead.Count > 0);
        }

        [TestMethod]
        public void TestEndPoint()
        {
            IPEndPoint simulatorEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 12099);
            Console.WriteLine("Address: " + simulatorEndPoint.AddressFamily);
            Assert.AreEqual(simulatorEndPoint.Address.ToString(), "127.0.0.1");
            Assert.AreEqual(simulatorEndPoint.AddressFamily.GetType(), new System.Net.Sockets.AddressFamily().GetType());
        }

        [TestMethod]
        public void testCommunicator()
        {
            IPEndPoint simulatorEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 12099);
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.Add("AAPL", new Stock() { });
            portfolio.Add("AMZN", new Stock() { });
            portfolio.Add("GOOGL", new Stock() { });
            portfolio.Add("MSFT", new Stock() { });

            Communicator communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };
            communicator.Start();
            String isListening = communicator.Status;
            System.Threading.Thread.Sleep(1000);
            communicator.Stop();
            Assert.AreEqual(isListening, "Monitoring");
            Assert.AreEqual(communicator.Status, "");
            Console.WriteLine("Status: " + communicator.Status);
        }

        [TestMethod]
        public void testEndPointParser()
        {
            int port = EndPointParser.ParsePort("12345");
            Assert.AreEqual(port, 12345);
        }
    }
}
