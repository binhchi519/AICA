
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class frmProductionStatus : DevExpress.XtraEditors.XtraForm
    {
        private System.Windows.Forms.Timer refreshTimer;
        int packStatus = 1,
                loadingStatus = 1,
                pickStatus = 1;
        int statusLate = 0;
        int statusNormal = 1;
        int statusCaution = 2;
        int packingChart = 0;
        int pickingChart = 1;
        int loadingChart = 2;
        public frmProductionStatus()
        {
            InitializeComponent();
            form_Load(null, null);
        }
        private void form_Load(object sender, EventArgs e)
        {
            List<PackingProgress> sourcePackingProgress = DasboardDAO.Instance.GetPackingStatusProgress();
            DateTime theClosestPackingETD = DateTime.MaxValue;
            /*PackingProgress minPackItem; 
            PickingProgress minPickItem; */
            int sumPlanPack = 0, sumActualPack = 0;
            int sumPlanPick = 0, sumActualPick = 0;
            foreach (PackingProgress item in sourcePackingProgress)
            {
                theClosestPackingETD = item.ETD < theClosestPackingETD ? item.ETD : theClosestPackingETD;
                sumPlanPack += Int32.Parse(item.Plan);
                sumActualPack += Int32.Parse(item.Actual);
            }
            List<PickingProgress> sourcePickingProgress = DasboardDAO.Instance.GetPickingStatusProgress();
            DateTime theClosestPickingCreatedDate = DateTime.MaxValue;
            foreach (PickingProgress item in sourcePickingProgress)
            {
                theClosestPickingCreatedDate = item.MinCreatedDate < theClosestPickingCreatedDate ? item.MinCreatedDate : theClosestPickingCreatedDate;
                sumPlanPick += Int32.Parse(item.Plan);
                sumActualPick += Int32.Parse(item.Actual);
            }
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // "SE Asia Standard Time" is the IANA time zone ID for HCMC, Vietnam

            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
            CultureInfo japaneseCulture = new CultureInfo("ja-JP");
            //string formattedDateTime = now.ToString("F", japaneseCulture);
            string formattedDateTime = localTime.ToString("dddd, dd/MM/yyyy \n hh:mm tt",japaneseCulture);

            txtTimer.Text = formattedDateTime;
            
            /**
             * packStatus , pickStatus:
             * 0 = Late
             * 1 = Good
             * 2 = Caution
             */
            /** Apply Status :
             * Button 0 = Packing
             * Button 1 = Picking
             * Button 2 = LoadingTime
             * Status 0 = Late 
             * Status 1 = Good
             * Status 2 = Caution
             * ApplyStatusToChart(Button, Status);
             */
            // PACKING STATUS
            packStatus = statusNormal;
            if (theClosestPackingETD.Date < DateTime.Now.Date) // if (theClosestPackingETD <= DateTime.Now)
            {
                packStatus = statusLate;
            }
            else if (theClosestPackingETD.Date == DateTime.Now.Date) // if (theClosestPackingETD <= DateTime.Now)
            {
                packStatus = statusCaution;
            }

            ApplyStatusToChart(packingChart, packStatus);
            // PICKING STATUS
            pickStatus = statusNormal;
            if (theClosestPickingCreatedDate.Date < DateTime.Now.Date) // if (theClosestPickingCreatedDate <= DateTime.Now.AddDays(7))
            {
                pickStatus = statusLate;

            }
            else
            {
                switch (DateTime.Now.Hour)
                {
                    case 12:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 40)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 40 && (sumActualPick / sumPlanPick * 100) <= 50)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    case 13:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 50)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 50 && (sumActualPick / sumPlanPick * 100) <= 60)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    case 14:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 60)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 60 && (sumActualPick / sumPlanPick * 100) <= 70)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    case 15:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 70)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 70 && (sumActualPick / sumPlanPick * 100) <= 80)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    case 16:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 70)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 70 && (sumActualPick / sumPlanPick * 100) <= 80)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    case 17:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 70)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 70 && (sumActualPick / sumPlanPick * 100) <= 80)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    case 18 | 19 | 20 | 21 | 22 | 23 | 24:
                        {
                            if ((sumActualPick / sumPlanPick * 100) < 90)
                            {
                                pickStatus = statusLate;
                            }
                            else if ((sumActualPick / sumPlanPick * 100) >= 90 && (sumActualPick / sumPlanPick * 100) < 100)
                            {
                                pickStatus = statusCaution;
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            ApplyStatusToChart(pickingChart, pickStatus);
            loadingStatus = statusNormal;
            switch (DateTime.Now.Hour)
            {
                case 12 |13|14|15:
                    {
                        if ((sumActualPick / sumPlanPick * 100) < 40)
                        {
                            loadingStatus = statusLate;
                        }
                        else if ((sumActualPick / sumPlanPick * 100) >= 40 && (sumActualPick / sumPlanPick * 100) <= 60)
                        {
                            loadingStatus = statusCaution;
                        }
                        break;
                    }
                case 16 |17|18|19|20|21|22|23|24:
                    {
                        if ((sumActualPick / sumPlanPick * 100) < 80)
                        {
                            loadingStatus = statusLate;
                        }
                        else if ((sumActualPick / sumPlanPick * 100) >= 80 && (sumActualPick / sumPlanPick * 100) < 90)
                        {
                            loadingStatus = statusCaution;
                        }
                        break;
                    }
                default:
                    { break; }
            }
            ApplyStatusToChart(loadingChart, loadingStatus);
        }

        private void ApplyStatusToChart(int button, int status)
        {
            string lateCharacter = "X";
            string goodCharacter = "O";
            string cautionCharacter = "!";
            string lateStatus = "PROCESS LATELY \n [Trễ Tiến Độ]";
            string goodStatus = "NORMAL \n[Tiến Độ Bình Thường]";
            string cautionStatus = "WARNING \n [Chú Ý Tiến Độ]";
            Color goodColor = Color.Green;
            Color lateColor = Color.Red;
            Color cautionColor = Color.Yellow;

            if (button == 0)
            { // PACKING
                if (status == 0) // Late
                {
                    btnPackingCharacter.Text = lateCharacter;
                    btnPackingCharacter.ForeColor = lateColor;
                    btnPackingStatus.Text = lateStatus;
                }
                else if (status == 1) // Good
                {
                    btnPackingCharacter.Text = goodCharacter;
                    btnPackingCharacter.ForeColor = goodColor;
                    btnPackingStatus.Text = goodStatus;
                }
                else if (status == 2)
                { // Caution
                    btnPackingCharacter.Text = cautionCharacter;
                    btnPackingCharacter.ForeColor = cautionColor;
                    btnPackingStatus.Text = cautionStatus;
                }
            }
            else if (button == 1)
            {// PICKING
                if (status == 0) // Late
                {
                    btnPickingCharacter.Text = lateCharacter;
                    btnPickingCharacter.ForeColor = lateColor;
                    btnPickingStatus.Text = lateStatus;
                }
                else if (status == 1) // Good
                {
                    btnPickingCharacter.Text = goodCharacter;
                    btnPickingCharacter.ForeColor = goodColor;
                    btnPickingStatus.Text = goodStatus;
                }
                else if (status == 2)
                { // Caution
                    btnPickingCharacter.Text = cautionCharacter;
                    btnPickingCharacter.ForeColor = cautionColor;
                    btnPickingStatus.Text = cautionStatus;
                }
            }
            else if (button == 2)
            { //LOADING
                if (status == 0) // Late
                {
                    btnLoadingCharacter.Text = lateCharacter;
                    btnLoadingCharacter.ForeColor = lateColor;
                    btnLoadingStatus.Text = lateStatus;
                }
                else if (status == 1) // Good
                {
                    btnLoadingCharacter.Text = goodCharacter;
                    btnLoadingCharacter.ForeColor = goodColor;
                    btnLoadingStatus.Text = goodStatus;
                }
                else if (status == 2)
                { // Caution
                    btnLoadingCharacter.Text = cautionCharacter;
                    btnLoadingCharacter.ForeColor = cautionColor;
                    btnLoadingStatus.Text = cautionStatus;
                }
            }

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

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            chkboxAutoRefesh.Checked = false;
        }
        private void btnPackingCharacter_Click(object sender, EventArgs e)
        {
            frmPackingStatus packingStatus = new frmPackingStatus();
            packingStatus.Show();
        }

        private void btnPickingCharacter_Click(object sender, EventArgs e)
        {
            frmPickingStatus pickingStatus = new frmPickingStatus();
            pickingStatus.Show();
        }

        private void btnLoadingCharacter_DoubleClick(object sender, EventArgs e)
        {
            frmLoadingStatus frmLoading = new frmLoadingStatus();
            frmLoading.Show();
        }

        private void btnLoadingCharacter_Click(object sender, EventArgs e)
        {

        }
    }

    /*



     */


}