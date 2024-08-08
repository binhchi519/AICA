using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;
using System.Data;

namespace StockManagementSystem.DAO
{
    public class LabelPrintDAO
    {
        private static LabelPrintDAO _instance;

        public static LabelPrintDAO Instance
        {
            get { if (_instance == null) _instance = new LabelPrintDAO(); return LabelPrintDAO._instance; }
            private set { LabelPrintDAO._instance = value; }
        }

        private LabelPrintDAO() { }

        public bool UpdatePalletEnable(string itemCode, string palletNo, string locationCode, bool isEnable ,string pic)
        {
            string query = "UpdatePalletEnable @ItemCode , @PalletNo , @LocationCode , @isEnable , @PIC ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { itemCode, palletNo, locationCode, isEnable, pic });
            return result > 0;
        }
        public List<LabelPrint> GetListLabelPrint()
        {
            List<LabelPrint> list = new List<LabelPrint>();
            string query = "GetAllPrintingPallet";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LabelPrint labelPrint = new LabelPrint(item);
                list.Add(labelPrint);
            }
            return list;
        }
        public List<LabelPrint> GetListLabelDetail()
        {
            List<LabelPrint> list = new List<LabelPrint>();
            string query = "GetAllPalletDetail";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LabelPrint labelPrint = new LabelPrint(item);
                list.Add(labelPrint);
            }
            return list;
        }
        public DataTable GetListLabelPrintByItem(string itemCode, string locationcode)
        {
            string query = "GetPalletDetailByItemCode @ItemCode , @LocationCode";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { itemCode, locationcode });
            return data;
        }

        public bool InsertAndUpdatePalletNo(string itemCode, string palletNo, string locationCode, string pic)
        {
            string query = "UpsertPalletDetail @ItemCode , @PalletNo , @LocationCode , @PIC ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { itemCode, palletNo, locationCode, pic });
            return result > 0;
        }
        public bool rePrintPalletNo(string itemCode, string palletNo, string locationCode, string pic)
        {
            string query = "EXEC rePrintPalletDetail @ItemCode , @PalletNo , @LocationCode , @PIC ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { itemCode, palletNo, locationCode, pic });
            return result > 0;
        }
    }
}
