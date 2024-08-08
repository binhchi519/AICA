using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class StockInDAO
    {
        private static StockInDAO _instance;

        public static StockInDAO Instance
        {
            get { if (_instance == null) _instance = new StockInDAO(); return StockInDAO._instance; }
            private set { StockInDAO._instance = value; }
        }

        private StockInDAO() { }

        public List<StockIn> GetListStockIn()
        {
            List<StockIn> list = new List<StockIn>();
            string query = "GetAllStockins";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StockIn stockIn = new StockIn(item);
                list.Add(stockIn);
            }
            return list;
        }

        public bool UpdateStockIn(int actionID, DateTime stockInDate, int quantity, string user, string itemCode, string palletNo, string locationCode)
        {
            string query = "updateStockIn @ActionID , @StockInDate , @Qty , @DisPlayName , @ItemCode , @PalletNo , @LocationCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { actionID, stockInDate, quantity, user, itemCode, palletNo,locationCode });
            return result > 0;
        }

        public bool DeleteStockIn(int actionID, string user, string itemCode, string palletNo)
        {
            string query = "DeleteStockin @ActionID , @DisPlayName , @ItemCode , @PalletNo";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { actionID, user, itemCode, palletNo });
            return result > 0;
        }

    }
}
