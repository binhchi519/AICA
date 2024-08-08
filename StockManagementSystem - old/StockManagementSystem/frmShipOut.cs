using DevExpress.DataAccess.Excel;
using DevExpress.SpreadsheetSource;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class frmShipOut : DevExpress.XtraEditors.XtraForm
    {
        BindingSource ShipOut = new BindingSource();
        BindingSource CompareData = new BindingSource();
        BindingSource NGListData = new BindingSource();
        List<ShipOut> dataList;
        List<NGList> dataNGList;
        string path;
        public frmShipOut()
        {
            InitializeComponent();
            ((GridView)gridControl3.MainView).CustomDrawRowIndicator += ngList_CustomDrawRowIndicator;
            ((GridView)dgERP2.MainView).CustomDrawRowIndicator += ngList_CustomDrawRowIndicator;
        }
        private void LoadData()
        {
            ShipOut.DataSource = dataList = ShipOutDAO.Instance.GetListShipOut();
            dgDetail.DataSource = ShipOut;
           
        }
        private void BindingData()
        {
            cboStockInDate.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "StockInDate", true, DataSourceUpdateMode.Never));
            cboStockOutDate.DataBindings.Add(new Binding("EditValue", dgDetail.DataSource, "StockOutDate", true, DataSourceUpdateMode.Never));
            txtItemCode.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "ItemCode", true, DataSourceUpdateMode.Never));
            txtCustomer.DataBindings.Add(new Binding("Text", dgDetail.DataSource, "Customer", true, DataSourceUpdateMode.Never));
        }
        private void frmShipOut_Load(object sender, EventArgs e)
        {
            btnExport.Enabled = HasPermission("PC_ShipOut_Export");
            LoadData();
            BindingData();
            gvShipOut.CustomDrawRowIndicator += gvShipOut_CustomDrawRowIndicator;

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
            CompareData.DataSource = CompareERPDAO.Instance.GetListShipOutData("SHIPOUT");
            dgERP2.DataSource = CompareData;
        }
        private void LoadNGList()
        {
            NGListData.DataSource = dataNGList = HistoryDAO.Instance.GetNGList();
            gridControl3.DataSource = NGListData;

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //CompareERPDAO.Instance.DeleteERPData(Application.OpenForms["frmShipOut"].Text);
            CompareERPDAO.Instance.DeleteERPData("SHIPOUT");
            string item;
            int qty = 0;
            DateTime stockInDate;
            string customer;
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
                    qty = !String.IsNullOrWhiteSpace(import.Rows[i]["Số lượng"].ToString()) ? Convert.ToInt32(import.Rows[i]["Số lượng"].ToString()) : 0;
                    stockInDate = DateTime.Parse(import.Rows[i]["Ngày phiếu"].ToString());
                    customer = !String.IsNullOrWhiteSpace(import.Rows[i]["Số lượng"].ToString()) ? import.Rows[i]["Nơi nhận hàng"].ToString() : "UNKNOW";

                    if (!CompareERPDAO.Instance.InsertERPShipOut(/* Application.OpenForms["frmShipOut"].Text */ "SHIPOUT", stockInDate, item, qty, customer))
                    {
                        XtraMessageBox.Show($"Can not update item {item}!\nKhông thể cập nhật item {item}", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadCompareData();
            }
        }

        private void frmShipOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            CompareERPDAO.Instance.DeleteERPData("SHIPOUT");
        }

        private void gvShipOut_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvShipOut.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvShipOut); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvShipOut); }));
            }
        }
        private void ngList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!((GridView)gridControl3.MainView).IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)gridControl3.MainView); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)gridControl3.MainView); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void tabDetail_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            if (tabDetail.SelectedTabPageIndex == 0)
            {
                fromDate.Text = "";
                toDate.Text = "";
                LoadData();
                //btnImport.Enabled = false;
                //btnImport.Enabled = HasPermission("PC_ShipOut_Import");
                btnExport.Enabled = HasPermission("PC_ShipOut_Export");
                fromDate.Enabled = true;
                toDate.Enabled = true;

            }
            if (tabDetail.SelectedTabPageIndex == 1)
            {
                LoadCompareData();

                btnImport.Enabled = HasPermission("PC_ShipOut_Import");
                btnExport.Enabled = HasPermission("PC_ShipOut_Export");
                fromDate.Enabled = false;
                toDate.Enabled = false;
            }
            if (tabDetail.SelectedTabPageIndex == 2)
            {
                LoadNGList();
                btnImport.Enabled = false;
                btnExport.Enabled = HasPermission("PC_ShipOut_Export");
                fromDate.Enabled = true;
                toDate.Enabled = true;

            }
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
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
                    gridViewToExport = gvShipOut;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }
                else if (tabDetail.SelectedTabPageIndex == 1)
                {
                    gridViewToExport = gvSummarize;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }
                else if (tabDetail.SelectedTabPageIndex == 2)
                {
                    gridViewToExport = gvNG;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }

            }
        }

        private void fromDate_EditValueChanged(object sender, EventArgs e)
        {
            if (fromDate.DateTime != null)
            {
                toDate.DateTime = DateTime.Now;
            }
            if (tabDetail.SelectedTabPageIndex == 0)
            {
                ApplyFilter(0);
            }
            else if (tabDetail.SelectedTabPageIndex == 2)
            {
                ApplyFilter(2);
            }
        }


        private void toDate_EditValueChanged(object sender, EventArgs e)
        {
            if (tabDetail.SelectedTabPageIndex == 0)
            {
                ApplyFilter(0);
            }
            else if (tabDetail.SelectedTabPageIndex == 2)
            {
                ApplyFilter(2);
            }
        }

        private void ApplyFilter(int tab)
        {
            DateTime? from = fromDate.DateTime;
            DateTime? to = toDate.DateTime;
            switch (tab)
            {
                case 0:
                    {
                        if (from != null && to == null)
                        {
                            to = DateTime.Now;
                        }

                        List<ShipOut> result;

                        if (from == null && to == null)
                        {
                            result = dataList.ToList();
                        }
                        else if (from == null)
                        {

                            result = dataList.Where(entity => entity.ShipOutDate.Date <= to.Value.Date).ToList();


                        }
                        else if (to == null)
                        {
                            result = dataList.Where(entity => entity.ShipOutDate.Date >= from.Value.Date).ToList();
                        }
                        else
                        {
                            result = dataList.Where(entity =>
                                entity.ShipOutDate.Date >= from.Value.Date && entity.ShipOutDate.Date <= to.Value.Date
                            ).ToList();
                        }

                        // ShipOut.DataSource = result;
                        dgDetail.DataSource = result;
                        break;
                    }
                case 2:
                    {

                        if (from != null && to == null)
                        {
                            to = DateTime.Now;
                        }

                        List<NGList> result;

                        if (from == null && to == null)
                        {
                            result = dataNGList.ToList();
                        }
                        else if (from == null)
                        {

                            result = dataNGList.Where(entity => entity.DateTime.Date <= to.Value.Date).ToList();


                        }
                        else if (to == null)
                        {
                            result = dataNGList.Where(entity => entity.DateTime.Date >= from.Value.Date).ToList();
                        }
                        else
                        {
                            result = dataNGList.Where(entity =>
                             entity.DateTime.Date >= from.Value.Date && entity.DateTime.Date <= to.Value.Date
                         ).ToList();
                        }

                        ShipOut.DataSource = result;
                        gridControl3.DataSource = ShipOut.DataSource;
                        break;
                    }
            }
        }
    }
}