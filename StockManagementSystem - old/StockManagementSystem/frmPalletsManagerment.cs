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
    public partial class frmPalletsManagerment : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listPallets = new BindingSource();

        public frmPalletsManagerment()
        {
            InitializeComponent();
            listPallets.DataSource = LabelPrintDAO.Instance.GetListLabelDetail();
            dgDetail.DataSource = listPallets;
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                LabelPrint pallet = (gridView1.GetRow(rowHandle) as LabelPrint);
                if (!LabelPrintDAO.Instance.UpdatePalletEnable(pallet.ItemCode, pallet.PalletNo, pallet.LocationCode, pallet.IsEnable, LoginedUser._DisplayName))
                {
                    XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            /*   foreach (LabelPrint pallet in listPallets)
               {
                   if (!LabelPrintDAO.Instance.UpdatePalletEnable(pallet.ItemCode, pallet.PalletNo, pallet.LocationCode, pallet.IsEnable, LoginedUser._DisplayName))
                   {
                       XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       return;
                   }
               }*/
            XtraMessageBox.Show("Update Succeed \n Cập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeSelectAll_Click(object sender, EventArgs e)
        {
            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                (gridView1.GetRow(rowHandle) as LabelPrint).IsEnable = false;
            }

            // Rebind the data to update the DataGridView
            dgDetail.DataSource = null;
            dgDetail.DataSource = listPallets;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                (gridView1.GetRow(rowHandle) as LabelPrint).IsEnable = true;
            }
            // Rebind the data to update the DataGridView
            dgDetail.DataSource = null;
            dgDetail.DataSource = listPallets;
        }
    }
}