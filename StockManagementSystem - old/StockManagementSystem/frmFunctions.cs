using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmFunctions : DevExpress.XtraEditors.XtraForm
    {
        BindingSource functionsList = new BindingSource();
        public frmFunctions()
        {
            InitializeComponent();
        }
        private void btnNewFunc_Click(object sender, EventArgs e)
        {
            txtFuncID.Text = -1+"";
            txtDevice.Text = "";
            txtMenu.Text = "";
            txtFunctionName.Text = "";
            txtBtnName.Text = "";
        }

        private void btnSaveFunc_Click(object sender, EventArgs e)
        {
            FunctionsDAO.Instance.performFunctions(txtFuncID.Text, txtDevice.Text, txtMenu.Text, txtFunctionName.Text, txtBtnName.Text, LoginedUser._DisplayName, "0");
            LoadData();
        }
        private void btnDisableFunc_Click(object sender, EventArgs e)
        {
            FunctionsDAO.Instance.performFunctions(txtFuncID.Text, txtDevice.Text, txtMenu.Text, txtFunctionName.Text, txtBtnName.Text, LoginedUser._DisplayName, "1");
            LoadData();
        }

        private void frmFunctionsList_Load(object sender, EventArgs e)
        {
            LoadData();
            BindingData();
           
        }


        private void LoadData()
        {
            functionsList.DataSource = FunctionsDAO.Instance.GetAllPermissons();
            dgFuncDetail.DataSource = functionsList;
            ((GridView)dgFuncDetail.MainView).CustomDrawRowIndicator += ngList_CustomDrawRowIndicator;
        }

        private void BindingData()
        {
            txtFuncID.DataBindings.Add(new Binding("Text", dgFuncDetail.DataSource, "FunctionID", true, DataSourceUpdateMode.Never));
            txtDevice.DataBindings.Add(new Binding("Text", dgFuncDetail.DataSource, "Device", true, DataSourceUpdateMode.Never));
            txtMenu.DataBindings.Add(new Binding("Text", dgFuncDetail.DataSource, "MenuScreen", true, DataSourceUpdateMode.Never));
            txtFunctionName.DataBindings.Add(new Binding("Text", dgFuncDetail.DataSource, "FunctionName", true, DataSourceUpdateMode.Never));
            txtBtnName.DataBindings.Add(new Binding("Text", dgFuncDetail.DataSource, "BtnPermission", true, DataSourceUpdateMode.Never));
        }
        private void ngList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!((GridView)dgFuncDetail.MainView).IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)dgFuncDetail.MainView); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)dgFuncDetail.MainView); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void btnCoppy_Click(object sender, EventArgs e)
        {
            txtFuncID.Text = -1 + "";
        }

        private void txtFunctionName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtBtnName.Text = txtDevice.Text+"_" + txtMenu.Text.Replace(" ", "") + "_" + txtFunctionName.Text.Replace(" ", "");
        }

        private void txtMenu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtBtnName.Text = txtDevice.Text + "_" + txtMenu.Text.Replace(" ", "") + "_" + txtFunctionName.Text.Replace(" ", "");
        }
    }
}