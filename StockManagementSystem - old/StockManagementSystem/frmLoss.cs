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
    public partial class frmLoss : DevExpress.XtraEditors.XtraForm
    {
        BindingSource lossList = new BindingSource();

        public frmLoss()
        {
            InitializeComponent();
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            Loaddata();
            BindingData();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private void Loaddata()
        {
            lossList.DataSource = LossDAO.Instance.GetListLoss();
            dgDetail.DataSource = lossList;

            btnSave.Enabled= HasPermission("PC_Loss_CreateUpdateLoss");
            btnNew.Enabled= HasPermission("PC_Loss_CreateUpdateLoss");
            btnExport.Enabled= HasPermission("PC_Loss_Export");
            btnDelete.Enabled= HasPermission("PC_Loss_Delete");
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void BindingData()
        {
            txtLossCode.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "LossCode", true, DataSourceUpdateMode.Never));
            txtLossName.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "LossName", true, DataSourceUpdateMode.Never));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtLossCode.Enabled = true;
            txtLossCode.Text = String.Empty;
            txtLossName.Text = String.Empty;
            txtLossCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lossName = txtLossName.Text;
            string lossCode = txtLossCode.Text;
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            bool flag = LossDAO.Instance.InsertAndUpdateLoss(lossCode, lossName) == true ? true : false;
            Loaddata();
            if (flag == true)
            {
                txtLossCode.Enabled = false;
                XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int flag = MessageBox.Show("Do you want to delete? \nBạn có muốn xóa không?", "Thông báo [Message]", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK ? LossDAO.Instance.DeleteLoss(txtLossCode.Text) == true ? 1 : 2 : 0;
            Loaddata();
            switch (flag)
            {
                case 0:
                    {
                        XtraMessageBox.Show("Fail to Delete !\n Xoá Thất Bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtLocationName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLossName.Text.Trim()))
            {
                ErrorProvider.SetError(txtLossName, "Please enter loss reason!");
            }
            else
            {
                ErrorProvider.SetError(txtLossName, null);
            }
        }

        private void txtLocationCode_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLossCode.Text.Trim()))
            {
                ErrorProvider.SetError(txtLossCode, "Please enter loss code!");
            }
            else
            {
                ErrorProvider.SetError(txtLossCode, null);
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