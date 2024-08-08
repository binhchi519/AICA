using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class HistoryDAO
    {
        private static HistoryDAO _instance;

        public static HistoryDAO Instance
        {
            get { if (_instance == null) _instance = new HistoryDAO(); return HistoryDAO._instance; }
            private set { HistoryDAO._instance = value; }
        }
        private HistoryDAO() { }
        public List<StocktakeHistory> GetAllStockTakeHistory()
        {
            List<StocktakeHistory> list = new List<StocktakeHistory>();
            string query = "GetAllStockTakeHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StocktakeHistory dataOfRow = new StocktakeHistory(item);
                list.Add(dataOfRow);
            }
            return list;
        }
        public List<History> GetAllStockInHistory()
        {
            List<History> list = new List<History>();
            string query = "GetAllStockInHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }  
        public List<History> GetAllMaskingHistory()
        {
            List<History> list = new List<History>();
            string query = "GetAllMaskingHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }
        public List<NGList> GetNGList()
        {
            List<NGList> list = new List<NGList>();
            string query = "GetAllLossHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NGList history = new NGList(item);
                list.Add(history);
            }
            return list;
        }
        public List<History> GetAllLossHistory()
        { 
            List<History> list = new List<History>();
            string query = "GetAllLossHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }
        public List<History> GetAllStockbackHistory()
        {
            List<History> list = new List<History>();
            string query = "GetAllStockbackHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }
        public List<History> GetAllMovingHistory()
        {
            List<History> list = new List<History>();
            string query = "GetAllMovingHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }
        public List<History> GetAllStockOutHistory()
        {
            List<History> list = new List<History>();
            string query = "GetAllStockOutHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }
        public List<PackingStatusPIC> GetAllPICPickingStatus()
        {
            List<PackingStatusPIC> list = new List<PackingStatusPIC>();
            string query = "GetAllPickingPIC ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                if (list.Count <= 30)
                {
                    PackingStatusPIC pic = new PackingStatusPIC(item);
                    if (pic.ShippingPallet.Length != 3)
                    {
                        list.Add(pic);
                    }
                    else {
                        continue;
                    }
                  
                }
                else {
                    break;
                }
            }
            return list;
        } 
        
        public List<PackingStatusPIC> GetAllPICPackingStatus()
        {
            List<PackingStatusPIC> list = new List<PackingStatusPIC>();
            string query = "GetAllPackingPIC ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                if (list.Count <= 30)
                {
                    PackingStatusPIC pic = new PackingStatusPIC(item);
                    if (pic.ShippingPallet.Length != 3)
                    {
                        list.Add(pic);
                    }
                    else {
                        continue;
                    }
                  
                }
                else {
                    break;
                }
            }
            return list;
        }

        public List<History> GetAllPackingHistory()
        {
            List<History> list = new List<History>();
            string query = "GetAllPackingHistory ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }
            return list;
        }
    }
}
