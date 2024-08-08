using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StockManagementSystem.DTO
{
    public class PackingStatusPIC
    {
        private string _pic;
        private string _shippingPallet;
        private string _loadingTime;
        private int _count;

        public PackingStatusPIC(string pic, string shippingpallet)
        {
            PIC = pic;
            ShippingPallet = shippingpallet;
            CountPallets = 1;
        }
        public PackingStatusPIC()
        { }
        public PackingStatusPIC(DataRow row)
        {
            PIC = row["PersonInCharge"].ToString();
            ShippingPallet = row["ShippingPalletNo"].ToString();
            LoadingTime = row["LoadingTime"].ToString();
        }
        public bool AddWithCondition(string pic, string shippingpallet) {
            if (CountPallets > 1)
            {
                return false;
            }

            if (!pic.Equals(PIC))
            {
                return false;
            }
            ShippingPallet += " ," + shippingpallet;
            return true;
        }

        public string PIC { get => _pic; set => _pic = value; }
        public string ShippingPallet { get => _shippingPallet; set => _shippingPallet = value; }
        public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
        public int CountPallets { get => _count; set => _count = value; }
    }
}
