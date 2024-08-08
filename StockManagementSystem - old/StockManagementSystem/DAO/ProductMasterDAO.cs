using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class ProductMasterDAO
    {
        private static ProductMasterDAO _instance;

        public static ProductMasterDAO Instance
        {
            get { if (_instance == null) _instance = new ProductMasterDAO(); return ProductMasterDAO._instance; }
            private set { ProductMasterDAO._instance = value; }
        }

        private ProductMasterDAO() { }

        public List<ProductMaster> GetListProduct()
        {
            List<ProductMaster> list = new List<ProductMaster>();
            string query = "GetAllProductMaster";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductMaster product = new ProductMaster(item);
                list.Add(product);
            }
            return list;
        }

        public bool InsertAndUpdateProduct(string itemCode, string itemName, string size, bool film, string locationCode, float thickness, float actualThickness, int qtyPerPallet, string uom)
        {
            string query = "UpsertProductMaster @ItemCode , @ItemName , @Size , @Film , @LocationCode , @Thickness , @ActualThickness , @QtyPerPallet , @UOM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { itemCode, itemName, size, film, locationCode, thickness, actualThickness, qtyPerPallet, uom });
            return result > 0;
        }

        public bool DeleteProduct(string itemCode)
        {
            string query = "DeleteProductMaster @ItemCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { itemCode });
            return result > 0;
        }
    }
}
