using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class LoadingStatus2
    {
        private string _customer;
        private int _actual;
        private int _plan;
        private string _progress;
        private string _loadingTime;
        private DateTime _ETD;
        public LoadingStatus2(string c, int a, int p,string load,DateTime etd)
        {

            Customer = c;
            Plan = p;
            Actual = a;
            Progress = String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)) + "%";
            LoadingTime = load;
            ETD = etd;
        }
        public LoadingStatus2()
        {
        }
        public LoadingStatus2(DataRow row)
        {
            Customer = row["Customer"].ToString();
            Plan = int.Parse(row["Total"].ToString());
            Actual = int.Parse(row["Actual"].ToString());
            Progress = String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)) + "%";
            LoadingTime= row["LoadingTime"].ToString();
            ETD = DateTime.Parse(row["ETD"].ToString());
        }
        public string Customer { get => _customer; set => _customer = value; }
        public int Plan { get => _plan; set => _plan = value; }
        public string sPlan { get => _plan.ToString(); set => _plan = int.Parse(value); }
        public string sActual { get => _actual.ToString(); set => _actual = int.Parse(value); }
        public int Actual { get => _actual; set => _actual = value; }
        public string Progress { get => String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)); set => _progress = value; }
        public string sProgress { get => String.Format("{0:0.00}", (float.Parse(sActual) / float.Parse(sPlan) * 100)) + "%"; set => _progress = value; }
        public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
        public DateTime ETD { get => _ETD; set => _ETD = value; }
    }
}
