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
    public partial class frmStocktake : DevExpress.XtraEditors.XtraForm
    {
        BindingSource Stockstake = new BindingSource();
        BindingSource CompareData = new BindingSource(); 
        BindingSource HistoryData = new BindingSource();
        string path;
        public frmStocktake()
        {
            InitializeComponent();
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;   
            gridView2.CustomDrawRowIndicator += gridView2_CustomDrawRowIndicator; 
            gridView3.CustomDrawRowIndicator += gridView3_CustomDrawRowIndicator;
            btnImport.Enabled = false;
        }
        private void setUpPermissions()
        {
            btnExport.Enabled = HasPermission("PC_StockTake_Export");
            btnStart.Enabled = HasPermission("PC_StockTake_Start");  
            btnEnd.Enabled = HasPermission("PC_StockTake_End");
            btnImport.Enabled = HasPermission("PC_StockTake_Import");  
           
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        public bool GetData()
        {
            Stockstake.DataSource = StocktakeDAO.Instance.GetAllStockTake();
            dgDetail.DataSource = Stockstake;
            return StocktakeDAO.Instance.GetAllStockTake().Count > 0 ? true : false;
        }

        private void frmStocktake_Load(object sender, EventArgs e)
        {
            bool activeBtn = GetData();
            btnStart.Enabled = activeBtn == false && HasPermission("PC_StockTake_Start");
            btnEnd.Enabled = activeBtn == true && HasPermission("PC_StockTake_End");
            //setUpPermissions();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          
            if (!StocktakeDAO.Instance.StartStocktake(LoginedUser._DisplayName) && (StocktakeDAO.Instance.StartStocktake(LoginedUser._DisplayName)==true))
            {
                XtraMessageBox.Show("Update Fail! Chưa tìm thấy User hiện hành StockTake\nCập nhật thất bại!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool activeBtn = GetData();
            btnStart.Enabled = !activeBtn == false && HasPermission("PC_StockTake_Start");
            btnEnd.Enabled = activeBtn == true && HasPermission("PC_StockTake_End");

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (gridView2.DataSource != null)
            {
                try
                {
                    StocktakeDAO.Instance.EndStocktake(LoginedUser._DisplayName, Application.OpenForms["frmStocktake"].Text);
                    XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XtraMessageBox.Show(ex.Message, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                XtraMessageBox.Show("Please Imported Summarize Data Before Finishing this StockTake. \n Vui lòng Import dữ liệu so sánh để ghi lại lịch sử kiểm kê trước khi kết thúc. ", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            /*try
            {
                StocktakeDAO.Instance.EndStocktake(LoginedUser._DisplayName, Application.OpenForms["frmStocktake"].Text);
                XtraMessageBox.Show("Success!\nCập nhật thành công!", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Update Fail! Please check connection or data relation ship\nCập nhật thất bại! Vui lòng kiểm tra lại kết nối cơ sở dữ liệu hoặc quan hệ dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show(ex.Message, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/
            bool activeBtn = GetData();
            btnStart.Enabled = activeBtn == false && HasPermission("PC_StockTake_Start");
            btnEnd.Enabled = activeBtn == true && HasPermission("PC_StockTake_End");
        }
        private void tabDetail_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            bool activeBtn = GetData();
            if (tabDetail.SelectedTabPageIndex == 0)
            {
                 setUpPermissions();
                btnStart.Enabled = activeBtn == false && HasPermission("PC_StockTake_Start");
                btnExport.Enabled = HasPermission("PC_StockTake_Export");
                btnImport.Enabled = false;
            }
            else if (tabDetail.SelectedTabPageIndex == 1)
            {
                btnStart.Enabled = false;
                btnImport.Enabled = HasPermission("PC_StockTake_Import");
                btnEnd.Enabled = HasPermission("PC_StockTake_End");
                btnExport.Enabled = HasPermission("PC_StockTake_Export");
            }
            else if (tabDetail.SelectedTabPageIndex == 2)
            {
               
                btnImport.Enabled = false;
                btnEnd.Enabled = false;
                btnStart.Enabled = false;
                btnExport.Enabled = HasPermission("PC_StockTake_Export");
                LoadStockTakeHistory();
            }
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
            CompareData.DataSource = CompareERPDAO.Instance.GetListStocktake(Application.OpenForms["frmStocktake"].Text);
            dgERP.DataSource = CompareData;
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                CompareERPDAO.Instance.DeleteERPData(Application.OpenForms["frmStocktake"].Text);
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

                        if (String.IsNullOrWhiteSpace(import.Rows[i]["SL tồn cuối kỳ"].ToString()))
                        {
                            qty = 0;
                        }
                        else
                        {
                            qty = Convert.ToInt32(import.Rows[i]["SL tồn cuối kỳ"].ToString());
                        }

                        //stockInDate = DateTime.Parse(import.Rows[i]["Ngày phiếu"].ToString());
                        if (!CompareERPDAO.Instance.InsertERPData(Application.OpenForms["frmStocktake"].Text, DateTime.Now, item, qty))
                        {
                            XtraMessageBox.Show($"Can not update item {item}!\nKhông thể cập nhật item {item}", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    LoadCompareData();
                }
            }
            catch (Exception ex) {
                XtraMessageBox.Show($"Error Data Format or Underfined  Error!\n Lỗi Không Xác Định hoặc File Excel Không Đúng Định Dạng, Vui lòng kiểm tra lại dữ liệu." +"\n"+ ex.Message, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

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
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 15;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 15;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }
        }private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 15;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView2); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 15;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView2); }));
            }
        }private void gridView3_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 15;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView3); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 15;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView3); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        private void frmStocktake_FormClosing(object sender, FormClosingEventArgs e)
        {
            CompareERPDAO.Instance.DeleteERPData(Application.OpenForms["frmStocktake"].Text);
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
                if (tabDetail.SelectedTabPageIndex == 2)
                {
                    gridViewToExport = gridView3;
                    gridViewToExport.ExportToXlsx(saveFileDialog.FileName);
                }

            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void LoadStockTakeHistory() {
            HistoryData.DataSource = HistoryDAO.Instance.GetAllStockTakeHistory();
            dgHistory.DataSource = HistoryData;
        }

        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            //if(e.ListSourceRow== rowin)
        }
    }
}