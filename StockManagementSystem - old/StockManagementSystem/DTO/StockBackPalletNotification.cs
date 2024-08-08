using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class StockBackPalletNotification
    {
    
        private string _itemCode;
        private string _palletNo;
        private string _locationCode;

        public StockBackPalletNotification(string itemCode, string palletNo, string locationCode)
        {
            ItemCode = itemCode;
            PalletNo = palletNo;
            LocationCode = locationCode;
        }
        public StockBackPalletNotification(DataRow row)
        {
            ItemCode = row["ItemCode"].ToString(); 
            PalletNo = row["PalletNo"].ToString(); 
            LocationCode = row["LocationCode"].ToString();
        }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string PalletNo { get => _palletNo; set => _palletNo = value; }
        public string LocationCode { get => _locationCode; set => _locationCode = value; }
         }
}
