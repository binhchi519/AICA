using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace StockManagementSystem.DAO
{
    public class DasboardDAO
    {
        private static DasboardDAO _instance;

        public static DasboardDAO Instance
        {
            get { if (_instance == null) _instance = new DasboardDAO(); return DasboardDAO._instance; }
            private set { DasboardDAO._instance = value; }
        }

        private DasboardDAO() { }

        public List<DTO.PackingStatus> GetPackingStatusTable()
        {
            List<DTO.PackingStatus> list = new List<DTO.PackingStatus>();
            string query = "GetPackingStatusCustomer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.PackingStatus parseToEntity = new DTO.PackingStatus(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<LoadingStatus> GetLoadingStatusCustomer(string year,string month)
        {
            List<LoadingStatus> list = new List<LoadingStatus>();
            string query = "GetLoadingStatusCustomer @month , @year ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { year,month });
            foreach (DataRow item in data.Rows)
            {
                LoadingStatus parseToEntity = new LoadingStatus(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<LoadingStatus2> GetLoadingStatusCustomer2()
        {
            List<LoadingStatus2> list = new List<LoadingStatus2>();
            string query = "GetLoadingStatusCustomer2";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            foreach (DataRow item in data.Rows)
            {
                LoadingStatus2 parseToEntity = new LoadingStatus2(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<PickingStatus> GetPickingStatusTable()
        {
            List<DTO.PickingStatus> list = new List<DTO.PickingStatus>();
            string query = "GetPickingStatusCustomer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.PickingStatus parseToEntity = new DTO.PickingStatus(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<PackingProgress> GetPackingStatusProgress()
        {
            List<PackingProgress> list = new List<PackingProgress>();
            string query = "GetPackingStatusTotalProgressChart";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PackingProgress parseToEntity = new PackingProgress(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<PickingProgress> GetPickingStatusProgress()
        {
            List<PickingProgress> list = new List<PickingProgress>();
            string query = "GetPickingStatusTotalProgressChart";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PickingProgress parseToEntity = new PickingProgress(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<PickingProgress> GetPickingStatusProgress2()
        {
            List<PickingProgress> list = new List<PickingProgress>();
            string query = "GetPickingStatusTotalProgressChart2";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PickingProgress parseToEntity = new PickingProgress(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<PickingProgress> GetPackingGetdate()
        {
            List<PickingProgress> list = new List<PickingProgress>();
            string query = "GetPickingStatusTotalProgressChart";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PickingProgress parseToEntity = new PickingProgress(item);
                list.Add(parseToEntity);
            }
            return list;
        }

        /* public bool StartStocktake(string ID)
         {
             string query = "InsertStockTakeMaster @DisPlayName ";
             int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID});
             return result > 0;
         }
         public bool EndStocktake(string PIC, string formName)
         {
             string query = "CloseStockTake @PIC , @FormName";
             int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PIC , formName});
             return result > 0;
         }*/
    }
}
