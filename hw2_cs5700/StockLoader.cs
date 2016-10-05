using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSim
{
    public class StockLoader
    {
        public List<Stock> stocksRead;
        public StockLoader()
        {
            this.stocksRead = new List<Stock>();
        }

        public List<Stock> parseCsvFile()
        {
            List<Stock> stockList = new List<Stock>();
            var reader = new StreamReader(File.OpenRead(@"../../CompanyList.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(new char[] { ',' }, 2);
                this.stocksRead.Add(new Stock() { Symbol = values[0], CompanyName = values[1] });
            }


            return stockList;
        }
    }
}
