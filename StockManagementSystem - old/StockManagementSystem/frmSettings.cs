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
using System.Data.SqlClient;

namespace StockManagementSystem
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (DataProvider.ReadConfig())
            {
                txtServer.Text = SQLConfig.ServerName;
                txtDatabase.Text = SQLConfig.DBName;
                txtUser.Text = SQLConfig.LoginName;
                txtPassword.Text = SQLConfig.Password;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }    
            String connectionString = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtDatabase.Text.Trim() + ";User ID=" + txtUser.Text.Trim() + ";Password=" + txtPassword.Text.Trim();
            SqlConnection CheckConnect = new SqlConnection(connectionString);
            try
            {
                CheckConnect.Open();
                if (CheckConnect.State == ConnectionState.Open)
                {                    
                    XtraMessageBox.Show("Kết nối thành công\nConnect successfully!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kết nối thất bại! Vui lòng kiểm tra lại cấu hình\nConnect failed! Please check your setting", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                CheckConnect.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }    

            bool Writeconfig = DataProvider.WriteConfig(txtServer.Text.Trim(), txtDatabase.Text.Trim(), txtUser.Text.Trim(), txtPassword.Text.Trim());
            if (Writeconfig)
            {
                MessageBox.Show("Save Successful!");
                return;
            }
            else
            {
                MessageBox.Show("Save Error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataProvider.ReadConfig();
            this.Close();
        }

        private void txtServer_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtServer.Text.Trim()))
            {
                e.Cancel = true;
                txtServer.Focus();
                txtServer.Text = String.Empty;
                ErrorProvider.SetError(txtServer, "Please enter server!");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtServer, null);
            }
        }

        private void txtDatabase_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtDatabase.Text.Trim()))
            {
                e.Cancel = true;
                txtDatabase.Focus();
                txtDatabase.Text = String.Empty;
                ErrorProvider.SetError(txtDatabase, "Please enter database!");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtDatabase, null);
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                e.Cancel = true;
                txtUser.Focus();
                txtUser.Text = String.Empty;
                ErrorProvider.SetError(txtUser, "Please enter username!");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtUser, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtPassword.Focus();
                txtPassword.Text = String.Empty;
                ErrorProvider.SetError(txtPassword, "Please enter password!");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtPassword, null);
            }
        }
    }
}