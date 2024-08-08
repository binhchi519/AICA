using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using DevExpress.XtraGrid.Columns;
using System.Drawing.Printing;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using DevExpress.XtraGrid;

namespace StockManagementSystem
{
    public partial class frmPOStatus : DevExpress.XtraEditors.XtraForm

    {

        BindingSource ShippingList = new BindingSource();
        BindingSource PackingList = new BindingSource();
        BindingSource PickingList = new BindingSource();
        BindingSource POstatus = new BindingSource();


        public frmPOStatus()
        {
            InitializeComponent();
            layoutControl1.Enabled = true;

            btnCounter.Enabled = false;
            btnHeightCounter.Enabled = false;
            btnExport.Enabled = HasPermission("PC_POStatus_Export");
            cboETD.Enabled = false;
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void tabDetail_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            //string shippingPalletNo = null;
            btnExport.Enabled = true;
            ////PO Status
            //List<DTO.PackingDetail> nullETD = PackingDetailDAO.Instance.GetnullETD();
            //for(int i =0;i<nullETD.Count;i++)
            //{
            //    if(i == 0)
            //    {
            //        shippingPalletNo += nullETD[i].Shippaletno.ToString();
            //    } else
            //    {
            //        shippingPalletNo = shippingPalletNo + " - " + nullETD[i].Shippaletno.ToString();
            //    }    
            //}    
            //XtraMessageBox.Show($"ShippingPalletNo {shippingPalletNo} chưa được tạo ETD", "THÔNG BÁO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tabDetail.SelectedTabPageIndex == 0)
            {
                LoadPOstatus();
                btnExport.Enabled = HasPermission("PC_POStatus_Export");
                btnCounter.Enabled = false;
                btnHeightCounter.Enabled = false;
                cboETD.Enabled = false;
                btnCounter.Text = "";
                btnHeightCounter.Text = "";
                btnCounter.Appearance.BackColor = Color.Transparent;
                btnHeightCounter.Appearance.BackColor = Color.Transparent;
            }
            // Item List
            if (tabDetail.SelectedTabPageIndex == 1)
            {

                LoadItemList();
                btnExport.Enabled = HasPermission("PC_POStatus_Export");
                btnPackingListIssue.Enabled = HasPermission("PC_POStatus_IssuePackingList");
                btnCounter.Enabled = true;
                btnHeightCounter.Enabled = true;
                cboETD.Enabled = false;
                btnCounter.Text = "0 Sheets";
                btnHeightCounter.Text = "0 mm";
            }
            // PackingList
            if (tabDetail.SelectedTabPageIndex == 2)
            {
                string shippingPalletNo = null;
                //PO Status
                List<DTO.PackingDetail> nullETD = PackingDetailDAO.Instance.GetnullETD();
                for (int i = 0; i < nullETD.Count; i++)
                {
                    if (i == 0)
                    {
                        shippingPalletNo += nullETD[i].Shippaletno.ToString();
                    }
                    else
                    {
                        //shippingPalletNo = shippingPalletNo + " - " + nullETD[i].Shippaletno.ToString();
                        
                        
                    }
                   

                }
                if(nullETD.Count==0)
                {

                }   
                else
                {
                    XtraMessageBox.Show($"Vui lòng cập nhật Loading Date", "THÔNG BÁO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                

                LoadPackingList();
                btnUpdateLoadingDate.Enabled = HasPermission("PC_POStatus_UpdateLoadingDate");
                btnPickingList_Issue.Enabled = HasPermission("PC_POStatus_IssuePickingList");
                btnReturnsPacking.Enabled = HasPermission("PC_POStatus_ReturnsPackingList");
                btnPrint.Enabled = HasPermission("PC_POStatus_PrintShippingLabel");
                cboPrinterName.Enabled = HasPermission("PC_POStatus_PrintShippingLabel");
                btnUpdateShippingPallet.Enabled = HasPermission("PC_POStatus_UpdateShippingPalletNoLoadingTime");
                btnExport.Enabled = HasPermission("PC_POStatus_Export");
                cboETD.Enabled = HasPermission("PC_POStatus_UpdateLoadingDate");
                btnCounter.Enabled = false;
                btnHeightCounter.Enabled = false;
                btnCounter.Text = "";
                btnHeightCounter.Text = "";
                btnCounter.Appearance.BackColor = Color.Transparent;
                btnHeightCounter.Appearance.BackColor = Color.Transparent;
            }
            //Picking List
            if (tabDetail.SelectedTabPageIndex == 3)
            {
                LoadPickingList();
                btnPickListUpdate.Enabled = HasPermission("PC_POStatus_UpdatePickingList");
                btnExport.Enabled = HasPermission("PC_POStatus_Export");
                btnCounter.Enabled = false;
                btnHeightCounter.Enabled = false;
                cboETD.Enabled = false;
                btnCounter.Text = "";
                btnHeightCounter.Text = "";
                btnCounter.Appearance.BackColor = Color.Transparent;
                btnHeightCounter.Appearance.BackColor = Color.Transparent;
            }
        }

        private void LoadPrinter()
        {
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                cboPrinterName.Items.Add(printname);
            }
        }

        private void LoadItemList()
        {
            List<PODetail> listData = PODetailDAO.Instance.GetListItem();
            List<PODetail> result = new List<PODetail>();

            foreach (PODetail item in listData)
            {
                if (item.ShippingQty <= item.AvailableQuantity)
                {
                    result.Add(item);
                }
                else
                {
                    if (item.Priority.Equals("B-1"))
                    {
                        result.Add(item);
                    }
                }

            }
            ShippingList.DataSource = result;
            dgShippingList.DataSource = ShippingList;
            DisableAllBtn();


            btnExport.Enabled = HasPermission("PC_POStatus_Export");
            btnPackingListIssue.Enabled = HasPermission("PC_POStatus_IssuePackingList");
            btnCounter.Enabled = true;
            btnHeightCounter.Enabled = true;
            cboETD.Enabled = false;
            btnCounter.Text = "0 Sheets";
            btnHeightCounter.Text = "0 mm";
        }
        private void LoadPickingList()
        {
            PickingList.DataSource = PickingDAO.Instance.GetListPicking();
            dgPickingList.DataSource = PickingList;
            DisableAllBtn();
            btnPickListUpdate.Enabled = HasPermission("PC_POStatus_UpdatePickingList");
            btnExport.Enabled = HasPermission("PC_POStatus_Export");
            btnCounter.Enabled = false;
            btnHeightCounter.Enabled = false;
            cboETD.Enabled = false;
            btnCounter.Text = "";
            btnHeightCounter.Text = "";
            btnCounter.Appearance.BackColor = Color.Transparent;
            btnHeightCounter.Appearance.BackColor = Color.Transparent;
        }

        private void LoadPackingList()
        {
            PackingList.DataSource = PackingDAO.Instance.GetListPacking();
            dgPackingList.DataSource = PackingList;
            DisableAllBtn();
            btnUpdateLoadingDate.Enabled = HasPermission("PC_POStatus_UpdateLoadingDate");
            btnPickingList_Issue.Enabled = HasPermission("PC_POStatus_IssuePickingList");
            btnReturnsPacking.Enabled = HasPermission("PC_POStatus_ReturnsPackingList");
            btnPrint.Enabled = HasPermission("PC_POStatus_PrintShippingLabel");
            cboPrinterName.Enabled = HasPermission("PC_POStatus_PrintShippingLabel");
            btnUpdateShippingPallet.Enabled = HasPermission("PC_POStatus_UpdateShippingPalletNoLoadingTime");
            btnExport.Enabled = HasPermission("PC_POStatus_Export");
            cboETD.Enabled = HasPermission("PC_POStatus_UpdateLoadingDate");
            btnCounter.Enabled = false;
            btnHeightCounter.Enabled = false;
            btnCounter.Text = "";
            btnHeightCounter.Text = "";
            btnCounter.Appearance.BackColor = Color.Transparent;
            btnHeightCounter.Appearance.BackColor = Color.Transparent;
        }
        private void LoadPOstatus()
        {
            List<POstatus> rawData = POstatusDAO.Instance.GetlistPOStatus();


            List<POstatus> data = rawData.GroupBy(e => new { e.PONo, e.Item, e.PODate, e.Film, e.PStock, e.AllStock, e.Customer }).Select(group =>
            {
                return new POstatus
                {
                    PONo = group.Key.PONo,
                    PODate = group.Key.PODate,
                    Customer = group.Key.Customer,
                    Item = group.Key.Item,
                    Film = group.Key.Film,
                    POQty = group.Sum(e => e.POQty),
                    PStock = group.Key.PStock,
                    Picking = group.Sum(e => e.Picking),
                    Masking = group.Sum(e => e.Masking),
                    Packing = group.Sum(e => e.Packing),
                    AllStock = group.Key.AllStock,
                    Backlog = group.Sum(e => e.POQty - e.ShipOutted),
                    ShipOutted = group.Sum(e => e.ShipOutted),
                    PackingStatus = group.Min(e => e.PackingStatus)
                };
            })
            .ToList();
            POstatus.DataSource = data;
            dgPOStatus.DataSource = POstatus;
            DisableAllBtn();
        }

        /* private void LoadPOstatus()
         {
             POstatus.DataSource = POstatusDAO.Instance.GetlistPOStatus();
             dgPOStatus.DataSource = POstatus;
             DisableAllBtn();

         }*/

        private void btnPackingListIssue_Click(object sender, EventArgs e)
        {
            bool sameCustomer = true;
            //String Custem = "";
            List<PODetail> selectedRows = new List<PODetail>();
            foreach (int rowHandle in gvShippingList.GetSelectedRows())
            {
                selectedRows.Add(gvShippingList.GetRow(rowHandle) as PODetail);
            }
            for (int i = 0; i < selectedRows.Count - 2; i++)
            {
                if (!selectedRows[i].Customer.ToString().Equals(selectedRows[i].Customer.ToString()))
                {
                    XtraMessageBox.Show("Vui lòng chọn cùng khách hàng", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    sameCustomer = false;
                    return;
                }

            }
            if (sameCustomer == true)
            {
                frm_Create_Packing Createpacking = new frm_Create_Packing();
                Createpacking.Customer = selectedRows[0].Customer.ToString();
                Createpacking.ShowDialog();
                Createpacking.ShowDialog();
                string frm_loadingTime = Createpacking.loadingTime;
                if (Createpacking.create == true)
                {

                    String loadingTime_firstPart = DateTime.Now.Month < 10 ? DateTime.Now.Year - 2000 + "0" + DateTime.Now.Month : DateTime.Now.Year - 2000 + "" + DateTime.Now.Month;
                    String nextYearLoadingTime_firstPart = DateTime.Now.Month < 10 ? DateTime.Now.Year - 2000 + 1 + "0" + DateTime.Now.Month : DateTime.Now.Year - 2000 + "" + DateTime.Now.Month;
                    bool flag = true;
                    if (gvShippingList.GetSelectedRows().Length == 1)  // Chon 1 dong Trong ItemList
                    {

                        PODetail temp = (PODetail)selectedRows[0];
                        string loadingTime = "";
                        string sShippingPallet = "";
                        if (temp.Qty < temp.QtyPerPallet)  //QTY nho hon QtyPerPallet tam
                        {
                            if (frm_loadingTime.Equals("+1")) // LoadingTime Next Month
                            {
                                String[] svLoadingTime = PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer) != "" ? PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer).Split('-') : (loadingTime_firstPart + "-00").Split('-');
                                int iNextLoadingTime = int.Parse(svLoadingTime[1]) + 1;
                                String sNextLoadingTime = iNextLoadingTime > 10 ? iNextLoadingTime + "" : "0" + iNextLoadingTime;
                                string loadingMonth = PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer).Substring(2, 2);
                                if (DateTime.Now.Month == 12)
                                {
                                    loadingTime = DateTime.Now.Year - 1999 + "01-01";
                                }
                                else
                                {
                                    if (Int32.Parse(loadingMonth) == (DateTime.Now.Month + 1))
                                    {
                                        loadingTime = svLoadingTime[0] + "-" + sNextLoadingTime;
                                    }
                                    else
                                    {
                                        loadingTime = DateTime.Now.Month + 1 < 10 ? DateTime.Now.Year - 2000 + "0" + (DateTime.Now.AddMonths(1).Month) + "-01"
                                        : DateTime.Now.Year - 2000 + "" + DateTime.Now.AddMonths(1).Month + "-01";
                                    }

                                }

                                sShippingPallet = Createpacking.Customer + "-01";
                            }
                            else if (frm_loadingTime.Equals("")) // Tao LoadingTime Moi trong thang
                            {
                                string[] svLoadingTime = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer) != "" ? PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Split('-') : (loadingTime_firstPart + "-00").Split('-');
                                int iNextLoadingTime = int.Parse(svLoadingTime[1]) + 1;
                                string sNextLoadingTime = iNextLoadingTime > 10 ? iNextLoadingTime + "" : "0" + iNextLoadingTime;

                                string rs = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer);
                                if (!String.IsNullOrEmpty(rs))
                                {
                                    string loadingYear = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Substring(0, 2);
                                    string loadingMonth = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Substring(2, 2);

                                    if (Int32.Parse(loadingYear) < (DateTime.Now.Year - 2000))
                                    {
                                        loadingTime = loadingTime_firstPart + "-01";
                                        sShippingPallet = Createpacking.Customer + "-01";
                                    }
                                    else if (Int32.Parse(loadingMonth) == DateTime.Now.Month)
                                    {
                                        loadingTime = svLoadingTime[0] + "-" + sNextLoadingTime;
                                        sShippingPallet = Createpacking.Customer + "-01";
                                    }
                                    else
                                    {
                                        loadingTime = loadingTime_firstPart + "-01";
                                        sShippingPallet = Createpacking.Customer + "-01";
                                    }
                                }
                                else {
                                    loadingTime = loadingTime_firstPart + "-01";
                                    sShippingPallet = Createpacking.Customer + "-01";
                                }
                              
                                
                            }
                            else // Xai LoadingTime Cu
                            {
                                loadingTime = frm_loadingTime;
                                String[] svLoadingTime = PackingDAO.Instance.GetLastPalletNo(Createpacking.Customer, loadingTime).Split('-');
                                int iShippingPallet = int.Parse(svLoadingTime[1]) + 1;
                                sShippingPallet = iShippingPallet > 10 ? Createpacking.Customer + "-" + iShippingPallet : Createpacking.Customer + "-0" + iShippingPallet;
                            }
                            if (!PackingDAO.Instance.InsertPKLDetail(temp.ID, temp.Item, temp.Qty, sShippingPallet, loadingTime))
                            {
                                flag = false;
                            }
                        }
                        else  // Dong Duoc Chon Trong itemList co so luong > temp.QtyPerPallet
                        {
                            int countShippingPalletNo = 1;
                            if (frm_loadingTime.Equals("+1")) // LoadingTime Next Month
                            {
                                string[] svLoadingTime = PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer) != "" ? PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer).Split('-') : (loadingTime_firstPart + "-00").Split('-');
                                int iNextLoadingTime = int.Parse(svLoadingTime[1]) + 1;
                                String sNextLoadingTime = iNextLoadingTime > 10 ? iNextLoadingTime + "" : "0" + iNextLoadingTime;
                                string loadingMonth = PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer).Substring(2, 2);


