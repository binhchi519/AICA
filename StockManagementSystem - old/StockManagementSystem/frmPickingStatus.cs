using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockManagementSystem
{
    public partial class frmPickingStatus : XtraForm
    {
        BindingSource table = new BindingSource();
        List<string> packingGetdate = new List<string>();
        private Timer timer = new Timer();
        private System.Windows.Forms.Timer refreshTimer;
        public frmPickingStatus()
        {

            InitializeComponent();
        }
        private void form_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Series series = donutChart.Series["TotalPallet"]; // Replace with the name of your series
            Series series1 = PKLPalletChart.Series["Plan"]; // Replace with the name of your series
            Series series2 = PKLPalletChart.Series["Actual"]; // Replace with the name of your series
            Series series3 = PKLPalletChart.Series["Actual %"]; // Replace with the name of your series
            Series series4 = progressChart.Series["Late"]; // Replace with the name of your series
            Series series5 = progressChart.Series["Caution"]; // Replace with the name of your series
            Series series6 = progressChart.Series["Good"]; // Replace with the name of your series
            Series series7 = progressChart.Series["Plan"]; // Replace with the name of your series
            series.Points.Clear();
            series1.Points.Clear();
            series2.Points.Clear();
            series3.Points.Clear();
            series4.Points.Clear();
            series5.Points.Clear();
            series6.Points.Clear();
            series7.Points.Clear();


            List<PackingStatusPIC> listPIC = HistoryDAO.Instance.GetAllPICPickingStatus();
            /*listPIC = listPIC.GroupBy(item => item.PIC)
            .Select(group => new PackingStatusPIC
            {
                PIC = group.Key,
                ShippingPallet = string.Join(", ", group.Select(item => item.ShippingPallet))
            })
            .ToList();*/
            //List<string> PIC_Getdate = new List<string>();

            dgPIC.DataSource = listPIC;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // "SE Asia Standard Time" is the IANA time zone ID for HCMC, Vietnam

            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
            CultureInfo japaneseCulture = new CultureInfo("ja-JP");
            string formattedDateTime = localTime.ToString("dddd, dd/MM/yyyy \n hh:mm tt", japaneseCulture);

            txtTimer.Text = formattedDateTime;
            List<PickingStatus> sourceData = DasboardDAO.Instance.GetPickingStatusTable();
            List<PickingProgress> sourceProgress = DasboardDAO.Instance.GetPickingStatusProgress();
            table.DataSource = sourceProgress;
            dgPacking.DataSource = table;
            //List<a>




            foreach (PickingProgress item in sourceProgress)
            {
                //if(item.MinCreatedDate.Equals(System.DateTime.Now))
                //    {

                donutChart.Series["TotalPallet"].Points.AddXY(item.Customer, item.Plan);
                PKLPalletChart.Series["Plan"].Points.AddXY(item.Customer, item.Plan);
                PKLPalletChart.Series["Actual"].Points.AddXY(item.Customer, item.Actual);
                PKLPalletChart.Series["Actual %"].Points.AddXY(item.Customer, item.Progress.Substring(0, item.Progress.Length - 3));
                //PKLPalletChart.Series["Actual"].Points.AddXY(item.Customer, item.);
                //}

                //listCustomers.Add(item.Customer);
            }
            DateTime today = DateTime.Now.Date; // Get today's date without the time
            string formattedDate = today.ToString("yyyy/MM/dd");
            List<string> customers = new List<string>();

            int index;
            int index2;
            progressChart.Series["Plan"].IsValueShownAsLabel = true;
            progressChart.Series["Good"].IsValueShownAsLabel = true;
            progressChart.Series["Late"].IsValueShownAsLabel = true;
            progressChart.Series["Caution"].IsValueShownAsLabel = true;
            progressChart.ChartAreas[0].AxisX.Interval = 1;
            DateTime thoiGianHienTai = DateTime.Now;
            DateTime thoiGianBatDau = new DateTime(thoiGianHienTai.Year, thoiGianHienTai.Month, thoiGianHienTai.Day, 6, 0, 0);
            DateTime thoiGianKetThuc12 = new DateTime(thoiGianHienTai.Year, thoiGianHienTai.Month, thoiGianHienTai.Day, 12, 0, 0);
            DateTime thoiGianKetThuc13 = new DateTime(thoiGianHienTai.Year, thoiGianHienTai.Month, thoiGianHienTai.Day, 13, 0, 0);
            DateTime thoiGianKetThuc14 = new DateTime(thoiGianHienTai.Year, thoiGianHienTai.Month, thoiGianHienTai.Day, 14, 0, 0);
            DateTime thoiGianKetThuc15 = new DateTime(thoiGianHienTai.Year, thoiGianHienTai.Month, thoiGianHienTai.Day, 15, 0, 0);
            DateTime thoiGianKetThuc18 = new DateTime(thoiGianHienTai.Year, thoiGianHienTai.Month, thoiGianHienTai.Day, 18, 0, 0);

            //progressChart.DataSource = sourceProgress.Where(x => double.Parse(x.Progress) <= 100);
            //progressChart.Series["Plan"] = (Series)sourceProgress.Where(x => double.Parse(x.Progress) <= 100);
            //var filteredProgress40 = sourceProgress.Where(x => double.Parse(x.Progress) < 40).ToList();
            //var filteredProgress_40 = sourceProgress.Where(x => double.Parse(x.Progress) >= 40).ToList();
            //var filteredProgress50 = sourceProgress.Where(x => double.Parse(x.Progress) < 50).ToList();
            //var filteredProgress_50 = sourceProgress.Where(x => double.Parse(x.Progress) >= 50).ToList();
            //var filteredProgress60 = sourceProgress.Where(x => double.Parse(x.Progress) < 60).ToList();
            //var filteredProgress_60 = sourceProgress.Where(x => double.Parse(x.Progress) >= 60).ToList();
            //var filteredProgress70 = sourceProgress.Where(x => double.Parse(x.Progress) < 70).ToList();
            //var filteredProgress_70 = sourceProgress.Where(x => double.Parse(x.Progress) >= 70).ToList();
            //var filteredProgress80 = sourceProgress.Where(x => double.Parse(x.Progress) < 80).ToList();
            //var filteredProgress_80 = sourceProgress.Where(x => double.Parse(x.Progress) >= 80).ToList();
            //var filteredProgress90 = sourceProgress.Where(x => double.Parse(x.Progress) < 90).ToList();
            //var filteredProgress_90 = sourceProgress.Where(x => double.Parse(x.Progress) >= 90).ToList();
            for (int i = 0; i < sourceProgress.Count; i++)
            {
                if (thoiGianHienTai >= thoiGianBatDau && thoiGianHienTai <= thoiGianKetThuc12)
                {
                   
                    if (float.Parse(sourceProgress[i].Progress) < 40)
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Red;
                    }
                    else if ((float.Parse(sourceProgress[i].Progress) >= 40) && (float.Parse(sourceProgress[i].Progress) < 50))
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Yellow;
                    }
                    else
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Lime;
                    }

                }
                if (thoiGianHienTai >= thoiGianKetThuc12 && thoiGianHienTai <= thoiGianKetThuc13)
                {
                    //index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                    //progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                    if (float.Parse(sourceProgress[i].Progress) < 50)
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Red;
                    }
                    else if ((float.Parse(sourceProgress[i].Progress) >= 50) && (float.Parse(sourceProgress[i].Progress) < 60))
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Yellow;
                    }
                    else
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Lime;
                    }

                }
                if (thoiGianHienTai >= thoiGianKetThuc13 && thoiGianHienTai <= thoiGianKetThuc14)
                {
                    //index2 = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                    //progressChart.Series["Plan"].Points[index2].Color = Color.DarkGray;
                    if (float.Parse(sourceProgress[i].Progress) < 60)
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Red;
                    }
                    else if ((float.Parse(sourceProgress[i].Progress) >= 60) && (float.Parse(sourceProgress[i].Progress) < 70))
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Yellow;
                    }
                    else
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Lime;
                    }


                }
                if (thoiGianHienTai >= thoiGianKetThuc14 && thoiGianHienTai <= thoiGianKetThuc15)
                {
                    //index2 = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                    //progressChart.Series["Plan"].Points[index2].Color = Color.DarkGray;
                    if (float.Parse(sourceProgress[i].Progress) < 70)
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Red;
                    }
                    else if ((float.Parse(sourceProgress[i].Progress) >= 70) && (float.Parse(sourceProgress[i].Progress) < 80))
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Yellow;
                    }
                    else
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Lime;
                    }

                }
                if (thoiGianHienTai > thoiGianKetThuc15 && thoiGianHienTai <= thoiGianKetThuc18)
                {
                    //index2 = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                    //progressChart.Series["Plan"].Points[index2].Color = Color.DarkGray;
                    if (float.Parse(sourceProgress[i].Progress) < 80)
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Red;
                    }
                    else if ((float.Parse(sourceProgress[i].Progress) >= 80) && (float.Parse(sourceProgress[i].Progress) < 90))
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Yellow;
                    }
                    else
                    {
                        index = progressChart.Series["Plan"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Plan);
                        progressChart.Series["Plan"].Points[index].Color = Color.DarkGray;
                        index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, sourceProgress[i].Actual);
                        progressChart.Series["Good"].Points[index].Color = Color.Lime;
                    }
                }
            }
        }

        private int getProgress(string plan, string actual)
        {
           return int.Parse(plan) - int.Parse(actual);
        }
        private int getPlan(string plan)
            {
                return int.Parse(plan);
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
            // Refresh your form here
            form_Load(null, null);
        }
        private void PKLPalletChart_Click(object sender, EventArgs e)
        {

        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            chkboxAutoRefesh.Checked = false;
        }

        private void progressChart_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void donutChart_Click(object sender, EventArgs e)
        {

        }
    }
}