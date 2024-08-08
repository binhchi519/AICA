using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class LoadingTime
    {
        private string _loadingtime;

        public LoadingTime(string loadingtime)
        {
            Loadingtime = loadingtime;
        }

        public LoadingTime(DataRow row)
        {
            Loadingtime = row["LoadingTime"].ToString();
        }

        public string Loadingtime { get => _loadingtime; set => _loadingtime = value; }
    }
}
