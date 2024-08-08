using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class LoadingStatus
    {
        private string _customer;
        private int _actual;
        private int _plan;
        private string _progress;
        private string _loadingTime;
        public LoadingStatus(string c, int a, int p,string load)
        {

            Customer = c;
            Plan = p;
            Actual = a;
            Progress = String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)) + "%";
            LoadingTime = load;
        }
        public LoadingStatus()
        {
        }
        public LoadingStatus(DataRow row)
        {
            Customer = row["Customer"].ToString();
            Plan = int.Parse(row["Total"].ToString());
            Actual = int.Parse(row["Actual"].ToString());
            Progress = String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)) + "%";
            LoadingTime= row["ETD"].ToString();
        }
        public string Customer { get => _customer; set => _customer = value; }
        public int Plan { get => _plan; set => _plan = value; }
        public string sPlan { get => _plan.ToString(); set => _plan = int.Parse(value); }
        public string sActual { get => _actual.ToString(); set => _actual = int.Parse(value); }
        public int Actual { get => _actual; set => _actual = value; }
        public string Progress { get => String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)); set => _progress = value; }
        public string sProgress { get => String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)) + "%"; set => _progress = value; }
        public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
    }
}
