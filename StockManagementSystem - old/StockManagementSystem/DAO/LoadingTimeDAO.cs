using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class LoadingTimeDAO
    {
        private static LoadingTimeDAO _instance;

        public static LoadingTimeDAO Instance
        {
            get { if (_instance == null) _instance = new LoadingTimeDAO(); return LoadingTimeDAO._instance; }
            private set { LoadingTimeDAO._instance = value; }
        }

        private LoadingTimeDAO() { }
        public List<LoadingTime> GetListLoadingTime(string Customer)
        {
            List<LoadingTime> list = new List<LoadingTime>();
            string query = "GetListLoadingTimeByCustomer @Customer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { Customer});
            foreach (DataRow item in data.Rows)
            {
                LoadingTime loadingTime = new LoadingTime(item);
                list.Add(loadingTime);
            }
            return list;
        }
    }
}
