using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class StockDataDAO
    {
        private static StockDataDAO _instance;

        public static StockDataDAO Instance
        {
            get { if (_instance == null) _instance = new StockDataDAO(); return StockDataDAO._instance; }
            private set { StockDataDAO._instance = value; }
        }

        private StockDataDAO() { }

        public List<StockData> GetListStockData()
        {
            List<StockData> list = new List<StockData>();
            string query = "GetStockDataInventory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StockData stockData = new StockData(item);
                list.Add(stockData);
            }
            return list;
        }
    }
}
