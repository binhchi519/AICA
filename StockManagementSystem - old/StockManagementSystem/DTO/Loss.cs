using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StockManagementSystem.DTO
{
    public class Loss
    {
        private string _lossCode;
        private string _lossName;

        public Loss(string locationCode, string locationName)
        {
            LossCode = locationCode;
            LossName = locationName;
        }

        public Loss(DataRow row)
        {
            LossCode = row["LossReasonCode"].ToString();
            LossName = row["LossReasonName"].ToString();
        }

        public string LossCode { get => _lossCode; set => _lossCode = value; }
        public string LossName { get => _lossName; set => _lossName = value; }
    }
}
