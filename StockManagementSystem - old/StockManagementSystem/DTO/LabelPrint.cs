using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class LabelPrint
    {
        private string _itemCode;
        private string _itemName;
        private string _size;
        private string _palletNo;
        private string _updateTime;
        private string _pic;
        private string _locationCode;
        private bool _isEnable;
        public LabelPrint(DataRow row)
        {
            ItemCode = row["ItemCode"].ToString();
            ItemName = row["ItemName"].ToString();
            Size = row["size"].ToString();
            PalletNo = row["PalletNo"].ToString();
            UpdateTime = row["UpdateTime"].ToString();
            Pic = row["PIC"].ToString();
            LocationCode = row["LocationCode"].ToString();
            IsEnable =row["isEnable"].ToString().Equals("True");
            String A = row["isEnable"].ToString();
        }

        public LabelPrint(string itemCode, string itemName, string size, string palletNo, string updateTime, string pic, string locationCode)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            Size = size;
            PalletNo = palletNo;
            UpdateTime = updateTime;
            Pic = pic;
            LocationCode = locationCode;
        }

        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string Size { get => _size; set => _size = value; }
        public string PalletNo { get => _palletNo; set => _palletNo = value; }
        public string UpdateTime { get => _updateTime; set => _updateTime = value; }
        public string Pic { get => _pic; set => _pic = value; }
        public string LocationCode { get => _locationCode; set => _locationCode = value; }
        public bool IsEnable { get => _isEnable; set => _isEnable = value; }
    }
}
