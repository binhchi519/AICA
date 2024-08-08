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
    public partial class frmImportProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmImportProduct()
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
                string itemCode, itemName, size, locationCode, uom = String.Empty;
                float thickness, actualThickness;
                bool film;
                int QtyPerPallet;

                for (int i = 0; i < gridImport.DataRowCount; i++)
                {
                    itemCode = gridImport.GetRowCellValue(i, gridImport.Columns[0]).ToString();
                    itemName = gridImport.GetRowCellValue(i, gridImport.Columns[1]).ToString();
                    size = gridImport.GetRowCellValue(i, gridImport.Columns[2]).ToString();
                    thickness = float.Parse(gridImport.GetRowCellValue(i, gridImport.Columns[3]).ToString());
                    actualThickness= float.Parse(gridImport.GetRowCellValue(i, gridImport.Columns[4]).ToString());
                    film = (gridImport.GetRowCellValue(i, gridImport.Columns[5]).ToString()).Equals("Yes") ? true : false;
                    QtyPerPallet= Convert.ToInt32(gridImport.GetRowCellValue(i, gridImport.Columns[6]).ToString());
                    uom = gridImport.GetRowCellValue(i, gridImport.Columns[8]).ToString();

                    if (gridImport.GetRowCellValue(i, gridImport.Columns[7])==null)
                    {
                        locationCode = String.Empty;
                    }    
                    else
                    {
                        locationCode = gridImport.GetRowCellValue(i, gridImport.Columns[7]).ToString();
                        if(LocationDAO.Instance.GetListLocationByLocationCode(locationCode).Count==0)
                        {
                            LocationDAO.Instance.InsertAndUpdateLocation(locationCode, locationCode);
                        }    
                    }

                    if (!ProductMasterDAO.Instance.InsertAndUpdateProduct(itemCode, itemName, size, film, locationCode, thickness, actualThickness, QtyPerPallet, uom))
                    {
                        XtraMessageBox.Show($"Can not update item {itemCode}!\nKhông thể cập nhật item {itemCode}", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                XtraMessageBox.Show("Import thành công", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmImportProduct_Load(object sender, EventArgs e)
        {

        }
    }
}