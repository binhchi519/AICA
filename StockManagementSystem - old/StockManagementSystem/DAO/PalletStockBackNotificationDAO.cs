using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class PalletStockBackNotificationDAO
    {
        private static PalletStockBackNotificationDAO _instance;

        public static PalletStockBackNotificationDAO Instance
        {
            get { if (_instance == null) _instance = new PalletStockBackNotificationDAO(); return PalletStockBackNotificationDAO._instance; }
            private set { PalletStockBackNotificationDAO._instance = value; }
        }

        public PalletStockBackNotificationDAO() { }

        public List<StockBackPalletNotification> GetListPalletNotBeenReturn()
        {
            List<StockBackPalletNotification> list = new List<StockBackPalletNotification>();
            string query = "GetAllPalletStockBackNotification";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StockBackPalletNotification tempData = new StockBackPalletNotification(item);
                list.Add(tempData);
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

        public bool InsertERPData(string formName, DateTime StockInDate, string Item, int TotalQty)
        {
            string query = "InsertERPData @FormName , @StockInDate , @ItemCode , @ERPQty";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { formName, StockInDate, Item, TotalQty });
            return result > 0;
        }

        public bool DeleteERPData(string formName)
        {
            string query = "FormatERPDATA @FormName";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { formName });
            return result > 0;
        }
    }
}
