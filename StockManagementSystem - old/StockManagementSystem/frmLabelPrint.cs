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
using System.Drawing.Printing;
using StockManagementSystem.DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace StockManagementSystem
{
    public partial class frmLabelPrint : DevExpress.XtraEditors.XtraForm
    {
        BindingSource labelList = new BindingSource();
        BindingSource itemList = new BindingSource();
        BindingSource locationList = new BindingSource();
        private int LastPalletNo;
        string itemCode;
        string itemName;
        string size;
        string locationCode;
        DataTable labelPrint = new DataTable();

        public frmLabelPrint()
        {
            InitializeComponent();
        }

        private void frmLabelPrint_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadPrinter();
            BindingData();
            gvLabelPrint.CustomDrawRowIndicator += gvLabelPrint_CustomDrawRowIndicator;
        }

        private void LoadData()
        {
            labelList.DataSource = LabelPrintDAO.Instance.GetListLabelPrint();
            dgDetail.DataSource = labelList;

            itemList.DataSource = ProductMasterDAO.Instance.GetListProduct();
            cboItemCode.Properties.DataSource = itemList;
            cboItemCode.Properties.ValueMember = "ItemCode";
            cboItemCode.Properties.DisplayMember = "ItemCode";

            locationList.DataSource = LocationDAO.Instance.GetListLocation();
            cboLocation.Properties.DataSource = locationList;
            cboLocation.Properties.ValueMember = "LocationCode";
            cboLocation.Properties.DisplayMember = "LocationName";

            setUpPermissions();
        }
        private void setUpPermissions() {
            btnPrint.Enabled = HasPermission("PC_PrintLabel_PrintLabel");
            btnReprint.Enabled = HasPermission("PC_PrintLabel_RePrintLabel");
            btnPalletsManagerment.Enabled = HasPermission("PC_PrintLabel_PalletManagerment");
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void LoadPrinter()
        {
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                cboPrinterName.Items.Add(printname);
            }
        }

        private void BindingData()
        {
            cboItemCode.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "ItemCode", true, DataSourceUpdateMode.Never));
            txtPalletNo.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "PalletNo", true, DataSourceUpdateMode.Never));
            cboLocation.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "LocationCode", true, DataSourceUpdateMode.Never));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(cboPrinterName.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn máy in\nPlease select printer", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPrinterName.Focus();
                return;
            }   
            
            if(String.IsNullOrEmpty(txtPrintQty.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập số lượng in\nPlease input print quantity", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPrinterName.Focus();
                return;
            }    

            string fileName;

            labelPrint = LabelPrintDAO.Instance.GetListLabelPrintByItem(cboItemCode.EditValue.ToString(), cboLocation.GetColumnValue("LocationCode").ToString());
            itemCode = cboItemCode.EditValue.ToString();
            itemName = cboItemCode.GetColumnValue("ItemName").ToString();
            size = cboItemCode.GetColumnValue("Size").ToString();
            //locationCode = cboLocation.SelectedText.ToString();
            locationCode = cboLocation.GetColumnValue("LocationCode").ToString();
            int PrintQty = Convert.ToInt32(txtPrintQty.Text);
            string printerName = cboPrinterName.Text;

            if (labelPrint.Rows.Count == 0)
            {
                LastPalletNo = 0;
            }
            else
            {
                LastPalletNo = Convert.ToInt32(labelPrint.Rows[0]["PalletNo"].ToString());
            }

            string palletNo=String.Empty;

            for(int i=LastPalletNo+1;i<=LastPalletNo+PrintQty;i++)
            {
                fileName = @"C:\AICA\LABEL_PRINT\" + string.Format("{0:yyMMddHHmmss}" + i.ToString(), DateTime.Now) + ".csv";
                palletNo = "00" + i.ToString();
                palletNo = palletNo.Substring(palletNo.Length - 3, 3);
                

                if (LabelPrintDAO.Instance.InsertAndUpdatePalletNo(itemCode, palletNo, locationCode, LoginedUser._DisplayName))
                {    
                    try
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true, Encoding.Unicode))
                        {
                            file.WriteLine(itemCode + ";" + itemName + ";" + size + ";" + palletNo + ";" + locationCode + ";" + printerName);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
            LoadData();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
          /*  frmConfirmPassword frmConfirm = new frmConfirmPassword();
    
            frmConfirm.ShowDialog();
            if (frmConfirm.inputPass.Equals(LossDAO.Instance.getRePrintPass()))
            {*/
                if (String.IsNullOrEmpty(cboPrinterName.Text))
                {
                    XtraMessageBox.Show("Vui lòng chọn máy in\nPlease select printer", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrinterName.Focus();
                    return;
                }
                itemCode = cboItemCode.EditValue.ToString();
                itemName = cboItemCode.GetColumnValue("ItemName").ToString();
                size = cboItemCode.GetColumnValue("Size").ToString();
                locationCode = cboLocation.EditValue.ToString();
                string printerName = cboPrinterName.Text;
                string palletNo = txtPalletNo.Text;
                //int ID = Convert.ToInt32(gvLabelPrint.GetRowCellValue(gvLabelPrint.FocusedRowHandle, "IdPalletMaster").ToString());
                string fileName = @"C:\AICA\LABEL_PRINT\" + string.Format("{0:yyMMddHHmmss}", DateTime.Now) + ".csv";

                try
                {
                    /*  if (LabelPrintDAO.Instance.InsertAndUpdatePalletNo(itemCode, palletNo, locationCode, LoginedUser._DisplayName))
                      {
                          using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true, Encoding.Unicode))
                          {
                              file.WriteLine(itemCode + ";" + itemName + ";" + size + ";" + palletNo + ";" + locationCode + ";" + printerName);
                              XtraMessageBox.Show("In Thành Công ", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                      }*/
                    if (LabelPrintDAO.Instance.rePrintPalletNo(itemCode, palletNo, locationCode, LoginedUser._DisplayName))
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true, Encoding.Unicode))
                        {
                            file.WriteLine(itemCode + ";" + itemName + ";" + size + ";" + palletNo + ";" + locationCode + ";" + printerName);
                            XtraMessageBox.Show("In Thành Công ", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //XtraMessageBox.Show("In Lại Thành Công ", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                   /* try
                    {
                        if (LabelPrintDAO.Instance.rePrintPalletNo(itemCode, palletNo, locationCode, LoginedUser._DisplayName))
                        {
                            XtraMessageBox.Show("In Lại Thành Công ", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ee)
                    {*/
                        XtraMessageBox.Show(ex.Message, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                LoadData();
            /* }
             else {
                 XtraMessageBox.Show("Sai Mật Khẩu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }

        private void frmLabelPrint_Activated(object sender, EventArgs e)
        {
            LoadData();
            cboPrinterName.Items.Clear();
            LoadPrinter();
        }

        private void cboItemCode_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboItemCode.GetColumnValue("ItemCode").ToString().Trim()) && !String.IsNullOrEmpty(cboItemCode.GetColumnValue("LocationCode").ToString().Trim()))
            {
                cboLocation.EditValue = cboItemCode.GetColumnValue("LocationCode").ToString();
            }
        }

        private void gvLabelPrint_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvLabelPrint.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvLabelPrint); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvLabelPrint); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void cboLocation_EditValueChanged(object sender, EventArgs e)
        {
           /* locationCode= */
        }

        private void btnPalletsManagerment_Click(object sender, EventArgs e)
        {
            frmPalletsManagerment frm = new frmPalletsManagerment();
            frm.ShowDialog();
            LoadData();
        }
    }
    
}