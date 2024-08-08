using DevExpress.XtraEditors;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class frm_Create_Packing : DevExpress.XtraEditors.XtraForm
    {
        public string Customer;
        public string loadingTime;
        public bool create = false;
        public bool nextMonth = false;


        public frm_Create_Packing()
        {
            InitializeComponent();
        }

        private void frm_Create_Packing_Load(object sender, EventArgs e)
        {
            /* txtCustomer.Text = Customer;
             if (chkLoadingtime.Checked)
             {
                 cboLoadingTime.Properties.DataSource = null;
                 cboLoadingTime.Enabled = false;
             }
             else
             {
                 cboLoadingTime.Properties.DataSource = LoadingTimeDAO.Instance.GetListLoadingTime(txtCustomer.Text);
                 cboLoadingTime.Properties.DisplayMember = "Loadingtime";
                 cboLoadingTime.Properties.ValueMember = "Loadingtime";
                 cboLoadingTime.Enabled = true;
             }
             cboLoadingTime.Properties.DataSource = LoadingTimeDAO.Instance.GetListLoadingTime(txtCustomer.Text);
             cboLoadingTime.Properties.DisplayMember = "Loadingtime";
             cboLoadingTime.Properties.ValueMember = "Loadingtime";
             cboLoadingTime.Enabled = true;


             */
            //chkLoadingtime.Checked = true;
            txtCustomer.Text = Customer;

            if (chkLoadingtime.Checked)
            {
                cboLoadingTime.Properties.DataSource = null;
                cboLoadingTime.Enabled = false;
            }
            else
            {
                cboLoadingTime.Properties.DataSource = LoadingTimeDAO.Instance.GetListLoadingTime(txtCustomer.Text);
                cboLoadingTime.Properties.DisplayMember = "Loadingtime";
                cboLoadingTime.Properties.ValueMember = "Loadingtime";
                cboLoadingTime.Enabled = true;
            }

            // Make sure to populate the LookUpEdit before setting the selected item
            if (LoadingTimeDAO.Instance.GetListLoadingTime(txtCustomer.Text).Count > 0)
            {
                List<LoadingTime> listData = LoadingTimeDAO.Instance.GetListLoadingTime(txtCustomer.Text);
                listData.Reverse();
                cboLoadingTime.Properties.DataSource = listData;

                cboLoadingTime.Properties.DisplayMember = "Loadingtime";
                cboLoadingTime.Properties.ValueMember = "Loadingtime";

                cboLoadingTime.ItemIndex = 0;
            }
            else {
                chkLoadingtime.Checked = true;
            }
           
            // Set the selected item to the last item
            /* if (cboLoadingTime.DataBindings.Count > 0)
             {
                 cboLoadingTime.EditValue = cboLoadingTime.Properties.GetDataSourceRowValue(cboLoadingTime.Properties.Items.Count - 1, cboLoadingTime.Properties.ValueMember);
             }*/
        }
        private void twoCHK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoadingTimeNextMonth.Checked == true && chkLoadingtime.Checked == true) {
                cboLoadingTime.Properties.DataSource = null;
                cboLoadingTime.Enabled = false;
            }
            else if (chkLoadingTimeNextMonth.Checked == true && chkLoadingtime.Checked == false) {
                chkLoadingtime.Checked = true;
                cboLoadingTime.Properties.DataSource = null;
                cboLoadingTime.Enabled = false;
            }
            else if (chkLoadingTimeNextMonth.Checked == false && chkLoadingtime.Checked == true) {
                cboLoadingTime.Properties.DataSource = null;
                cboLoadingTime.Enabled = false;
            }
            else if (chkLoadingTimeNextMonth.Checked == false && chkLoadingtime.Checked == false) {
                cboLoadingTime.Properties.DataSource = LoadingTimeDAO.Instance.GetListLoadingTime(txtCustomer.Text);
                cboLoadingTime.Properties.DisplayMember = "Loadingtime";
                cboLoadingTime.Properties.ValueMember = "Loadingtime";
                cboLoadingTime.Enabled = true;
            }
        }

        private void frm_Create_Packing_FormClosing(object sender, FormClosingEventArgs e)
        {
             
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (chkLoadingtime.Checked)
            {
                if (chkLoadingTimeNextMonth.Checked)
                {
                    loadingTime = "+1";
                }
                else {
                    loadingTime = String.Empty;
                }
               
            }
            else
            {
                if (cboLoadingTime.EditValue == null)
                {
                    XtraMessageBox.Show($" Chưa Chọn LoadingTime", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                loadingTime = cboLoadingTime.EditValue.ToString();
            }
            create = true;
            this.Close();
        }

       

        private void txtCustomer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboLoadingTime_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}