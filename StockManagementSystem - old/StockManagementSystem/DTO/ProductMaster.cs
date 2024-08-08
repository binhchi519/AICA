using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StockManagementSystem.DTO
{
    public class ProductMaster
    {
        private string _itemCode;
        private string _itemName;
        private string _size;
        private bool _film;
        private string _locationCode;
        private float _thickness;
        private float _actualThickness;
        private int _qtyPerPallet;
        private string _uom;

        public ProductMaster(string itemCode, string itemName, string size, bool film, string locationCode, float thickness, float actualThickness, int qtyPerPallet, string uom)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            Size = size;
            Film = film;
            LocationCode = locationCode;
            Thickness = thickness;
            ActualThickness = actualThickness;
            QtyPerPallet = qtyPerPallet;
            Uom = uom;
        }

        public ProductMaster(DataRow row)
        {
            ItemCode = row["ItemCode"].ToString();
            ItemName = row["ItemName"].ToString();
            Size = row["Size"].ToString();
            Film = Boolean.Parse(row["Film"].ToString());
            LocationCode = row["LocationCode"].ToString();
            Thickness = float.Parse(row["Thickness"].ToString());
            ActualThickness = float.Parse(row["ActualThickness"].ToString());
            QtyPerPallet = int.Parse(row["QtyPerPallet"].ToString());
            Uom = row["UOM"].ToString();
        }

        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string Size { get => _size; set => _size = value; }
        public bool Film { get => _film; set => _film = value; }
        public string LocationCode { get => _locationCode; set => _locationCode = value; }
        public float Thickness { get => _thickness; set => _thickness = value; }
        public float ActualThickness { get => _actualThickness; set => _actualThickness = value; }
        public int QtyPerPallet { get => _qtyPerPallet; set => _qtyPerPallet = value; }
        public string Uom { get => _uom; set => _uom = value; }
    }
}
