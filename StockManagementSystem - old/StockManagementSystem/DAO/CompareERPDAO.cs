using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class CompareERPDAO
    {
        private static CompareERPDAO _instance;

        public static CompareERPDAO Instance
        {
            get { if (_instance == null) _instance = new CompareERPDAO(); return CompareERPDAO._instance; }
            private set { CompareERPDAO._instance = value; }
        }

        private CompareERPDAO() { }

        public List<StockDataTotal> GetListStockData()
        {
            List<StockDataTotal> list = new List<StockDataTotal>();
            string query = "EXEC GetStockDataSummarize";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StockDataTotal result = new StockDataTotal(item);
                list.Add(result);

            }
            return list;
        }
        public List<CompareERPStockTake> GetListStocktake(string formName)
        {
            List<CompareERPStockTake> list = new List<CompareERPStockTake>();
            string query = "GetAllStockTakeERP @FormName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { formName });
            foreach (DataRow item in data.Rows)
            {
                CompareERPStockTake compareERP = new CompareERPStockTake(item);
                list.Add(compareERP);
            }
            return list;
        }
        public List<CompareERP> GetListStockInData(string formName)
        {
            List<CompareERP> list = new List<CompareERP>();
            string query = "GetAllStockInERP @FormName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { formName });
            foreach (DataRow item in data.Rows)
            {
                CompareERP compareERP = new CompareERP(item);
                list.Add(compareERP);
            }
            return list;
        }
        public List<CompareERPShipOut> GetListShipOutData(string formName)
        {
            List<CompareERPShipOut> list = new List<CompareERPShipOut>();
            string query = "GetAllShipOutERP @FormName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { formName });
            foreach (DataRow item in data.Rows)
            {
                CompareERPShipOut compareERP = new CompareERPShipOut(item);
                list.Add(compareERP);
            }
            return list;
        }

        public bool InsertERPData(string formName, DateTime StockInDate, string Item, int TotalQty)
        {
            string query = "InsertERPData @FormName , @StockInDate , @ItemCode , @ERPQty";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { formName, StockInDate, Item, TotalQty });
            return result > 0;
        }
        public bool InsertERPShipOut(string formName, DateTime shipOutDate, string Item, int TotalQty, string Customer)
        {
            string query = "InsertERPShipOut @FormName , @StockInDate , @ItemCode , @ERPQty , @Customer";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { formName, shipOutDate, Item, TotalQty, Customer });
            return result > 0;
        }

        public bool DeleteERPData(string formName)
        {
            string query = "FormatERPDATA @FormName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { formName });
            return result > 0;
        }
    }
}
