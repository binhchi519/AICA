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
using DevExpress.DataAccess.Excel;
using DevExpress.SpreadsheetSource;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms.VisualStyles;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using StockManagementSystem.DTO;

namespace StockManagementSystem
{
    public partial class frmStockData : DevExpress.XtraEditors.XtraForm
    {
        BindingSource StockData = new BindingSource();
        BindingSource SummarizeData = new BindingSource();
        string path;

        public frmStockData()
        {
            InitializeComponent();
            btnExport.Enabled = true;
            setUpPermissions();


        }

        private void tabDetail_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            if(tabDetail.SelectedTabPageIndex==0)
            {
                LoadStockData();
            }   
            if(tabDetail.SelectedTabPageIndex==1)
            {
               
                LoadCompareData();
            }
            setUpPermissions();
        }
        private void setUpPermissions()
        {
            btnExport.Enabled = HasPermission("PC_StockData_Export");
            btnExportStockData.Enabled = HasPermission("PC_StockData_Export");
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void LoadStockData()
        {
            StockData.DataSource = StockDataDAO.Instance.GetListStockData();
            dgDetail.DataSource = StockData;
            setUpPermissions();
        }

        private void LoadCompareData()
        {
            SummarizeData.DataSource = CompareERPDAO.Instance.GetListStockData();
            dgERP.DataSource = SummarizeData;
        }

        private void frmStockData_Load(object sender, EventArgs e)
        {
            LoadStockData();
            gridStockData.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            gvInventory.CustomDrawRowIndicator += gvInventory_CustomDrawRowIndicator;
            setUpPermissions();
        }


        private void frmStockData_FormClosing(object sender, FormClosingEventArgs e)
        {
            CompareERPDAO.Instance.DeleteERPData(Application.OpenForms["frmStockData"].Text); 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx )|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                dgERP.ExportToXlsx(saveFileDialog.FileName);
            }    
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridStockData.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridStockData); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridStockData); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gvInventory_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvInventory.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvInventory); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvInventory); }));
            }
        }

        private void btnExportStockData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GridView gridViewToExport;

                // Choose the appropriate GridView based on the focused control
                if (tabDetail.SelectedTabPageIndex == 0)
                {
                    gridViewToExport = dgDetail.MainView as GridView;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }
                if (tabDetail.SelectedTabPageIndex == 1)
                {
                    gridViewToExport = dgERP.MainView as GridView;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }

            }
        }

        private void dgDetail_Click(object sender, EventArgs e)
        {

        }

        private void dgERP_Click(object sender, EventArgs e)
        {

        }
    }
}