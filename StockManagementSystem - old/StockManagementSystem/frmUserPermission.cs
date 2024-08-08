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
    public partial class frmUserPermission : DevExpress.XtraEditors.XtraForm
    {
        private static string affectedUser = "";
        BindingSource listPermission = new BindingSource();

        public frmUserPermission(string user)
        {

            InitializeComponent();
            txtAfftectedUser.Text = affectedUser = user;
            listPermission.DataSource = FunctionsDAO.Instance.GetListPermissionsOfUser(user);
            dgDetail.DataSource = listPermission;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < viewsData.RowCount; i++)
                {
                    UserPermission pms = (UserPermission)viewsData.GetRow(i);
                    FunctionsDAO.Instance.UpsertUserPermission(affectedUser, pms.ID, pms.IsAllowed, LoginedUser._DisplayName);
                }
                XtraMessageBox.Show("Update Succeed \n Cập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee) {
                XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (LoginedUser._UserName.Equals(txtAfftectedUser.Text)) {
                XtraMessageBox.Show("Login Session Expried! Please Re-login to update new infomation \n Phiên đăng nhập hết hạn ! Vui lòng đăng nhập lại để làm mới thông tin", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the current form (Form2)
                this.Close();

                // Find and close Form1
                Form form1 = Application.OpenForms["frmUserManagement"];
                form1?.Close();

                // Find and close the main form
                Form mainForm = Application.OpenForms["frmMain"]; // Replace "MainForm" with the name of your main form
                mainForm?.Close();

            }

        }

        // Rest of your code...

        private void btnRevokeAll_Click(object sender, EventArgs e)
        {
            foreach (UserPermission user in listPermission)
            {
                user.IsAllowed = false;
            }
            // Rebind the data to update the DataGridView
            dgDetail.DataSource = null;
            dgDetail.DataSource = listPermission;
        }

        private void btnAllowAll_Click(object sender, EventArgs e)
        {
            foreach (UserPermission user in listPermission)
            {
                user.IsAllowed = true;
            }
            // Rebind the data to update the DataGridView
            dgDetail.DataSource = null;
            dgDetail.DataSource = listPermission;
        }
    }
}