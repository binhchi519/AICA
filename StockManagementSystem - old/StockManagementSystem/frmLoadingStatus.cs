using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockManagementSystem
{
    public partial class frmLoadingStatus : XtraForm
    {
        BindingSource table = new BindingSource();
        BindingSource table2 = new BindingSource();
        DateTime monthData = DateTime.Now;
        
        DateTime MData = DateTime.Now.Date;
        private System.Windows.Forms.Timer refreshTimer;
        public frmLoadingStatus()
        {
            InitializeComponent();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call the Form_Load method or any other method here
            form_Load(null, null);

        }
        private void form_Load(object sender, EventArgs e)
        {
            DeliveryPalletChart.Titles["titleDelivery"].Text = monthData.Month == 1 ? "Delivery Progress in January" :
                 monthData.Month == 2 ? "Delivery Progress in February" :
                 monthData.Month == 3 ? "Delivery Progress in March" :
                 monthData.Month == 4 ? "Delivery Progress in April" :
                 monthData.Month == 5 ? "Delivery Progress in May" :
                 monthData.Month == 6 ? "Delivery Progress in June" :
                 monthData.Month == 7 ? "Delivery Progress in July" :
                 monthData.Month == 8 ? "Delivery Progress in August" :
                 monthData.Month == 9 ? "Delivery Progress in September" :
                 monthData.Month == 10 ? "Delivery Progress in October" :
                 monthData.Month == 11 ? "Delivery Progress in November" : "Delivery Progress in December";

            // Assuming 'chart' is your chart control instance
            var xAxis = DeliveryPalletChart.ChartAreas[0].AxisX;
            xAxis.Interval = 1;
            xAxis.LabelStyle.Font = new Font("Times New Roman", 13f, FontStyle.Regular);
            // Rotate X-axis labels by 45 degrees
            // xAxis.LabelStyle.Angle = 45;

            Series series1 = DeliveryPalletChart.Series["Plan"];
            Series series2 = DeliveryPalletChart.Series["Actual"];
            Series series3 = DeliveryPalletChart.Series["Actual %"];
            series1.Points.Clear();
            series2.Points.Clear();
            series3.Points.Clear();


            List<PackingStatusPIC> listPIC = HistoryDAO.Instance.GetAllPICPackingStatus();
            /* listPIC = listPIC.GroupBy(item => item.PIC)
             .Select(group => new PackingStatusPIC
             {
                 PIC = group.Key,
                 ShippingPallet = string.Join(", ", group.Select(item => item.ShippingPallet))
             })
             .ToList();*/
            dgPIC.DataSource = listPIC;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // "SE Asia Standard Time" is the IANA time zone ID for HCMC, Vietnam

            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
            CultureInfo japaneseCulture = new CultureInfo("ja-JP");
            string formattedDateTime = localTime.ToString("dddd, dd/MM/yyyy \n hh:mm tt", japaneseCulture);

            txtTimer.Text = formattedDateTime;
            DateTime DayData = DateTime.Now;
            string formatted_month = monthData.ToString("MM");
            string formatted_Year = monthData.ToString("yyyy");
            int dayOfMonth = DayData.Day;
            List<LoadingStatus2> sourceData = DasboardDAO.Instance.GetLoadingStatusCustomer2();
             List<LoadingStatus> sourceDataMonth = DasboardDAO.Instance.GetLoadingStatusCustomer(formatted_month, formatted_Year);

            foreach (LoadingStatus item in sourceDataMonth)
            {
                DeliveryPalletChart.Series["Plan"].Points.AddXY(item.Customer, item.Plan);
                DeliveryPalletChart.Series["Actual"].Points.AddXY(item.Customer, item.Actual);
                DeliveryPalletChart.Series["Actual %"].Points.AddXY(item.Customer, item.Progress/*.Substring(0, item.Progress.Length - 4)*/);
            }

            //DateTime today = DateTime.Now.Date; // Get today's date without the time
            //List<string> Homqua_HomNay = new List<string>();
            //foreach (LoadingStatus item in sourceData)
            //{
            //    if (item..Equals(System.DateTime.Now))
            //    {
            //        //if(item.ETD.Equals(DateTime.Now.Date))
            //        //{
            //        if (!packingGetdate.Contains(item.Customer))
            //        {
            //            packingGetdate.Add(item.Customer);
            //        }
            //        //}

            //    }
            //}


            table2.DataSource = sourceData;
            dgLoading.DataSource = table2;
            table.DataSource = sourceDataMonth;
            dgLoadingMonth.DataSource = table;
        }


        private void chkboxAutoRefesh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAutoRefesh.Checked)
            {
                // Enable auto-refresh
                StartAutoRefresh();
            }
            else
            {
                // Disable auto-refresh
                StopAutoRefresh();
            }
        }

        private void StartAutoRefresh()
        {
            // Set the timer interval (in milliseconds)
            int refreshInterval = 5000; // 5 seconds

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = refreshInterval;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void StopAutoRefresh()
        {
            if (refreshTimer != null)
            {
                refreshTimer.Stop();
                refreshTimer.Dispose();
                refreshTimer = null;
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Refresh form
            form_Load(null, null);
        }
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            chkboxAutoRefesh.Checked = false;
        }
    }
}