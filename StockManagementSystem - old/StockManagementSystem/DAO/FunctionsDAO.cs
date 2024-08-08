using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class FunctionsDAO
    {
        private static FunctionsDAO _instance;

        public static FunctionsDAO Instance
        {
            get { if (_instance == null) _instance = new FunctionsDAO(); return FunctionsDAO._instance; }
            private set { FunctionsDAO._instance = value; }
        }

        private FunctionsDAO() { }

        public List<Functions> GetAllPermissons()
        {
            List<Functions> list = new List<Functions>();
            string query = "GetAllPermissons";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Functions parseToEntity = new Functions(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public List<UserPermission> GetListPermissionsOfUser(string username)
        {
            List<UserPermission> list = new List<UserPermission>();
            string query = "GetPermissionsOfUser '" + username+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                UserPermission parseToEntity = new UserPermission(item);
                list.Add(parseToEntity);
            }
            return list;
        }
        public DataTable performFunctions(string functionID, string Devices, string Frmmenu, string FunctionName, string Permission, string UpdateBy, string Delete)
        {
            string query = "performFunctions @FunctionID , @Devices , @Frmmenu , @FunctionName , @Permission , @UpdateBy , @Delete";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { functionID, Devices, Frmmenu, FunctionName, Permission, UpdateBy, Delete });
            return data;
        }  
        public DataTable UpsertUserPermission(string username, string functionID, bool isAllowed, string updateBy)
        {
            string query = "UpsertUserPermission @username , @FunctionID , @isAllowed , @updateBy";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, functionID, isAllowed, updateBy });
            return data;
        }
        /*public List<DTO.PickingStatus> GetPickingStatusTable()
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
        } public List<PackingProgress> GetPackingStatusProgress()
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
        }public List<PickingProgress> GetPickingStatusProgress()
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
        }*/
    }
}
