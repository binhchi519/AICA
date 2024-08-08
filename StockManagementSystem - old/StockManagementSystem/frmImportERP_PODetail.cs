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
using DevExpress.DataAccess.Excel;
using DevExpress.SpreadsheetSource;
using StockManagementSystem.DAO;

namespace StockManagementSystem
{
    public partial class frmImportERP_PODetail : DevExpress.XtraEditors.XtraForm
    {
        public frmImportERP_PODetail()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Select file";
            OpenFileDialog.Filter = "Excel (*.xlsx )|*.xlsx";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = OpenFileDialog.FileName;
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = txtPath.Text;
                ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings(GetWorkSheetNameByIndex(0));
                excel.SourceOptions = new ExcelSourceOptions(excelWorksheetSettings);
                excel.SourceOptions.SkipEmptyRows = true;
                excel.SourceOptions.UseFirstRowAsHeader = true;
                excel.Fill();
                dgDetail.DataSource = excel;
            }
        }

        private string GetWorkSheetNameByIndex(int p)
        {
            string worksheetName = "";
            using (ISpreadsheetSource spreadsheetSource = SpreadsheetSourceFactory.CreateSource(txtPath.Text))
            {
                IWorksheetCollection worksheetCollection = spreadsheetSource.Worksheets;
                worksheetName = worksheetCollection[p].Name;
            }
            return worksheetName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string PoNo, Customer, Item;
                string PODate;
                bool Film = false;
                int Qty;

                PoNo = (gridImport.GetRowCellValue(3, gridImport.Columns[0]).ToString());
                PODate = gridImport.GetRowCellValue(3, gridImport.Columns[3]).ToString();
                Customer = gridImport.GetRowCellValue(11, gridImport.Columns[8]).ToString();

                if (!PODetailDAO.Instance.InsertPOMaster(PoNo, DateTime.ParseExact(PODate, "dd.MM.yyyy", null), Customer))
                {
                    XtraMessageBox.Show($"Can not update PI {PoNo}!\nKhông thể cập nhật item {PoNo}", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool importFlag = true;
                String itemf = "";
                String items = " ";
                int itemfCount = 0;
                int itemsCount = 0;
                for (int i = 25; i < gridImport.DataRowCount; i++)
                {
                    if(gridImport.GetRowCellValue(i, gridImport.Columns[1])== null)
                    {
                        break;
                    }    

                    Item = gridImport.GetRowCellValue(i, gridImport.Columns[1]).ToString();
                    if (gridImport.GetRowCellValue(i, gridImport.Columns[2]) ==null)
                    {
                        Film = false;
                    }    
                    else
                    {
                        Film = true;
                    }    

                    Qty = Int32.Parse(gridImport.GetRowCellValue(i, gridImport.Columns[5]).ToString());

                    if (!PODetailDAO.Instance.InsertPODetail(PoNo, Item.Trim(), Film, Qty, "D", Qty))
                    {
                        importFlag = false;
                        itemfCount++;
                        itemf += "\t" + Item + "\t\n";
                        // XtraMessageBox.Show($"Can not update item {Item}!\nKhông thể cập nhật item {Item}", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        itemsCount++;
                        items += "\t" + Item + "\t\n";
                    }
                    
                }
                if (importFlag == false)
                {
                    XtraMessageBox.Show($"\t\tDanh Sách Không Thể Nhập PI: {itemfCount} Mã \n"+itemf, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                XtraMessageBox.Show($"\t\tMã Hàng PO Được Nhập Thành Công: {itemsCount} Mã \n" + items, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmImportERP_PODetail_Load(object sender, EventArgs e)
        {

        }
    }
}