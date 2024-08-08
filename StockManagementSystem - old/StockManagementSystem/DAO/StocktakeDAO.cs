using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class StocktakeDAO
    {
        private static StocktakeDAO _instance;

        public static StocktakeDAO Instance
        {
            get { if (_instance == null) _instance = new StocktakeDAO(); return StocktakeDAO._instance; }
            private set { StocktakeDAO._instance = value; }
        }

        private StocktakeDAO() { }
        public List<Stocktake> GetAllStockTake()
        {
            List<Stocktake> list = new List<Stocktake>();
            string query = "GetAllStockTake";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Stocktake stocktake = new Stocktake(item);
                list.Add(stocktake);
            }
            return list;
        }
        public bool StartStocktake(string ID)
        {
            string query = "InsertStockTakeMaster @DisPlayName ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID});
            return result > 0;
        }
        public bool EndStocktake(string PIC, string formName)
        {
            string query = "CloseStockTake @PIC , @FormName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PIC , formName});
            return result > 0;
        }
    }
}
