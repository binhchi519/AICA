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
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
            txtConfim.Properties.UseSystemPasswordChar = !confirmPassCheck.Checked;
            txtNewPass.Properties.UseSystemPasswordChar = !newPassCheck.Checked;
            txtOldPass.Properties.UseSystemPasswordChar = !oldPassCheck.Checked;

        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOldPass.Text))
            {
                XtraMessageBox.Show("Please enter old password!\nVui lòng nhập mật khẩu cũ!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPass.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtNewPass.Text))
            {
                XtraMessageBox.Show("Please enter new password!\nVui lòng nhập mật khẩu mới!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtConfim.Text))
            {
                XtraMessageBox.Show("Please enter confirm password!\nVui lòng xác nhận mật khẩu!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfim.Focus();
                return;
            }

            if (txtNewPass.Text.Equals(txtConfim.Text) == false)
            {
                XtraMessageBox.Show("password incorrect!\nMật khẩu không trùng nhau!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Focus();
                return;
            }

            //DataTable UserLogin = new DataTable();
            //UserLogin = UserManagementDAO.Instance.Login(txtIOldPass.Text);
            if (!LossDAO.Instance.ChangeLossPassword(txtNewPass.Text.ToString(), txtOldPass.Text.ToString()))
            {
                XtraMessageBox.Show("Change password failed!\nSai Mật Khẩu !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Change password successfully!\nĐổi mật khẩu thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfim.Text = "";
                txtNewPass.Text = "";  
                txtOldPass.Text = "";
            }

        }

   

 

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            txtConfim.Properties.UseSystemPasswordChar = !confirmPassCheck.Checked;  
        }

        private void newPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPass.Properties.UseSystemPasswordChar = !newPassCheck.Checked;
        }

        private void oldPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPass.Properties.UseSystemPasswordChar = !oldPassCheck.Checked;
        }
    }
}