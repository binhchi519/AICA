using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class PackingStatus
    {
        private string _customer;
        private string _actual;
        private string _plan;
        private string _progress;
        public PackingStatus( string c, string a, string p)
        {

            Customer = c;
            Plan = p;
            Actual = a;
            Progress = String.Format("{0:0.00}", (float.Parse(Actual) / float.Parse(Plan) * 100)) + "%";
        }
        public PackingStatus(DataRow row )
        {
            Customer = row["Customer"].ToString();
            Plan = row["Total"].ToString();
            Actual = row["Actual"].ToString();
            Progress =  String.Format("{0:0.00}", (float.Parse(Actual) / float.Parse(Plan) * 100))+ "%";
        }
        public string Customer { get => _customer; set => _customer = value; }
        public string Plan { get => _plan; set => _plan = value; }
        public string Actual { get => _actual; set => _actual = value; }
        public string Progress { get => _progress; set => _progress = value; }
       
    }
}
