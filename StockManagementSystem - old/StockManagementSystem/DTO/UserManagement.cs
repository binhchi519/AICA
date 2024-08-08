using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StockManagementSystem.DTO
{
    public class UserManagement
    {

        private string _username;
        private string _password;
        private string _displayName;
        private bool _isAdmin;

        public UserManagement(string username, string password, string displayName, bool isAdmin)
        {
            Username = username;
            Password = password;
            DisplayName = displayName;
            IsAdmin = isAdmin;
        }

        public UserManagement (DataRow row)
        {
            Username = row["UserName"].ToString();
            Password = row["Password"].ToString();
            DisplayName = row["DisplayName"].ToString();
            IsAdmin = Boolean.Parse(row["IsAdmin"].ToString());
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
    }
}
