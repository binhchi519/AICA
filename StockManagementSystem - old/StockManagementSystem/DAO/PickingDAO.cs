using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class PickingDAO
    {
        private static PickingDAO _instance;

        public static PickingDAO Instance
        {
            get { if (_instance == null) _instance = new PickingDAO(); return PickingDAO._instance; }
            private set { PickingDAO._instance = value; }
        }

        private PickingDAO() { }
        public List<PickingList> GetListPicking()
        {
            List<PickingList> list = new List<PickingList>();
            string query = "GetAllPickingLists";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PickingList pickingList = new PickingList(item);
                list.Add(pickingList);
            }
            return list;
        }

        public int InsertPickingList(int PackingID, string PoDetailQty, int PackQty)
        {
            string query = "insertPickingList @PackingID , @PODetailID , @PackQty";
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] {PackingID, PoDetailQty, PackQty }));
            return result;
        }
    }
}
