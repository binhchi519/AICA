using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class PODetail
    {
        private string _poNo;
        private DateTime _poDate;
        private string _customer;
        private string _itemCode;
        private bool _film;
        private float _thickness;
        private int _totalqty;
        private string _priority;
        private int _qty;
        private string _iD;
        private int _availableQuantity;
        private string _size;
        private float _actualThickness;
        private int _QtyPerPallet;
        private int _ShippingQty;
        private DateTime _oldDateExisted;

        public PODetail(string iD, string pono, DateTime podate, string customer, string item, bool film, float thickness, int totalQty, string priority, int qty, int availableQuantity, string size, float actualThickness, int qtyPerPallet)
        {
            ID = iD;
            PONo = pono;
            PODate = podate;
            Customer = customer;
            Item = item;
            Film = film;
            Thickness = thickness;
            TotalQty = totalQty;
            Priority = priority;
            Qty = qty;
            AvailableQuantity = availableQuantity;
            Size = size;
            ActualThickness = actualThickness;
            QtyPerPallet = qtyPerPallet;
        }

        public PODetail(DataRow row)
        {
            ID = row["ID"].ToString();
            PONo = row["POno"].ToString();
            PODate = DateTime.Parse(row["PoDate"].ToString());
            Customer = row["Customer"].ToString();
            Item = row["ItemCode"].ToString();
            Film = Boolean.Parse(row["Film"].ToString());
            Thickness = float.Parse(row["Thickness"].ToString());
            TotalQty = Int32.Parse(row["POQty"].ToString());
            Priority = row["POPriority"].ToString();
            Qty = Convert.ToInt32(row["ShippingQty"].ToString());
            if (!String.IsNullOrEmpty(row["ShippingQty"].ToString()))
            {
                _ShippingQty = Convert.ToInt32(row["ShippingQty"].ToString());
            }
            else
            {
                _ShippingQty = 0;
            }
            if (!String.IsNullOrEmpty(row["AvailableQuantity"].ToString()))
            {
                AvailableQuantity = Convert.ToInt32(row["AvailableQuantity"].ToString());
                if (!String.IsNullOrEmpty(row["ReseversQty"].ToString()))
                {
                    AvailableQuantity -= Convert.ToInt32(row["ReseversQty"].ToString());   
                }
                if (!String.IsNullOrEmpty(row["B1AvailableQuantity"].ToString()))
                {
                    AvailableQuantity -= Convert.ToInt32(row["B1AvailableQuantity"].ToString());
                    
                }
                if (!String.IsNullOrEmpty(row["MaskingQuantity"].ToString()))
                {
                    AvailableQuantity += Convert.ToInt32(row["MaskingQuantity"].ToString());

                }
                AvailableQuantity = AvailableQuantity < 0 ? 0 : AvailableQuantity;
            }
            else
            {
                AvailableQuantity = 0;
            }
            Size = row["size"].ToString();
            ActualThickness = float.Parse(row["ActualThickness"].ToString());
            QtyPerPallet = Int32.Parse(row["QtyPerPallet"].ToString());

            if (!String.IsNullOrEmpty(row["OldDateExisted"].ToString()))
            {
                OldDateExisted = DateTime.Parse(row["OldDateExisted"].ToString());
            }
            else
            {
                OldDateExisted = DateTime.Today;
            }
        }


        public string PONo { get => _poNo; set => _poNo = value; }
        public DateTime PODate { get => _poDate; set => _poDate = value; }
        public DateTime OldDateExisted { get => _oldDateExisted; set => _oldDateExisted = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public string Item { get => _itemCode; set => _itemCode = value; }
        public bool Film { get => _film; set => _film = value; }
        public float Thickness { get => _thickness; set => _thickness = value; }
        public int TotalQty { get => _totalqty; set => _totalqty = value; }
        public string Priority { get => _priority; set => _priority = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public string ID { get => _iD; set => _iD = value; }
        public int AvailableQuantity { get => _availableQuantity; set => _availableQuantity = value; }
        public string Size { get => _size; set => _size = value; }
        public float ActualThickness { get => _actualThickness; set => _actualThickness = value; }
        public int QtyPerPallet { get => _QtyPerPallet; set => _QtyPerPallet = value; }
        public int ShippingQty { get => _ShippingQty; set => _ShippingQty = value; }
    }
}
