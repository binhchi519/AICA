using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class Functions
    {
        private string _id;
        private string _device; 
        private string _menuScreen;
        private string _functionName;
        private string _permission;
        private DateTime _updateTime;
        private string _updateBy;

       /* public Permission(string menuScreen, string functionName, string device, bool isAllowed,DateTime updateTime, string updateBy)
        {
            MenuScreen = menuScreen;
            FunctionName = functionName;
            Device = device;
            IsAllowed = isAllowed;
            UpdateTime = updateTime;
            UpdateBy = updateBy;
        }*/

        public Functions(DataRow row)
        {
            FunctionID = row["FunctionID"].ToString();
            Device = row["Devices"].ToString();
            MenuScreen = row["FrmMenu"].ToString();
            FunctionName = row["FunctionName"].ToString();
            BtnPermission = row["Permission"].ToString();
            UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
            UpdateBy = row["UpdateBy"].ToString();
        }

       
        public string MenuScreen { get => _menuScreen; set => _menuScreen = value; }
        public string FunctionName { get => _functionName; set => _functionName = value; }
        public string Device { get => _device; set => _device = value; }
        public string FunctionID { get => _id; set => _id = value; }
        public string BtnPermission { get => _permission; set => _permission = value; }
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }
        public string UpdateBy { get => _updateBy; set => _updateBy = value; }
    }
}
