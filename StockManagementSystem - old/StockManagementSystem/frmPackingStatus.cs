using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockManagementSystem
{
    public partial class frmPackingStatus : DevExpress.XtraEditors.XtraForm
    {
        BindingSource table = new BindingSource();
        int countAddXY = 0;

        private System.Windows.Forms.Timer refreshTimer;
        public frmPackingStatus()
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
            Series series = donutChart.Series["TotalPallet"]; 
            Series series1 = PKLPalletChart.Series["Plan"]; 
            Series series2 = PKLPalletChart.Series["Actual"]; 
            Series series3 = PKLPalletChart.Series["Actual %"]; 
            Series series4 = progressChart.Series["Late"]; 
            //Series series5 = progressChart.Series["Caution"]; 
            Series series6 = progressChart.Series["Good"];
            series.Points.Clear();
            series1.Points.Clear();
            series2.Points.Clear();
            series3.Points.Clear();
            series4.Points.Clear();
            //series5.Points.Clear();
            series6.Points.Clear();

            //Chart chart = new Chart();
            //chart.ChartAreas.Add(new ChartArea("bio"));
            //this.Controls.Add(chart);

            List<PackingStatusPIC> listPIC = HistoryDAO.Instance.GetAllPICPackingStatus();
            /* listPIC = listPIC.GroupBy(item => item.PIC)
             .Select(group => new PackingStatusPIC
             {
                 PIC = group.Key,
                 ShippingPallet = string.Join(", ", group.Select(item => item.ShippingPallet))
             })
             .ToList();*/
            List<PackingStatusPIC> PICNot_Shipout = new List<PackingStatusPIC>();

            dgPIC.DataSource = listPIC;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // "SE Asia Standard Time" is the IANA time zone ID for HCMC, Vietnam

            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
            CultureInfo japaneseCulture = new CultureInfo("ja-JP");
            string formattedDateTime = localTime.ToString("dddd, dd/MM/yyyy \n hh:mm tt",japaneseCulture);

            txtTimer.Text = formattedDateTime;
           // txtTimer.Text = DateTime.Now.DayOfWeek+" ,"+ DateTime.UtcNow;
            List<DTO.PackingProgress> sourceData = DasboardDAO.Instance.GetPackingStatusProgress();
            List<DTO.PackingProgress> sourceProgress = DasboardDAO.Instance.GetPackingStatusProgress();
            List<DTO.PackingProgress> parseResult = new List<DTO.PackingProgress>();
            float is100 = 100;
            string fotmat_is100 = String.Format("{0:0.00}", is100);
            DateTime isday = DateTime.Now.AddDays(1);
            DateTime today = DateTime.Now.Date;
            int getdaycurrent = today.Day;
            DateTime yesterday = DateTime.Now.Date.AddDays(-1);
            string formattedDate = today.ToString("yyyy-MM-dd");
            // List<string> listCustomers = new List<string>();
            //Series seri;



            foreach (PackingProgress item in sourceProgress)
            {
                PKLPalletChart.Series["Plan"].IsValueShownAsLabel = true;
                PKLPalletChart.Series["Actual"].IsValueShownAsLabel = true;
                PKLPalletChart.Series["Actual %"].IsValueShownAsLabel = true;
                PKLPalletChart.ChartAreas[0].AxisX.Interval = 1;
                donutChart.Series["TotalPallet"].Points.AddXY(item.Customer, item.Plan);
                PKLPalletChart.Series["Plan"].Points.AddXY(item.Customer, item.Plan);
                PKLPalletChart.Series["Actual"].Points.AddXY(item.Customer, item.Actual);
                PKLPalletChart.Series["Actual %"].Points.AddXY(item.Customer, (item.Progress.Substring(0, item.Progress.Length - 3)));
            }
            //progressChart.Series["Good"].IsValueShownAsLabel = true;
            //progressChart.Series["Late"].IsValueShownAsLabel = true;
            //progressChart.Series["Caution"].IsValueShownAsLabel = true;
            progressChart.ChartAreas[0].AxisX.Interval = 1;
            int index;
            for (int i = 0; i < sourceProgress.Count; i++)
            {
                double progress = getProgress(sourceProgress[i].Plan, sourceProgress[i].Actual);
                int loadingday = 0;
                //if (sourceProgress[i].ETD < today)
                //{
                //    progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    continue;
                //}
                TimeSpan betweenDay = (sourceProgress[i].ETD - DateTime.Now);
                int day = betweenDay.Days;
                if (sourceProgress[i].ETD == today || sourceProgress[i].ETD == today.AddDays(-1) /*&& progress < 100.00*/)
                {

                    // chart.Series.Add("bioz");
                    index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, progress);
                    progressChart.Series["Good"].Points[index].Color = Color.Red;

                    //chart.Series["bioz"].ChartType = SeriesChartType.Bar;
                    //progressChart.Series["Late"].IsValueShownAsLabel = true;

                    //progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                    //progressChart.Series["Caution"].Points.Clear;
                    //progressChart.Series["Good"].Points.RemoveAt(i);
                    //progressChart.ChartAreas[i].AxisX.Interval = 1 + 1;
                }
                else if (sourceProgress[i].ETD == today || sourceProgress[i].ETD == today.AddDays(+1) /*&& progress < 100.00*/)
                {
                    index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, progress);
                    progressChart.Series["Good"].Points[index].Color = Color.Yellow;
                    //    //progressChart.Series["Late"].Points.Clear();
                    //    progressChart.Series["Caution"].IsValueShownAsLabel = true;

                    //    progressChart.Series["Caution"].Points.AddXY(sourceProgress[i].Customer, progress);
                    //    progressChart.Series["Late"].Enabled = false;
                    //    progressChart.Series["Good"].Enabled = false;
                    //    //progressChart.ChartAreas[i].AxisX.Interval = 1+1;
                }
                else
                {
                    //chart.Series.Add("bioz");
                    index = progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, progress);
                    progressChart.Series["Good"].Points[index].Color = Color.Green;
                    //progressChart.Series["Good"].Color = Color.Green;
                    //chart.Series["bioz"].ChartType = SeriesChartType.Bar;
                    //progressChart.Series["Late"].IsValueShownAsLabel = true;

                    //progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                    //progressChart.Series["Caution"].Points.Clear;
                }

                //}
                //if (sourceProgress[i].ETD == today.AddDays(1) && progress > 0)
                //{
                //    //progressChart.Series["Late"].Points.Clear();
                //    progressChart.Series["Caution"].IsValueShownAsLabel = true;
                //    progressChart.Series["Caution"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Caution"].IsValueShownAsLabel = true;
                //    //progressChart.ChartAreas[i].AxisX.Interval = 1+1;
                //    continue;
                //}
                //else if (sourceProgress[i].ETD > today.AddDays(1) && progress == 0)
                //{
                //    progressChart.Series["Good"].IsValueShownAsLabel = true;
                //    progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Good"].IsValueShownAsLabel = true;
                //    //progressChart.ChartAreas[i].AxisX.Interval = 1 + 1;
                //    continue;
                //}
                //else if (sourceProgress[i].ETD <= today.AddDays(1) && progress > 0)
                //{
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //    progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //    //progressChart.ChartAreas[i].AxisX.Interval = 1 + 1;
                //    continue;

                //}
                //else
                //{
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //    progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //}
                //if (sourceProgress[i].ETD == today.AddDays(1) && progress > 0)
                //{
                //    //progressChart.Series["Late"].Points.Clear();
                //    progressChart.Series["Caution"].IsValueShownAsLabel = true;
                //    progressChart.Series["Caution"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Caution"].IsValueShownAsLabel = true;
                //    //progressChart.ChartAreas[i].AxisX.Interval = 1+1;
                //    continue;
                //}
                //else if (sourceProgress[i].ETD > today.AddDays(1) && progress == 0)
                //{
                //    progressChart.Series["Good"].IsValueShownAsLabel = true;
                //    progressChart.Series["Good"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Good"].IsValueShownAsLabel = true;
                //    //progressChart.ChartAreas[i].AxisX.Interval = 1 + 1;
                //    continue;
                //}
                //else if (sourceProgress[i].ETD <= today.AddDays(1) && progress > 0 )
                //{
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //    progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //    //progressChart.ChartAreas[i].AxisX.Interval = 1 + 1;
                //    continue;

                //}
                //else
                //{
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //    progressChart.Series["Late"].Points.AddXY(sourceProgress[i].Customer, progress);
                //    progressChart.Series["Late"].IsValueShownAsLabel = true;
                //}    

            }


            table.DataSource = sourceData;
            dgPacking.DataSource = table;   
        }
        private int getProgress(string plan, string actual) {
            return int.Parse(plan) - int.Parse(actual);
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
    }
}