using DevExpress.XtraGrid.Views.Grid;
using StockManagementSystem.DAO;
using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class frm_History : DevExpress.XtraEditors.XtraForm
    {
        BindingSource GetAllHistory = new BindingSource();

        List<History> data = new List<History>();


        public frm_History()
        {
            InitializeComponent();
            btnExport.Enabled = HasPermission("PC_HistoryRecords_Export");
        }
        private void LoadData()
        {
            data = HistoryDAO.Instance.GetAllStockInHistory();
            data.AddRange(HistoryDAO.Instance.GetAllLossHistory());
            data.AddRange(HistoryDAO.Instance.GetAllStockbackHistory());
            data.AddRange(HistoryDAO.Instance.GetAllMaskingHistory());
            data.AddRange(HistoryDAO.Instance.GetAllMovingHistory());
            data.AddRange(HistoryDAO.Instance.GetAllPackingHistory());
            data.AddRange(HistoryDAO.Instance.GetAllStockOutHistory());
            HashSet<string> uniquePics = new HashSet<string>();
            uniquePics.Add("Everyone");
            foreach (History e in data)
            {
                uniquePics.Add(e.Pic);
            }

            cboPIC.Properties.DataSource = uniquePics;
            cboPIC.EditValue = "Everyone";
            GetAllHistory.DataSource = data;
            dgHistory.DataSource = GetAllHistory;
           
        }
        private bool HasPermission(string permission)
        {
            LoginedUser._AccessToken = UserManagementDAO.Instance.GetPermissionsOfUser(LoginedUser._UserName);
            string[] displayButtons = LoginedUser._AccessToken.Split('|');
            return displayButtons.Contains(permission);
        }
        private void frm_History_Load(object sender, EventArgs e)
        {

            LoadData();
            ((GridView)dgHistory.MainView).CustomDrawRowIndicator += dgDetail_CustomDrawRowIndicator;
            cboPIC.Enabled = true;
            btnExport.Enabled = true;
            gvHistory.OptionsView.ShowIndicator = true;
            btnExport.Enabled = HasPermission("PC_HistoryRecords_Export");
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

                gridViewToExport = (GridView)dgHistory.MainView;
                gridViewToExport.ExportToXlsx(saveFileDialog.FileName);

            }
        }

        private void cboPIC_EditValueChanged(object sender, EventArgs e)
        {

            dgHistory.DataSource = cboPIC.EditValue.ToString().Equals("Everyone") ? data.ToList() : data.Where(entity => entity.Pic.Equals(cboPIC.EditValue.ToString())).ToList();
        }
        private void dgDetail_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!((GridView)dgHistory.MainView).IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)dgHistory.MainView); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, (GridView)dgDetail.MainView); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void toDateHistory_EditValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void fromDateHistory_EditValueChanged(object sender, EventArgs e)
        {
            if (fromDateHistory.DateTime != null)
            {
                toDateHistory.DateTime = DateTime.Now;
            }
            ApplyFilter();
        }
        private void ApplyFilter()
        {
            DateTime? from = fromDateHistory.DateTime;
            DateTime? to = toDateHistory.DateTime;

            // Set the end date to Now if start date is selected but end date is not
            if (from != null && to == null)
            {
                to = DateTime.Now;
            }

            List<History> result;

            if (from == null && to == null)
            {
                result = data.ToList();
            }
            else if (from == null)
            {

                result = data.Where(entity => entity.DateTime.Date <= to.Value.Date).ToList();


            }
            else if (to == null)
            {
                result = data.Where(entity => entity.DateTime.Date >= from.Value.Date).ToList();
            }
            else
            {
                result = data.Where(entity =>
                    entity.DateTime.Date >= from.Value.Date && entity.DateTime.Date <= to.Value.Date
                ).ToList();
            }


            dgHistory.DataSource = result;
        }
    }
}