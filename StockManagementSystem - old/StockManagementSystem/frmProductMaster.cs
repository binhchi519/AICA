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
using DevExpress.XtraGrid.Views.Grid;
using StockManagementSystem.DTO;

namespace StockManagementSystem
{
    public partial class frmProductMaster : DevExpress.XtraEditors.XtraForm
    {
        BindingSource productList = new BindingSource();
        BindingSource locationList = new BindingSource();

        public frmProductMaster()
        {
            InitializeComponent();
        }

        private void frmProductMaster_Load(object sender, EventArgs e)
        {
            LoadData();
            BindingData();
            LoadLocation();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;


            btnNew.Enabled = HasPermission("PC_ProductMaster_CreateUpdateProduct");
            btnSave.Enabled = HasPermission("PC_ProductMaster_CreateUpdateProduct");
            btnDelete.Enabled = HasPermission("PC_ProductMaster_Delete");
            btnExport.Enabled = HasPermission("PC_ProductMaster_Import");
            btnImport.Enabled = HasPermission("PC_ProductMaster_Export");
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void LoadData()
        {
            productList.DataSource = ProductMasterDAO.Instance.GetListProduct();
            dgDetail.DataSource = productList;
        }

        private void LoadLocation()
        {
            cboLocation.Properties.DataSource = LocationDAO.Instance.GetListLocation();
            cboLocation.Properties.ValueMember = "LocationCode";
            cboLocation.Properties.DisplayMember = "LocationName";
        }

        private void BindingData()
        {
            txtItemCode.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "ItemCode", true, DataSourceUpdateMode.Never));
            txtItemName.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "ItemName", true, DataSourceUpdateMode.Never));
            txtSize.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Size", true, DataSourceUpdateMode.Never));
            chkFilm.DataBindings.Add(new Binding("Checked", dgDetail.DataSource, "Film", true, DataSourceUpdateMode.Never));
            cboLocation.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "LocationCode", true, DataSourceUpdateMode.Never));
            txtThickness.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Thickness", true, DataSourceUpdateMode.Never));
            txtActualThickness.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "ActualThickness", true, DataSourceUpdateMode.Never));
            txtQtyPerPallet.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "QtyPerPallet", true, DataSourceUpdateMode.Never));
            txtUOM.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Uom", true, DataSourceUpdateMode.Never));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtItemCode.Enabled = true;
            txtItemCode.Text = String.Empty;
            txtItemName.Text = String.Empty;
            txtSize.Text = String.Empty;
            chkFilm.Checked = false;
            cboLocation.EditValue = null;
            txtThickness.Text = String.Empty;
            txtActualThickness.Text = String.Empty;
            txtQtyPerPallet.Text = String.Empty;
            txtUOM.Text = String.Empty;
            txtItemCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _itemCode, _itemName, _size, _locationCode, _Uom;
            bool _film;
            float _thickness, _actualThickness;
            int _qtyPerPallet;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            _itemCode = txtItemCode.Text;
            _itemName = txtItemName.Text;
            _size = txtSize.Text;

            _Uom = txtUOM.Text;
            _film = Boolean.Parse(chkFilm.Checked.ToString());
            _thickness = float.Parse(txtThickness.Text);
            _actualThickness = float.Parse(txtActualThickness.Text);
            _qtyPerPallet = Convert.ToInt32(txtQtyPerPallet.Text);

            if (cboLocation.EditValue != null)
            {
                _locationCode = cboLocation.EditValue.ToString();
            }
            else
            {
                _locationCode = String.Empty;
            }
            bool flag = ProductMasterDAO.Instance.InsertAndUpdateProduct(_itemCode, _itemName, _size, _film, _locationCode, _thickness, _actualThickness, _qtyPerPallet, _Uom) == true ? true : false;
            LoadData();
            if (flag == false)
            {
                XtraMessageBox.Show("Update Fail!\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemCode.Enabled = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int flag = MessageBox.Show("Do you want to delete? \nBạn có muốn xóa không?", "Thông báo [Message]", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK ? ProductMasterDAO.Instance.DeleteProduct(txtItemCode.Text) == true ? 1 : 2 : 0;
            LoadData();
            switch (flag)
            {
                case 0:
                    {
                        XtraMessageBox.Show("Fail to Delete Product!\n Xoá Thất Bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                case 1:
                    {
                        XtraMessageBox.Show("Success!\nXóa thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportProduct frm = new frmImportProduct();
            frm.FormClosed += ImportClosed;
            frm.ShowDialog();
        }

        private void ImportClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
            LoadLocation();
        }

        private void frmProductMaster_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtItemCode_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtItemCode.Text.Trim()))
            {
                ErrorProvider.SetError(txtItemCode, "Please enter item!");
            }
            else
            {
                ErrorProvider.SetError(txtItemCode, null);
            }
        }

        private void txtItemName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtItemName.Text.Trim()))
            {
                ErrorProvider.SetError(txtItemName, "Please enter print name!");
            }
            else
            {
                ErrorProvider.SetError(txtItemName, null);
            }
        }

        private void txtSize_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSize.Text.Trim()))
            {
                ErrorProvider.SetError(txtSize, "Please enter print name!");
            }
            else
            {
                ErrorProvider.SetError(txtSize, null);
            }
        }

        private void txtThickness_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtThickness.Text.Trim()))
            {
                ErrorProvider.SetError(txtThickness, "Please enter thickness!");
            }
            else
            {
                ErrorProvider.SetError(txtThickness, null);
            }
        }

        private void txtActualThickness_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtActualThickness.Text.Trim()))
            {
                ErrorProvider.SetError(txtActualThickness, "Please enter actual thickness!");
            }
            else
            {
                ErrorProvider.SetError(txtActualThickness, null);
            }
        }

        private void txtQtyPerPallet_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtyPerPallet.Text.Trim()))
            {
                ErrorProvider.SetError(txtQtyPerPallet, "Please enter quantity per pallet!");
            }
            else
            {
                ErrorProvider.SetError(txtQtyPerPallet, null);
            }
        }

        private void txtUOM_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUOM.Text.Trim()))
            {
                ErrorProvider.SetError(txtUOM, "Please enter unit of measure!");
            }
            else
            {
                ErrorProvider.SetError(txtUOM, null);
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
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
    }

}