                                if (DateTime.Now.Month == 12)
                                {
                                    loadingTime = DateTime.Now.Year - 1999 + "01-01";
                                }
                                else
                                {
                                    if (Int32.Parse(loadingMonth) == (DateTime.Now.Month + 1))
                                    {
                                        loadingTime = svLoadingTime[0] + "-" + sNextLoadingTime;
                                    }
                                    else
                                    {
                                        loadingTime = DateTime.Now.Month + 1 < 10 ? DateTime.Now.Year - 2000 + "0" + (DateTime.Now.AddMonths(1).Month) + "-01"
                                        : DateTime.Now.Year - 2000 + "" + DateTime.Now.AddMonths(1).Month + "-01";
                                    }

                                }
                            }
                            else if (frm_loadingTime.Equals("")) // Tao LoadingTime Moi trong thang
                            {
                                string[] svLoadingTime = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer) != "" ? PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Split('-') : (loadingTime_firstPart + "-00").Split('-');
                                int iNextLoadingTime = int.Parse(svLoadingTime[1]) + 1;
                                string sNextLoadingTime = iNextLoadingTime > 10 ? iNextLoadingTime + "" : "0" + iNextLoadingTime;

                                string rs = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer);
                                if (!String.IsNullOrEmpty(rs))
                                {
                                    string loadingYear = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Substring(0, 2);
                                    string loadingMonth = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Substring(2, 2);

                                    if (Int32.Parse(loadingYear) < (DateTime.Now.Year - 2000))
                                    {
                                        loadingTime = loadingTime_firstPart + "-01";
                                        sShippingPallet = Createpacking.Customer + "-01";
                                    }
                                    else if (Int32.Parse(loadingMonth) == DateTime.Now.Month)
                                    {
                                        loadingTime = svLoadingTime[0] + "-" + sNextLoadingTime;
                                        sShippingPallet = Createpacking.Customer + "-01";
                                    }
                                    else
                                    {
                                        loadingTime = loadingTime_firstPart + "-01";
                                        sShippingPallet = Createpacking.Customer + "-01";
                                    }
                                }
                                else
                                {
                                    loadingTime = loadingTime_firstPart + "-01";
                                    sShippingPallet = Createpacking.Customer + "-01";
                                }


                            }
                            else // Xai LoadingTime Cu
                            {
                                loadingTime = frm_loadingTime;
                                String[] svLoadingTime = PackingDAO.Instance.GetLastPalletNo(Createpacking.Customer, loadingTime).Split('-');
                                countShippingPalletNo = int.Parse(svLoadingTime[1]) + 1;

                            }


                            for (int i = 0; i < temp.Qty / temp.QtyPerPallet; i++)
                            {
                                if (!PackingDAO.Instance.InsertPKLDetail(temp.ID, temp.Item, temp.QtyPerPallet, CreatePalletNo(countShippingPalletNo, Createpacking.Customer), loadingTime))
                                {
                                    flag = false;
                                    break;
                                }
                                countShippingPalletNo++;
                            }
                            if (temp.Qty % temp.QtyPerPallet > 0)
                            {
                                if (!PackingDAO.Instance.InsertPKLDetail(temp.ID, temp.Item, temp.Qty % temp.QtyPerPallet, CreatePalletNo(countShippingPalletNo, Createpacking.Customer), loadingTime))
                                {
                                    flag = false;
                                }
                            }

                        }
                    }
                    else  // Chon Nhieu Dong
                    {
                        string loadingTime = "";
                        string sShippingPallet = "";
                        /*  selectedRows*/
                        PODetail temp = (PODetail)selectedRows[0];
                        int countShippingPalletNo = 1;
                        if (frm_loadingTime.Equals("+1")) // LoadingTime Next Month
                        {
                            String[] svLoadingTime = PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer) != "" ? PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer).Split('-') : (loadingTime_firstPart + "-00").Split('-');
                            int iNextLoadingTime = int.Parse(svLoadingTime[1]) + 1;
                            String sNextLoadingTime = iNextLoadingTime > 10 ? iNextLoadingTime + "" : "0" + iNextLoadingTime;
                            string loadingMonth = PackingDAO.Instance.GetLastLoadingTime(Createpacking.Customer).Substring(2, 2);


                            if (DateTime.Now.Month == 12)
                            {
                                loadingTime = DateTime.Now.Year - 1999 + "01-01";
                            }
                            else
                            {
                                if (Int32.Parse(loadingMonth) == (DateTime.Now.Month + 1))
                                {
                                    loadingTime = svLoadingTime[0] + "-" + sNextLoadingTime;
                                }
                                else
                                {
                                    loadingTime = DateTime.Now.Month + 1 < 10 ? DateTime.Now.Year - 2000 + "0" + (DateTime.Now.AddMonths(1).Month) + "-01"
                                    : DateTime.Now.Year - 2000 + "" + DateTime.Now.AddMonths(1).Month + "-01";
                                }

                            }

                            //sShippingPallet = Createpacking.Customer + "-01";
                        }
                        else if (frm_loadingTime.Equals("")) // Tao LoadingTime Moi trong thang
                        {
                            string[] svLoadingTime = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer) != "" ? PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Split('-') : (loadingTime_firstPart + "-00").Split('-');
                            int iNextLoadingTime = int.Parse(svLoadingTime[1]) + 1;
                            string sNextLoadingTime = iNextLoadingTime > 10 ? iNextLoadingTime + "" : "0" + iNextLoadingTime;

                            string rs = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer);
                            if (!String.IsNullOrEmpty(rs))
                            {
                                string loadingYear = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Substring(0, 2);
                                string loadingMonth = PackingDAO.Instance.GetMaxLoadingTimeInMonth(Createpacking.Customer).Substring(2, 2);

                                if (Int32.Parse(loadingYear) < (DateTime.Now.Year - 2000))
                                {
                                    loadingTime = loadingTime_firstPart + "-01";
                                    sShippingPallet = Createpacking.Customer + "-01";
                                }
                                else if (Int32.Parse(loadingMonth) == DateTime.Now.Month)
                                {
                                    loadingTime = svLoadingTime[0] + "-" + sNextLoadingTime;
                                    sShippingPallet = Createpacking.Customer + "-01";
                                }
                                else
                                {
                                    loadingTime = loadingTime_firstPart + "-01";
                                    sShippingPallet = Createpacking.Customer + "-01";
                                }
                            }
                            else
                            {
                                loadingTime = loadingTime_firstPart + "-01";
                                sShippingPallet = Createpacking.Customer + "-01";
                            }


                        }
                        else // Xai LoadingTime Cu
                        {
                            loadingTime = frm_loadingTime;
                            String[] svLoadingTime = PackingDAO.Instance.GetLastPalletNo(Createpacking.Customer, loadingTime).Split('-');
                            countShippingPalletNo = int.Parse(svLoadingTime[1]) + 1;

                        }
                        if (!CreateShippingPallet(selectedRows, loadingTime, CreatePalletNo(countShippingPalletNo, temp.Customer)))
                        {
                            flag = false;
                        }

                    }
                    if (flag)
                    {
                        XtraMessageBox.Show("Update Succeed!\nCập nhật OK!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Update Fail!\nCập nhật That Bai!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    LoadItemList();
                }
            }

        }

        private bool CreateShippingPallet(List<PODetail> list, string loadingTime, string shippingPalletNo)
        {
            foreach (PODetail e in list)
            {
                if (!PackingDAO.Instance.InsertPKLDetail(e.ID, e.Item, e.Qty, shippingPalletNo, loadingTime))
                {
                    return false;
                }
            }
            return true;
        }


        private string CreatePalletNo(string lastPalletNo, string customer)
        {
            int pallet = 0;
            if (!String.IsNullOrEmpty(lastPalletNo))
            {
                pallet = Convert.ToInt32(lastPalletNo.Substring(lastPalletNo.Length - 2, 2));
            }
            pallet++;
            string result = "0" + pallet.ToString();
            result = customer + "-" + result.Substring(result.Length - 2, 2);
            return result;
        }
        private string CreatePalletNo(int palletNo, string customer)
        {
            string result = palletNo < 10 ? customer + "-0" + palletNo : customer + "-" + palletNo;
            return result;
        }

        private string CreateLoadingTime(string lastLoadingTime)
        {
            int serial = 0;
            if (!String.IsNullOrEmpty(lastLoadingTime))
            {
                serial = Convert.ToInt32(lastLoadingTime.Substring(lastLoadingTime.Length - 2, 2));
            }
            serial++;
            string result = "0" + serial.ToString();
            string year = DateTime.Now.Year.ToString();
            string month = "0" + DateTime.Now.Month.ToString();
            month = month.Substring(month.Length - 2, 2);
            string prefix = year.Substring(year.Length - 2, 2) + month;
            result = prefix + "-" + result.Substring(result.Length - 2, 2);
            return result;
        }

        private void frmPOStatus_Load(object sender, EventArgs e)
        {
            LoadPrinter();
            gvShippingList.CustomDrawRowIndicator += gvShippingList_CustomDrawRowIndicator;
            gvPOStatus.CustomDrawRowIndicator += gvShippingList_CustomDrawRowIndicator;
            gvPackingList.CustomDrawRowIndicator += gvPackingList_CustomDrawRowIndicator;
            gvPickingList.CustomDrawRowIndicator += gvPickingList_CustomDrawRowIndicator;
            LoadPOstatus();
            btnExport.Enabled = false;
            //dgShippingList.DataBindings.Clear();
            //dgPackingList.DataBindings.Clear();
            //dgPickingList.DataBindings.Clear();
            //frmPOStatus_Load(sender, e);
        }

        private void btnPickListUpdate_Click(object sender, EventArgs e)
        {
            bool flag = true;
            List<PickingList> selectedRows = new List<PickingList>();
            foreach (int rowHandle in gvPickingList.GetSelectedRows())
            {
                if (!gvPickingList.IsGroupRow(rowHandle))
                {
                    selectedRows.Add(gvPickingList.GetRow(rowHandle) as PickingList);
                }
            }
            for (int i = 0; i < selectedRows.Count; i++)
            {
                int PickID = selectedRows[i].PickingID;


                List<InventoryArea> selected_inventory = new List<InventoryArea>();
                int Outstanding = 0;
                selected_inventory = InventoryAreaDAO.Instance.GetInventorybyItem(selectedRows[i].ItemCode);
                Outstanding = selectedRows[i].OutStanding;
                if (selected_inventory.Count == 0)
                {
                    //if (InventoryAreaDAO.Instance.InsertPickArea(PickID, selected_inventory[j].Location, QtytoPick, selectedRows[i].ItemCode))

                    continue;
                }
                int QtytoPick = 0;
                for (int j = 0; j < selected_inventory.Count; j++)
                {
                    if (Outstanding == 0)
                    {
                        //selected_inventory[j].Qty = selected_inventory[j].Qty - Outstanding;
                        break;
                    }

                    if (Outstanding <= selected_inventory[j].Qty)
                    {
                        QtytoPick = Outstanding;
                    }
                    else
                    {
                        QtytoPick = selected_inventory[j].Qty;
                    }


                    if (!InventoryAreaDAO.Instance.InsertPickArea(PickID, selected_inventory[j].Location, QtytoPick, selectedRows[i].ItemCode))
                    {

                        XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Outstanding = Outstanding - QtytoPick;


                }
                if (!InventoryAreaDAO.Instance.UpdateOutstanding(PickID, Outstanding))
                {
                    XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            XtraMessageBox.Show("Update Successful!\nCập nhật Thành Công !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);



            LoadPickingList();
        }

        private void gvPackingList_CustomColumnGroup(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {

        }

        private void gvPackingList_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null)
            {
                return;
            }

        }

        private void btnPackingListUpdate_Click(object sender, EventArgs e)
        {
            List<PackingList> selectedRows = new List<PackingList>();
            foreach (int rowHandle in gvPackingList.GetSelectedRows())
            {
                selectedRows.Add(gvPackingList.GetRow(rowHandle) as PackingList);
            }
            int count = selectedRows.Count;
            if (String.IsNullOrEmpty(cboETD.Text.ToString()))
            {
                XtraMessageBox.Show("Update Fail!\nVui lòng kiểm tra lại Ngày Xuất Hàng !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < selectedRows.Count; i++)
            {
                if (!PackingDAO.Instance.UpdateETD(DateTime.Parse(cboETD.EditValue.ToString()), selectedRows[i].PODeatailID.ToString()))
                {
                    XtraMessageBox.Show("Update Fail!\nCập nhật thất bại, vui lòng kiểm tra lại Ngày Xuất Hàng !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadPackingList();
            XtraMessageBox.Show("update successful!\nCập nhật thành công", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboPrinterName.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn máy in\nPlease select printer", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPrinterName.Focus();
                return;
            }
            string fileName;
            string printerName = cboPrinterName.Text;


            List<PackingList> selectedRows = new List<PackingList>();
            foreach (int rowHandle in gvPackingList.GetSelectedRows())
            {
                selectedRows.Add(gvPackingList.GetRow(rowHandle) as PackingList);
            }

            var print = selectedRows.Select(u => new { u.ShipPalletNo, u.LoadingTime }).Distinct().ToList();
            for (int i = 0; i < print.Count; i++)
            {
                try
                {
                    fileName = @"C:\AICA\SHIPPINGLABEL\" + i + string.Format("{0:yyMMddHHmmss}", DateTime.Now) + ".csv";
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true, Encoding.Unicode))
                    {
                        file.WriteLine(print[i].ShipPalletNo + ";" + print[i].LoadingTime + ";" + printerName);

                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            XtraMessageBox.Show("In thành công!\nPrint success", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPickingList_Issue_Click(object sender, EventArgs e)
        {
            List<PackingList> selectedRows = new List<PackingList>();
            foreach (int rowHandle in gvPackingList.GetSelectedRows())
            {
                if (!gvPackingList.IsGroupRow(rowHandle))
                {
                    selectedRows.Add(gvPackingList.GetRow(rowHandle) as PackingList);
                }
            }
            for (int i = 0; i < selectedRows.Count; i++)
            {
                if (selectedRows[i].Status == "1")
                {
                    int PickID = 0;
                    PickID = Convert.ToInt32(PickingDAO.Instance.InsertPickingList(selectedRows[i].ID, selectedRows[i].PODeatailID, selectedRows[i].PackQty));
                    if (PickID == 0)
                    {
                        XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<InventoryArea> selected_inventory = new List<InventoryArea>();
                    int Outstanding = 0;
                    selected_inventory = InventoryAreaDAO.Instance.GetInventorybyItem(selectedRows[i].ItemCode);
                    Outstanding = selectedRows[i].PackQty;
                    if (selected_inventory.Count == 0)
                    {
                        //if (InventoryAreaDAO.Instance.InsertPickArea(PickID, selected_inventory[j].Location, QtytoPick, selectedRows[i].ItemCode))

                        continue;
                    }
                    int QtytoPick = 0;
                    for (int j = 0; j < selected_inventory.Count; j++)
                    {
                        if (Outstanding == 0)
                        {

                            break;
                        }
                        if (Outstanding <= selected_inventory[j].Qty)
                        {
                            QtytoPick = Outstanding;
                        }
                        else
                        {
                            QtytoPick = selected_inventory[j].Qty;
                        }


                        if (!InventoryAreaDAO.Instance.InsertPickArea(PickID, selected_inventory[j].Location, QtytoPick, selectedRows[i].ItemCode))
                        {
                            XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Outstanding = Outstanding - QtytoPick;


                    }
                    if (!InventoryAreaDAO.Instance.UpdateOutstanding(PickID, Outstanding))
                    {
                        XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    continue;
                }
                LoadPackingList();
            }
            XtraMessageBox.Show("Update Successful!\nCập nhật Thành Công !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gvShippingList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvShippingList.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvShippingList); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvShippingList); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gvPOStatus_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvPOStatus.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPOStatus); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPOStatus); }));
            }
        }

        private void gvPickingList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvPickingList.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPickingList); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPickingList); }));
            }
        }

        private void gvPackingList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvPackingList.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPackingList); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvPackingList); }));
            }
        }
        private void btnReturnsPacking_Click(object sender, EventArgs e)
        {
            List<PackingList> selectedRows = new List<PackingList>();

            foreach (int rowHandle in gvPackingList.GetSelectedRows())
            {
                selectedRows.Add(gvPackingList.GetRow(rowHandle) as PackingList);
            }

            for (int i = 0; i < selectedRows.Count; i++)
            {
                if (!PackingDAO.Instance.ReturnsPKLDetail(selectedRows[i].PODeatailID, selectedRows[i].ItemCode))
                {
                    XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadPackingList();
            }
            XtraMessageBox.Show("Update Successful!\nCập nhật Thành Công !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<PackingList> selectedRows = new List<PackingList>();
            bool flag = true;
            foreach (int rowHandle in gvPackingList.GetSelectedRows())
            {
                selectedRows.Add(gvPackingList.GetRow(rowHandle) as PackingList);
            }
            for (int i = 0; i < selectedRows.Count; i++)
            {
                try
                {
                    if (!PackingDAO.Instance.UpdateShipingPalletNoAndLoadingTime(selectedRows[i].ID + "", selectedRows[i].ShipPalletNo, selectedRows[i].LoadingTime, selectedRows[i].Customer))
                    {
                        flag = false;
                        break;
                    }
                }
                catch (Exception eee)
                {
                    XtraMessageBox.Show(eee.Message.ToString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            /*for (int i = 0; i < selectedRows.Count; i++)
            {
                if (!PackingDAO.Instance.UpdateShipingPalletNo(selectedRows[i].ID + "", selectedRows[i].ShipPalletNo))
                {
                    flag = false;
                    break;
                }
            }*/
            if (flag == false)
            {
                XtraMessageBox.Show("Update Fail! LoadingTime doesn't Exist Or Already Ship Out\nCập nhật thất bại! LoadingTime Không tồn tại Hoặc đã xuất hàng", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                XtraMessageBox.Show("Update Successful!\nCập nhật Thành Công !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadPackingList();

        }
        private void dgPickingList_Click(object sender, EventArgs e)
        {

        }
        private void EnableBtn(params SimpleButton[] buttons)
        {
            foreach (SimpleButton btn in buttons)
            {
                btn.Enabled = true;
            }
        }
        private void DisableAllBtn()
        {
            foreach (SimpleButton btn in new SimpleButton[] { btnUpdateShippingPallet, btnPackingListIssue, btnUpdateLoadingDate, btnPickingList_Issue, btnPickListUpdate, btnReturnsPacking, btnPrint })
            {
                btn.Enabled = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GridView gridViewToExport;

                // Choose the appropriate GridView based on the focused control
                if (tabDetail.SelectedTabPageIndex == 0)
                {
                    gridViewToExport = (GridView)dgPOStatus.MainView;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }
                else if (tabDetail.SelectedTabPageIndex == 1)
                {
                    gridViewToExport = (GridView)dgShippingList.MainView;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }
                else if (tabDetail.SelectedTabPageIndex == 2)
                {
                    gridViewToExport = (GridView)dgPackingList.MainView;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }
                else if (tabDetail.SelectedTabPageIndex == 3)
                {
                    gridViewToExport = (GridView)dgPickingList.MainView;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }

            }
        }

        private void gvShippingList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int sumShippingQty = 0;
            float sumHeight = 0;
            // Calculate the sum of "ShippingQty" for selected rows
            foreach (int selectedRowHandle in gvShippingList.GetSelectedRows())
            {
                sumShippingQty += Convert.ToInt32(gvShippingList.GetRowCellValue(selectedRowHandle, "ShippingQty"));
                sumHeight += (Convert.ToInt32(gvShippingList.GetRowCellValue(selectedRowHandle, "ShippingQty"))) * (float.Parse(gvShippingList.GetRowCellValue(selectedRowHandle, "ActualThickness").ToString()));
            }

            // Determine the background color based on the sum
            Color qtyCounterColor = sumShippingQty == 0 ? Color.White : sumShippingQty < 320 ? Color.ForestGreen : Color.Red;
            Color heightCounterColor = sumHeight == 0 ? Color.White : sumHeight < 250 ? Color.ForestGreen : Color.Red;
            btnCounter.Text = sumShippingQty + " Sheets";
            btnHeightCounter.Text = sumHeight + " mm";
            btnCounter.Appearance.BackColor = qtyCounterColor;
            btnHeightCounter.Appearance.BackColor = heightCounterColor;
        }

        private void dgShippingList_Click(object sender, EventArgs e)
        {

        }
    }
}