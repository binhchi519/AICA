using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class UserManagementDAO
    {
        private static UserManagementDAO _instance;

        public static UserManagementDAO Instance
        {
            get { if (_instance == null) _instance = new UserManagementDAO(); return UserManagementDAO._instance; }
            private set { UserManagementDAO._instance = value; }
        }

        private UserManagementDAO() { }

       /* public DataTable Login(string username, string password)
        {
            string query = "GetUserLogin @username , @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return data;
        }*/
        public LoginedUser LoginedUser(string username, string password)
        {
            string query = "GetUserLogin @username , @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            LoginedUser user;
            foreach (DataRow item in data.Rows)
            {
                user = new LoginedUser(item);
                return user;
            }
            return null;
        }
        public string GetPermissionsOfUser(string username)
        {
            string query = "GetAccessTokenUser @username ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            string accesstokens ="";
            foreach (DataRow item in data.Rows)
            {
                accesstokens += item["Permission"].ToString()+"|";
              
            }
            return accesstokens;
        }
        public List<UserManagement> GetListUser()
        {
            List<UserManagement> list = new List<UserManagement>();
            string query = "GetAllUsers";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                UserManagement users = new UserManagement(item);
                list.Add(users);
            }
            return list;
        }

        public bool UpdateUser(string username, string password, string displayname, bool isAdmin)
        {
            string query = "UpsertUserMaster @UserName , @DisplayName , @IsAdmin , @Password";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, displayname, isAdmin, password });
            return result > 0;
        }

        public bool DeleteUser(string username)
        {
            string query = "DeleteUser @UserName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });
            return result > 0;
        }
      

    }
}
