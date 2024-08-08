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

namespace StockManagementSystem
{
    public partial class frmConfirmPassword : DevExpress.XtraEditors.XtraForm
    {
        public string inputPass;
        public frmConfirmPassword()
        {
            inputPass = "";
            InitializeComponent();
        }
        private void frm_ConfrimPass_Load(object sender, EventArgs e)
        { 
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!editPassword.Text.Equals("")) {
                inputPass = editPassword.Text;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Please Input Password ! \nVui Lòng Nhập Mật Khẩu !", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK);
            }
            
        }
    }
}