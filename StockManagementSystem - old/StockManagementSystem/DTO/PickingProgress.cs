using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class PickingProgress
    {
        private string _customer;
        private string _actual; 
        private string _plan;
        private DateTime _ETD;
        private DateTime _minCreatedDate;
        private string _loadingTime;


        public PickingProgress( string c, string a, DateTime d,string loadingtime)
        {
            Customer = c;
            Actual = a;
            ETD = d;
            LoadingTime = loadingtime;
        }
        public PickingProgress(DataRow row )
        {
            Customer = row["Customer"].ToString();
            Actual = row["Actual"].ToString();
            Plan = row["Total"].ToString();
            ETD = !String.IsNullOrEmpty(row["ETD"].ToString()) ? DateTime.Parse(row["ETD"].ToString()) : DateTime.MinValue;
            MinCreatedDate = !String.IsNullOrEmpty(row["MinCreatedDate"].ToString()) ? DateTime.Parse(row["MinCreatedDate"].ToString()) : DateTime.MinValue;
            LoadingTime = row["LoadingTime"].ToString();
        }
        public string Customer { get => _customer; set => _customer = value; }
        public string Actual { get => _actual; set => _actual = value; }
        public string Progress { get => String.Format("{0:0.00}", (float.Parse(Actual) / float.Parse(Plan) * 100)) ; }
        public string Plan { get => _plan; set => _plan = value; }
        public DateTime ETD { get => _ETD; set => _ETD = value; }
        public DateTime MinCreatedDate { get => _minCreatedDate; set => _minCreatedDate = value; }
        public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
        public Color Color { get; internal set; }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
