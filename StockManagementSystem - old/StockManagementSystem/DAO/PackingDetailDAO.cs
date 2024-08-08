using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class PackingDetailDAO
    {
        private static PackingDetailDAO _instance;

        public static PackingDetailDAO Instance
        {
            get { if (_instance == null) _instance = new PackingDetailDAO(); return PackingDetailDAO._instance; }
            private set { PackingDetailDAO._instance = value; }
        }

        private PackingDetailDAO() { }
        public List<PackingDetail> GetnullETD()
        {
            List<PackingDetail> list = new List<PackingDetail>();
            string query = "GetnullETD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PackingDetail packingDetail;
            foreach (DataRow item in data.Rows)
            {
                packingDetail = new PackingDetail(item);
                list.Add(packingDetail);
            }
            return list;
        }
        public List<PackingDetail> GetListPacking()
        {
            List<PackingDetail> list = new List<PackingDetail>();
            string query = "GetAllPackingLists";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PackingDetail packingList;
            foreach (DataRow item in data.Rows)
            {
                packingList = new PackingDetail(item);
                list.Add(packingList);
            }
            return list;
        }
    }
}
