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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using StockManagementSystem.DTO;

namespace StockManagementSystem
{
    public partial class frmPoDetail : DevExpress.XtraEditors.XtraForm
    {
        BindingSource PODetail = new BindingSource();
        int actionID;

        public frmPoDetail()
        {
            InitializeComponent();
        }


        private void frmPO_Load(object sender, EventArgs e)
        {
            LoadData();
            BindingData();
            gridPODetail.CustomDrawRowIndicator += gridPODetail_CustomDrawRowIndicator;
        }

        private void LoadData()
        {
            PODetail.DataSource = PODetailDAO.Instance.GetListPODetail();
            dgDetail.DataSource = PODetail;
            btnDelete.Enabled = HasPermission("PC_PO_Delete");
            btnEdit.Enabled = HasPermission("PC_PO_Update");
            btnImport.Enabled = HasPermission("PC_PO_Import");
            btnExport.Enabled = HasPermission("PC_PO_Export");
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void BindingData()
        {
            txtPONo.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "PONo", true, DataSourceUpdateMode.Never));
            dpkDate.DataBindings.Add(new Binding("DateTime", dgDetail.DataSource, "PODate", true, DataSourceUpdateMode.Never));
            txtCustomer.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Customer", true, DataSourceUpdateMode.Never));
            txtItem.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Item", true, DataSourceUpdateMode.Never));
            chkFilm.DataBindings.Add(new Binding("Checked", dgDetail.DataSource, "Film", true, DataSourceUpdateMode.Never));
            txtThickness.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Thickness", true, DataSourceUpdateMode.Never));
            txtTotalQty.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "TotalQty", true, DataSourceUpdateMode.Never));
            cboPriority.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "Priority", true, DataSourceUpdateMode.Never));
            txtQty.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Qty", true, DataSourceUpdateMode.Never));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ID = gridPODetail.GetRowCellValue(gridPODetail.FocusedRowHandle, "ID").ToString();
            int priQty = 0;
            int POQty = 0;
            int reserveQty = 0;
            int currentQty = 0;
            priQty = Convert.ToInt32(txtQty.Text);
            POQty = Convert.ToInt32(txtTotalQty.Text);

            string PONo;
            string item;


            PODetail selectedRow = (PODetail)gridPODetail.GetFocusedRow();
            if (PODetailDAO.Instance.GetPOResQty(selectedRow.PONo.ToString()
                  , selectedRow.Item.ToString()
                  , selectedRow.ID.ToString()) != 0)
            {
                reserveQty = PODetailDAO.Instance.GetPOResQty(selectedRow.PONo.ToString()
                  , selectedRow.Item.ToString()
                  , selectedRow.ID.ToString());
            }
            else
            {
                reserveQty = 0;
            }



            if (cboPriority.EditValue.ToString() == "A")
            {
                int availabelQty = Convert.ToInt32(gridPODetail.GetRowCellValue(gridPODetail.FocusedRowHandle, "AvailableQuantity").ToString());
                if (availabelQty == 0)
                {
                    XtraMessageBox.Show($"Item code does not have inventory quantity\n{txtItem.Text} không có tồn kho", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (priQty > availabelQty)
                {
                    if (!PODetailDAO.Instance.UpdatePODetail(ID, cboPriority.EditValue.ToString(), availabelQty))
                    {
                        XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        PODetailDAO.Instance.InsertPODetail(txtPONo.Text, txtItem.Text, chkFilm.Checked, POQty, "D", priQty - availabelQty);
                        XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (priQty <= availabelQty)
                {
                    if (!PODetailDAO.Instance.UpdatePODetail(ID, cboPriority.EditValue.ToString(), priQty))
                    {
                        XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (cboPriority.EditValue.ToString() == "B-1" || cboPriority.EditValue.ToString() == "C" || cboPriority.EditValue.ToString() == "D" || cboPriority.EditValue.ToString() == "E")
            {
                priQty = POQty - reserveQty;
                // if (!PODetailDAO.Instance.UpdatePODetail(ID, cboPriority.EditValue.ToString(), POQty)) 
                if (POQty - reserveQty == 0)
                {

                    string IDs = gridPODetail.GetRowCellValue(gridPODetail.FocusedRowHandle, "ID").ToString();
                    PODetailDAO.Instance.DeletePODetail(IDs);
                    LoadData();
                }
                else if (!PODetailDAO.Instance.UpdatePODetail(ID, cboPriority.EditValue.ToString(), priQty))
                {
                    XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cboPriority.EditValue.ToString() == "B-2")
            {
                if (priQty > (POQty - reserveQty) || priQty <= 0)
                {
                    XtraMessageBox.Show($"Không thể nhập quá số lượng {(POQty - reserveQty)}\nCan't enter quantity more than {(POQty - reserveQty)} or 0", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (priQty == (POQty - reserveQty))
                {
                    if (!PODetailDAO.Instance.UpdatePODetail(ID, cboPriority.EditValue.ToString(), priQty))
                    {
                        XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (priQty < (POQty - reserveQty))
                {
                    if (!PODetailDAO.Instance.UpdatePODetail(ID, cboPriority.EditValue.ToString(), priQty))
                    {
                        XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        PODetailDAO.Instance.InsertPODetail(txtPONo.Text, txtItem.Text, chkFilm.Checked, POQty, "D", (POQty - reserveQty - priQty));
                        XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> listIDDelete = new List<string>();
            foreach (int rowHandle in gridPODetail.GetSelectedRows())
            {
                listIDDelete.Add((gridPODetail.GetRow(rowHandle) as PODetail).ID);
            }
            if (MessageBox.Show("This Action Can't Undo. Do you want to delete? \n Hành Động Này Không Thể Hoàn Tác.Bạn có muốn xóa không?", "Thông báo [Message]", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < listIDDelete.Count; i++)
                {
                    PODetailDAO.Instance.DeletePODetail(listIDDelete[i]);


                }
            }
            LoadData();
           
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportERP_PODetail frm = new frmImportERP_PODetail();
            frm.FormClosed += ImportClosed;
            frm.ShowDialog();
        }

        private void ImportClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void cboPriority_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboPriority.EditValue.ToString() == "B-2")
            {
                txtQty.Enabled = true;
            }
            else
            {
                txtQty.Enabled = false;
            }
        }

        private void gridPODetail_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridPODetail.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridPODetail); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridPODetail); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void cboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPriority.EditValue.ToString().Equals("B-2"))
            {
                txtQty.Enabled = true;
            }
            else
            {
                txtQty.Enabled = false;
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

                gridViewToExport = (GridView)dgDetail.MainView;
                gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
            }
        }

        private void dgDetail_Click(object sender, EventArgs e)
        {

        }
    }
}