using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
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
    public partial class frmChangeRePrintPass : DevExpress.XtraEditors.XtraForm
    {
        public frmChangeRePrintPass()
        {
            InitializeComponent();
            txtConfim.Properties.UseSystemPasswordChar = !confirmPassCheck.Checked;
            txtNewPass.Properties.UseSystemPasswordChar = !newPassCheck.Checked;
            txtOldPass.Properties.UseSystemPasswordChar = !oldPassCheck.Checked;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

            if (txtConfim.Text.Equals(txtNewPass.Text) == false)
            {
                XtraMessageBox.Show("password incorrect!\nMật khẩu không trùng nhau!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Focus();
                return;
            }

            //DataTable UserLogin = new DataTable();
            //UserLogin = UserManagementDAO.Instance.Login(txtIOldPass.Text);
            if (!LossDAO.Instance.changeRePrintPassword(txtOldPass.Text.ToString(), txtNewPass.Text.ToString()))
            {
                XtraMessageBox.Show("Change password failed, Wrong Password!\nSai Mật Khẩu !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Change password successfully!\nĐổi mật khẩu thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                txtConfim.Text = "";
            }
        }   
        private void newPassCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNewPass.Properties.UseSystemPasswordChar = !newPassCheck.Checked;
        }

        private void oldPassCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            txtOldPass.Properties.UseSystemPasswordChar = !oldPassCheck.Checked;
        }

        private void confirmPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            txtConfim.Properties.UseSystemPasswordChar = !confirmPassCheck.Checked;
        }
    }
}