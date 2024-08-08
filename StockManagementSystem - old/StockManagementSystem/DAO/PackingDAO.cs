using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class PackingDAO
    {
        private static PackingDAO _instance;

        public static PackingDAO Instance
        {
            get { if (_instance == null) _instance = new PackingDAO(); return PackingDAO._instance; }
            private set { PackingDAO._instance = value; }
        }

        private PackingDAO() { }

        public List<PackingList> GetListPacking()
        {
            List<PackingList> list = new List<PackingList>();
            string query = "GetAllPackingLists";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PackingList packingList;
            foreach (DataRow item in data.Rows)
            {
                 packingList = new PackingList(item);
                list.Add(packingList);
            }
            return list;
        }
        

        public string GetInsertedPKL(string Customer)
        {
            string query = "GetInsertedPKL @Customer";
            string result = DataProvider.Instance.ExecuteScalar(query, new object[] { Customer}).ToString();
            return result;
        }

        public bool InsertPKLDetail(string PODetailID, string ItemCode, int PackQty, string ShippingPalletNo, string loadingTime)
        {
            string query = "InsertPKLDetail @PODetailID , @ItemCode , @PackQty , @ShippingPalletNo , @LoadingTime";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PODetailID, ItemCode, PackQty, ShippingPalletNo, loadingTime });
            return result > 0;
        }
        public bool ReturnsPKLDetail(string PODetailID, string ItemCode)
        {
            string query = "UndoPKLDetail  @PODetailID , @ItemCode";
            int result = (DataProvider.Instance.ExecuteNonQuery(query, new object[] { PODetailID, ItemCode }));
            return result>0;
        }

        public string GetLastPalletNo(string Customer, string loadingTime)
        {
            string query = "GetMaxShippingPalletNoByCustomerAndLoadingTime @Customer , @loadingTime";
            string result = DataProvider.Instance.ExecuteScalar(query, new object[] { Customer,loadingTime }).ToString();
            return result;
        }
        public bool UpdateETD(DateTime ETD, string POdetailID)
        {
            string query = "UpdatePKLETD @ETD , @PODetailID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ETD, POdetailID });
            return result > 0;
        }
        public bool UpdateShipingPalletNo(string PackingID,string ShippingPalletNo )
        {
            string query = "updateShippingPalletNo @PackingID , @ShippingPalletNo";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PackingID, ShippingPalletNo });
            return result > 0?true:false;
        }
        public bool UpdateShipingPalletNoAndLoadingTime(string PackingID, string ShippingPalletNo, string LoadingTime , string Customer )
        {
            string query = "updateShippingPalletNoAndLoadingTime @PackingID , @ShippingPalletNo , @LoadingTime , @Customer";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PackingID, ShippingPalletNo, LoadingTime, Customer });
            return result > 0?true:false;
        }

        public string GetLastLoadingTime(string Customer)
        {
            string query = "GetMaxLoadingTime @Customer";
            string result = DataProvider.Instance.ExecuteScalar(query, new object[] { Customer}).ToString();
            return result;
        } public string GetMaxLoadingTimeInMonth(string Customer)
        {
            string query = "GetMaxLoadingTimeInMonth @Customer";
            string result = DataProvider.Instance.ExecuteScalar(query, new object[] { Customer}).ToString();
            return result;
        }
    }
}
