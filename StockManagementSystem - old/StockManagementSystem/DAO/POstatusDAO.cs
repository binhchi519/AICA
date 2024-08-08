using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class POstatusDAO
    {
        private static POstatusDAO _instance;

        public static POstatusDAO Instance
        {
            get { if (_instance == null) _instance = new POstatusDAO(); return POstatusDAO._instance; }
            private set { POstatusDAO._instance = value; }
        }

        private POstatusDAO() { }

        public List<POstatus> GetlistPOStatus()
        {
            List<POstatus> list = new List<POstatus>();
            string query = "GetListPOWithStatus";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                POstatus postatus = new POstatus(item);
                list.Add(postatus);
            }
            return list;
        }
        
    }
}
