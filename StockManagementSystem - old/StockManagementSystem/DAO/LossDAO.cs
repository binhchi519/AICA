using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class LossDAO
    {
        private static LossDAO _instance;

        public static LossDAO Instance
        {
            get { if (_instance == null) _instance = new LossDAO(); return LossDAO._instance; }
            private set { LossDAO._instance = value; }
        }

        private LossDAO() { }

        public List<Loss> GetListLoss()
        {
            List<Loss> list = new List<Loss>();
            string query = "GetAllLossReason";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Loss loss = new Loss(item);
                list.Add(loss);
            }
            return list;
        }
        public string getRePrintPass()
        {
            string query = "GetRePrintPassword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return item[0].ToString();
            }
            return "";
        }  
        public bool changeRePrintPassword(string oPass, string nPass)
        {
            string query = "UpdateRePrintPassword @oldPass , @newPass ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { oPass, nPass });
            return result > 0;
        }   
        public bool changeDeletePOPassword(string oPass, string nPass)
        {
            string query = "UpdateDeletePOPassword @oldPass , @newPass ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { oPass, nPass });
            return result > 0;
        }
        public string getDeletePOPass()
        {
            string query = "GetDeletePassword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return item[0].ToString();
            }
            return "";
        }
        public bool InsertAndUpdateLoss( string lossCode,string lossName)
        {
            string query = "UpsertLossReason @lossReasonCode , @lossReasonName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { lossCode,lossName });
            return result > 0;
        }
      
        public bool DeleteLoss(string lossCode)
        {
            string query = "DeleteLossReason @lossReasonCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { lossCode });
            return result > 0;
        }
        public bool ChangeLossPassword(string newPass, string oldPass)
        {
            string query = "changeLossPassword  " + oldPass + "," + newPass;
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { });
            return result > 0;
        }
    }
}
