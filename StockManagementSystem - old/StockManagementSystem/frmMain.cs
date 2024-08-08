using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //List<string> dataq = new List<string>();
        public frmMain()
        {
            
            InitializeComponent();
            HideAllMenu();
            if (LoginedUser._Role.Equals("True"))
            {
                mnMaster.Visible = true;
                mnUserManagement.Visibility = BarItemVisibility.Always;
            }
             setUpPermission();
        }

        private void HideAllMenu()
        {
            userDisplayed.Caption = LoginedUser._DisplayName;

            bool disPlayParentMN = false;
            BarItemVisibility displaySubMN = BarItemVisibility.Never;
            //Parent Menu
            mnDashboard.Visible = disPlayParentMN;
            mnMaster.Visible = disPlayParentMN;
            mnPOManagerment.Visible = disPlayParentMN;
            mnSystem.Visible = disPlayParentMN;
            mnStockManagement.Visible = disPlayParentMN;

            //Child Menu
            //Dashboard
            mnProduction.Visibility = displaySubMN; 
            mnPickingStatus.Visibility = displaySubMN; 
            mnPackingStatus.Visibility = displaySubMN; 
            mnLoadingStatus.Visibility = displaySubMN; 
            //Stock Managerment
            mnLabelPrint.Visibility = displaySubMN; 
            mnStockIn.Visibility = displaySubMN; 
            mnStockData.Visibility = displaySubMN;
            mnStockStake.Visibility = displaySubMN;
            //PO Managerment
            mnPO.Visibility = displaySubMN; 
            mnPOStatus.Visibility = displaySubMN; 
            mnShipout.Visibility = displaySubMN;
           //Product Master 
            mnProduct.Visibility = displaySubMN; 
            mnLocation.Visibility = displaySubMN; 
            mnLossMaster.Visibility = displaySubMN;
            mnUserManagement.Visibility = displaySubMN;
            //System 
            mnChangePassword.Visibility = displaySubMN;
            mnHistory.Visibility = displaySubMN;
        }
        private void setUpPermission()
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            // Set Up
            //Stock Managerment TAB
            if (displayButtons.Contains("PC_PrintLabel_Access"))
            {
                mnStockManagement.Visible = true;
                mnLabelPrint.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_StockIn_Access"))
            {
                mnStockManagement.Visible = true;
                mnStockIn.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_StockData_Access"))
            {
                mnStockManagement.Visible = true;
                mnStockData.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_StockTake_Access"))
            {
                mnStockManagement.Visible = true;
                mnStockStake.Visibility = BarItemVisibility.Always;
            }
            // PO MANAGERMENT
            if (displayButtons.Contains("PC_PO_Access"))
            {
                mnPOManagerment.Visible = true;
                mnPO.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_POStatus_Access"))
            {
                mnPOManagerment.Visible = true;
                mnPOStatus.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_ShipOut_Access"))
            {
                mnPOManagerment.Visible = true;
                mnShipout.Visibility = BarItemVisibility.Always;
            }
            // MASTER DATA
            if (displayButtons.Contains("PC_ProductMaster_Access"))
            {
                mnMaster.Visible = true;
                mnProduct.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_Loss_Access"))
            {
                mnPOManagerment.Visible = true;
                mnLossMaster.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_Location_Access"))
            {
                mnPOManagerment.Visible = true;
                mnLocation.Visibility = BarItemVisibility.Always;
            }
            // SYSTEM
            if (displayButtons.Contains("PC_ChangeLossPassword_Access"))
            {
                mnSystem.Visible = true;
                mnChangePassword.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_HistoryRecoreds_Access"))
            {
                mnSystem.Visible = true;
                mnHistory.Visibility = BarItemVisibility.Always;
            }
            // DASBOARD TAB
            if (displayButtons.Contains("PC_PackingStatus_Access"))
            {
                mnDashboard.Visible = true;
                mnPackingStatus.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_ProductionStatus_Access"))
            {
                mnDashboard.Visible = true;
                mnProduction.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_PickingStatus_Access"))
            {
                mnDashboard.Visible = true;
                mnPickingStatus.Visibility = BarItemVisibility.Always;
            }
            if (displayButtons.Contains("PC_LoadingStatus_Access"))
            {
                mnDashboard.Visible = true;
                mnLoadingStatus.Visibility = BarItemVisibility.Always;
            }

        }

        private void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void mnUserManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmUserManagement));
        }

        private void mnLocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLocation));
        }

        private void mnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmProductMaster));
        }

        private void mnLabelPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLabelPrint));
        }

        private void mnStockIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmStockIn));
        }

        private void mnLossMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLoss));
        }

        private void mnPO_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPoDetail));
        }

        private void mnStockData_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmStockData));
        }

        private void mnPOStatus_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenForm(typeof(frmPOStatus));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PalletStockBackNotificationDAO palletDAO = new PalletStockBackNotificationDAO();
            List<StockBackPalletNotification> listData = palletDAO.GetListPalletNotBeenReturn();
            string listPallet = "-----------------------------------------------------------------------------------------\n";
            if (listData.Count > 0)
            {
                foreach (StockBackPalletNotification pallet in palletDAO.GetListPalletNotBeenReturn())
                {
                    listPallet += $"[\t{pallet.ItemCode,-30}\t{pallet.PalletNo,-6}\t{pallet.LocationCode,-6}\t]\n";
                    listPallet += "-----------------------------------------------------------------------------------------\n";
                }
                XtraMessageBox.Show(
                    $"Pallet List:\n\n{listPallet}",
                    $"Thông báo [Message]\n" + $"{listData.Count,40} Pallet Chưa Được STOCKBACK \t",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void mnShipout_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmShipOut));
        }
        private void mnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmChangePassword));
        }
        private void mnHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_History));
        }
        private void mnStockStake_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmStocktake));
        }
        private void btnChangeRePrintPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmChangeRePrintPass));
        }
        private void btnChangeDeletePOPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmChangeDeletePOPass));
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmProductionStatus));
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPackingStatus));
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPickingStatus));
        }
        private void FunctionsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmFunctions));
        }
        private void mnLoadingStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLoadingStatus));
        }

       /* private void btnFileWatcher_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmFileWatcher));
        }

        private void btnServers_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmServersConfiguration));
        }*/
    }
}