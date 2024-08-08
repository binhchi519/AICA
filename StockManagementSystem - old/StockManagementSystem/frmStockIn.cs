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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.SpreadsheetSource;
using System.Collections;
using DevExpress.DataAccess.Excel;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using StockManagementSystem.DTO;

namespace StockManagementSystem
{
    public partial class frmStockIn : DevExpress.XtraEditors.XtraForm
    {
        BindingSource StockInList = new BindingSource();
        BindingSource CompareData = new BindingSource();
        List<DTO.StockIn> dataList = new List<DTO.StockIn>();
        string path;
        // int actionID;

        public frmStockIn()
        {
            InitializeComponent();

        }
  
        private void frmStockIn_Load(object sender, EventArgs e)
        {
            LoadData();
            BindingData();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            gridView2.CustomDrawRowIndicator += gridView2_CustomDrawRowIndicator;
            EnableControlsForTab0();
        }

        private void LoadData()
        {
            StockInList.DataSource = dataList = StockInDAO.Instance.GetListStockIn();
            dgDetail.DataSource = StockInList;
        }

        private void BindingData()
        {
            cboStockInDate.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "StockInDate", true, DataSourceUpdateMode.Never));
            txtItemCode.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "ItemCode", true, DataSourceUpdateMode.Never));
            txtLocation.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "LocationCode", true, DataSourceUpdateMode.Never));
            txtPalletNo.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "PalletNo", true, DataSourceUpdateMode.Never));
            txtQuantity.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Quantity", true, DataSourceUpdateMode.Never));
        }

        /*  private void btnEdit_Click(object sender, EventArgs e)
          {
              actionID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ActionID").ToString());
              DateTime stockInDate = DateTime.Parse(cboStockInDate.EditValue.ToString());
              int quantity = Convert.ToInt32(txtQuantity.Text) - Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Quantity").ToString());
              string itemCode = txtItemCode.Text;
              string palletNo = txtPalletNo.Text;
              string locationCode = txtLocation.Text;

              if (!StockInDAO.Instance.UpdateStockIn(actionID,stockInDate,quantity, LoginedUser._DisplayName, itemCode,palletNo, locationCode))
              {
                  XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                  XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              LoadData();
          }

          private void btnDelete_Click(object sender, EventArgs e)
          {
              if (MessageBox.Show("Do you want to delete? \nBạn có muốn xóa không?", "Thông báo [Message]", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
              {
                  actionID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ActionID").ToString());
                  string itemCode = txtItemCode.Text;
                  string palletNo = txtPalletNo.Text;
                  StockInDAO.Instance.DeleteStockIn(actionID, LoginedUser._DisplayName, itemCode,palletNo);
                  LoadData();
              }
          }
        */
       

        private void tabDetail_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            switch (tabDetail.SelectedTabPageIndex)
            {
                case 0:
                    LoadData();
                    EnableControlsForTab0();
                    break;
                case 1:
                    LoadCompareData();
                    EnableControlsForTab1();
                    break;
            }
        }
        private void EnableControlsForTab0()
        {
            btnImport.Enabled = HasPermission("PC_StockIn_Import_Sumarize");
            btnExport.Enabled = HasPermission("PC_StockIn_Export");
            cboStockInDate.Enabled = true;
            txtQuantity.Enabled = true;
            fromDate.Enabled = true;
            toDate.Enabled = true;
        }

        private void EnableControlsForTab1()
        {
            btnImport.Enabled = HasPermission("PC_StockIn_Import_Sumarize");
            btnExport.Enabled = HasPermission("PC_StockIn_Export");
            cboStockInDate.Enabled = false;
            txtQuantity.Enabled = false;
            fromDate.Enabled = false;
            toDate.Enabled = false;
            fromDate.Visible = false;
            toDate.Visible = false;
        }

        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            CompareERPDAO.Instance.DeleteERPData(Application.OpenForms["frmStockIn"].Text);
            string item;
            int qty = 0;
            DateTime stockInDate;
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Select file";
            OpenFileDialog.Filter = "Excel (*.xlsx )|*.xlsx";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = OpenFileDialog.FileName;
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = path;
                ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings(GetWorkSheetNameByIndex(0));
                excel.SourceOptions = new ExcelSourceOptions(excelWorksheetSettings);
                excel.SourceOptions.SkipEmptyRows = true;
                excel.SourceOptions.UseFirstRowAsHeader = true;
                excel.Fill();
                DataTable import = new DataTable();
                import = ToDataTable(excel);
                for (int i = 0; i < import.Rows.Count; i++)
                {
                    if (String.IsNullOrWhiteSpace(import.Rows[i]["Tên hàng"].ToString()))
                    {
                        break;
                    }

                    item = import.Rows[i]["Tên hàng"].ToString();

                    if (String.IsNullOrWhiteSpace(import.Rows[i]["Số lượng"].ToString()))
                    {
                        qty = 0;
                    }
                    else
                    {
                        qty = Convert.ToInt32(import.Rows[i]["Số lượng"].ToString());
                    }

                    stockInDate = DateTime.Parse(import.Rows[i]["Ngày phiếu"].ToString());
                    if (!CompareERPDAO.Instance.InsertERPData("STOCKIN", stockInDate, item, qty))
                    {
                        XtraMessageBox.Show($"Can not update item {item}!\nKhông thể cập nhật item {item}", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadCompareData();
            }
        }

        private DataTable ToDataTable(ExcelDataSource excelDataSource)
        {
            IList list = ((IListSource)excelDataSource).GetList();
            DevExpress.DataAccess.Native.Excel.DataView dataView = (DevExpress.DataAccess.Native.Excel.DataView)list;
            List<PropertyDescriptor> props = dataView.Columns.ToList<PropertyDescriptor>();
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (DevExpress.DataAccess.Native.Excel.ViewRow item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        private string GetWorkSheetNameByIndex(int p)
        {
            string worksheetName = "";
            using (ISpreadsheetSource spreadsheetSource = SpreadsheetSourceFactory.CreateSource(path))
            {
                IWorksheetCollection worksheetCollection = spreadsheetSource.Worksheets;
                worksheetName = worksheetCollection[p].Name;
            }
            return worksheetName;
        }

        private void LoadCompareData()
        {
            CompareData.DataSource = CompareERPDAO.Instance.GetListStockInData("STOCKIN");
            dgERP.DataSource = CompareData;
        }

        private void frmStockIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            CompareERPDAO.Instance.DeleteERPData("STOCKIN");
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView2.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView2); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView2); }));
            }
        }
        private void fromDate_EditValueChanged(object sender, EventArgs e)
        {
            if (fromDate.DateTime != null)
            {
                toDate.DateTime = DateTime.Now;
            }
            ApplyFilter();

            /* ApplyFilter();*/
        }
        private void toDate_EditValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void btnExport_Click(object sender, EventArgs e)
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
        private void ApplyFilter()
        {
            DateTime? from = fromDate.DateTime;
            DateTime? to = toDate.DateTime;

            // Set the end date to Now if start date is selected but end date is not
            if (from != null && to == null)
            {
                to = DateTime.Now;
            }

            List<DTO.StockIn> result;

            if (from == null && to == null)
            {
                result = dataList.ToList();
            }
            else if (from == null)
            {

                result = dataList.Where(entity => entity.StockInDate.Date <= to.Value.Date).ToList();


            }
            else if (to == null)
            {
                result = dataList.Where(entity => entity.StockInDate.Date >= from.Value.Date).ToList();
            }
            else
            {
                result = dataList.Where(entity =>
                    entity.StockInDate.Date >= from.Value.Date && entity.StockInDate.Date <= to.Value.Date
                ).ToList();
            }


            dgDetail.DataSource = result;
        }
    }
}