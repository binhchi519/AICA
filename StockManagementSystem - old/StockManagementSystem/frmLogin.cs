/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace StockManagementSystem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DataTable UserLogin = new DataTable();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            UserLogin = UserManagementDAO.Instance.Login(Username, Password);

            if(UserLogin.Rows.Count > 0)
            {
                Properties.Settings.Default.CurrentUser = txtUsername.Text;
                Properties.Settings.Default.UserRight = Boolean.Parse(UserLogin.Rows[0]["IsAdmin"].ToString());
                Properties.Settings.Default.Save();
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }    
            else
            {
                XtraMessageBox.Show("Username or Password invalid!\nTài khoản hoặc mật khẩu không hợp lệ!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            if (DataProvider.ReadConfig() == false)
            {
                XtraMessageBox.Show("Please config database connection! \nVui lòng thiết lập kết nối cơ sở dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ConnectionString = "Data Source=" + SQLConfig.ServerName + ";Initial Catalog=" + SQLConfig.DBName + ";User ID=" + SQLConfig.LoginName + ";Password=" + SQLConfig.Password;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Please config database connection! \nVui lòng thiết lập kết nối cơ sở dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit? \nBạn có muốn thoát chương trình?", "Thông báo [Message]", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Reset();
                e.Cancel = true;
            }
        }
    }
}
*/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Threading;

namespace StockManagementSystem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DataTable UserLogin = new DataTable();
        private static Mutex mutex = null;

        public frmLogin()
        {
            InitializeComponent();
            CheckForExistingInstance();
        }

        private void CheckForExistingInstance()
        {
            bool createdNew;
            string uniqueAppName = "SATO - FG Managerment System"; // Replace with your application name

            mutex = new Mutex(true, uniqueAppName, out createdNew);

            if (!createdNew)
            {
                // Another instance is already running, so exit this instance
                XtraMessageBox.Show("Ứng Dụng Đang Chạy, Không thể mở thêm !", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mutex.ReleaseMutex();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
           // UserLogin = UserManagementDAO.Instance.Login(Username, Password);
            LoginedUser user = UserManagementDAO.Instance.LoginedUser(Username, Password);
            if (user!=null)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Username or Password invalid!\nTài khoản hoặc mật khẩu không hợp lệ!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }/*if (UserLogin.Rows.Count > 0)
            {
                Properties.Settings.Default.CurrentUser = txtUsername.Text;
                *//*Properties.Settings.Default.UserName = UserLogin.*//*
                Properties.Settings.Default.UserRight = Boolean.Parse(UserLogin.Rows[0]["IsAdmin"].ToString());
                Properties.Settings.Default.Save();
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Username or Password invalid!\nTài khoản hoặc mật khẩu không hợp lệ!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            if (DataProvider.ReadConfig() == false)
            {
                XtraMessageBox.Show("Please config database connection! \nVui lòng thiết lập kết nối cơ sở dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ConnectionString = "Data Source=" + SQLConfig.ServerName + ";Initial Catalog=" + SQLConfig.DBName + ";User ID=" + SQLConfig.LoginName + ";Password=" + SQLConfig.Password;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Please config database connection! \nVui lòng thiết lập kết nối cơ sở dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit? \nBạn có muốn thoát chương trình?", "Thông báo [Message]", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Reset();
                e.Cancel = true;
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
