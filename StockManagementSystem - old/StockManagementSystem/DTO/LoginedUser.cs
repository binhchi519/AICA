using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public  class LoginedUser
    {
        public static String _UserName;
        public static String _DisplayName;
        public static String _Role;
        public static String _AccessToken;


        public LoginedUser(DataRow row)
        {
            _UserName = row["UserName"].ToString();
            _DisplayName = row["DisplayName"].ToString();
            _Role = row["IsAdmin"].ToString();
        }


        public string UserName { get => _UserName; set => _UserName = value; }
        public string DisplayName { get => _DisplayName; set => _DisplayName = value; }
        public string Role { get => _Role; set => _Role = value; }
        public string AccessToken { get => _AccessToken; set => _AccessToken = value; }
         
    }
}
