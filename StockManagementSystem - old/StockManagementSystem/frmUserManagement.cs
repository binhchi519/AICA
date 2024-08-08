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
    public partial class frmUserManagement : DevExpress.XtraEditors.XtraForm
    {
        BindingSource UserList = new BindingSource();

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            BindingData();
        }

        private void LoadData()
        {
            UserList.DataSource = UserManagementDAO.Instance.GetListUser();
            dgDetail.DataSource = UserList;
            ((GridView)dgDetail.MainView).CustomDrawRowIndicator += ngList_CustomDrawRowIndicator;
        }

        private void BindingData()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtPassword.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Password", true, DataSourceUpdateMode.Never));
            txtDisplayname.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            chkIsAdmin.DataBindings.Add(new Binding("Checked", dgDetail.DataSource, "IsAdmin", true, DataSourceUpdateMode.Never));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            txtUsername.Text = String.Empty;
            txtDisplayname.Text = String.Empty;
            txtPassword.Text = String.Empty;
            chkIsAdmin.Checked = false;
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _userName, _displayName, _passWord;
            bool _isAdmin;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }


            _userName = txtUsername.Text;
            _displayName = txtDisplayname.Text;
            _passWord = txtPassword.Text;
            _isAdmin = chkIsAdmin.Checked;
            bool flag = UserManagementDAO.Instance.UpdateUser(_userName, _passWord, _displayName, _isAdmin) == true ? true : false;
            LoadData();
            if (flag == true)
            {
                XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Enabled = false;
                if (txtUsername.Text.Equals(LoginedUser._UserName))
                {
                    XtraMessageBox.Show("Login Session is expired, Please login !\nPhiên đăng nhập hết hạn, Vui lòng đăng nhập lại để cập nhật thay đổi!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Close the current form (Form2)
                    this.Close();
                    // Find and close the main form
                    Form mainForm = Application.OpenForms["frmMain"];
                    mainForm?.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        /* private static void reLogin()
         {
             // After login, check if the user is authenticated again
             this.hide();

             *//*// Show the login form
             Application.Run(new frmLogin());*//*


         }*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete ? \n Xác nhận xóa người dùng này ?", "Thông báo [Message]", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                bool flag = UserManagementDAO.Instance.DeleteUser(txtUsername.Text) == true ? true : false;
                LoadData();
                if (flag == true)
                {
                    XtraMessageBox.Show("Delete Success!\nXoá thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Delete Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                // ErrorProvider.SetError(txtUsername, "Please enter username!");

            }
            else
            {
                //   ErrorProvider.SetError(txtUsername, null);
            }
        }

        private void txtDisplayname_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplayname.Text.Trim()))
            {
                // ErrorProvider.SetError(txtDisplayname, "Please enter display name!");
            }
            else
            {
                // ErrorProvider.SetError(txtDisplayname, null);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                //  ErrorProvider.SetError(txtPassword, "Please enter password!");
            }
            else
            {
                //   ErrorProvider.SetError(txtPassword, null);
            }
        }
        private void ngList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!((GridView)dgDetail.MainView).IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)dgDetail.MainView); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)dgDetail.MainView); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            frmUserPermission frmUserPermission = new frmUserPermission(txtUsername.Text);
            frmUserPermission.ShowDialog();
        }
    }
}