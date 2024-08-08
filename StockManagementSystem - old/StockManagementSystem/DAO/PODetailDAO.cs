using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class PODetailDAO
    {
        private static PODetailDAO _instance;

        public static PODetailDAO Instance
        {
            get { if (_instance == null) _instance = new PODetailDAO(); return PODetailDAO._instance; }
            private set { PODetailDAO._instance = value; }
        }

        private PODetailDAO() { }

        public List<PODetail> GetListPODetail()
        {
            List<PODetail> list = new List<PODetail>();
            string query = "GetPODetailList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PODetail podetail = new PODetail(item);
                list.Add(podetail);
            }
            return list;
        }




        public List<PODetail> GetListItem()
        {
            List<PODetail> list = new List<PODetail>();
            string query = "GetItemList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PODetail podetail = new PODetail(item);
                list.Add(podetail);
            }
            return list;
        }

        public bool InsertPODetail(string PONo,string Item, bool film, int TotalQty, string Priority, int Qty)
        {
            string query = "InsertIntoPODetail @PONo  , @ItemCode , @Film , @POQty , @POPriority , @ShippingQty ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PONo,Item, film, TotalQty, Priority, Qty });
            return result > 0;
        }

        public bool InsertPOMaster(string PONo, DateTime PODate, string Customer)
        {
            string query = "UpsertPOMaster @PONo  , @PODate , @Customer";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PONo, PODate, Customer });
            return result > 0;
        }

        public bool UpdatePODetail(string ID,string Priority, int Qty)
        {
            string query = "UpdatePODetail @ID , @POPriority , @ShippingQty ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {ID, Priority, Qty });
            return result > 0;
        }
        public int GetPOResQty(string pono, string itemcode, string id)
        {
            string query = "GetPOReserveQty @PONO , @Itemcode , @ID ";
            int result = (int) DataProvider.Instance.ExecuteScalar(query, new object[] { pono, itemcode, id });
            return result;
        }
        public bool DeletePODetail(string ID)
        {
            string query = "DeletePODetail @ID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
            return result > 0;
        }
    }
}
