using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class LoadingData
    {
        private string _customer;
        private string _shippingPalletNo;
        private string _LoadingTime;
        private int _packingStatus;
        public LoadingData( string c, string s,string l, int p )
        {
            Customer = c;
            ShippingPalletNo = s;
            LoadingTime = l;
            PackingStatus = p;
        }
        public LoadingData(DataRow row )
        {
            Customer = row["Customer"].ToString();
            ShippingPalletNo = row["ShippingPalletNo"].ToString();
            LoadingTime = row["LoadingTime"].ToString();
            PackingStatus =  int.Parse(row["PackingStatus"].ToString());
        }
        public string Customer { get => _customer; set => _customer = value; }
        public string ShippingPalletNo { get => _shippingPalletNo; set => _shippingPalletNo = value; }
        public string LoadingTime { get => _LoadingTime; set => _LoadingTime = value; }
        public int PackingStatus { get => _packingStatus; set => _packingStatus = value; }
       
    }
}
