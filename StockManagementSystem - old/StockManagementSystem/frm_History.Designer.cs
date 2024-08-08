
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace StockManagementSystem
{
    partial class frm_History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabHistory = new DevExpress.XtraTab.XtraTabControl();
            this.tpStockIn = new DevExpress.XtraTab.XtraTabPage();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockInDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColItemERP_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalletNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpSumarize = new DevExpress.XtraTab.XtraTabPage();
            this.dgERP = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboPIC = new DevExpress.XtraEditors.LookUpEdit();
            this.toDateHistory = new DevExpress.XtraEditors.DateEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.fromDateHistory = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.dgHistory = new DevExpress.XtraGrid.GridControl();
            this.gvHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColWorkingdate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPic_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColItem_History = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPalletno_History = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLocation_History = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColQty_History = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAfterQty_History = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDateTime_History = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabHistory)).BeginInit();
            this.tabHistory.SuspendLayout();
            this.tpStockIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tpSumarize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgERP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateHistory.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateHistory.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHistory
            // 
            this.tabHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHistory.Location = new System.Drawing.Point(17, 185);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.SelectedTabPage = this.tpStockIn;
            this.tabHistory.Size = new System.Drawing.Size(1378, 702);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpStockIn,
            this.tpSumarize});
            // 
            // tpStockIn
            // 
            this.tpStockIn.Controls.Add(this.dgDetail);
            this.tpStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpStockIn.Name = "tpStockIn";
            this.tpStockIn.Size = new System.Drawing.Size(1375, 666);
            this.tpStockIn.Text = "Stock In Detail";
            // 
            // dgDetail
            // 
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.MainView = this.gridView1;
            this.dgDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1375, 666);
            this.dgDetail.TabIndex = 0;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockInDate,
            this.colItemCode,
            this.ColItemERP_a,
            this.colLocation,
            this.colPalletNo,
            this.colQuantity,
            this.colUpdateTime,
            this.colActionID});
            this.gridView1.DetailHeight = 481;
            this.gridView1.GridControl = this.dgDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // colStockInDate
            // 
            this.colStockInDate.Caption = "Stock In Date";
            this.colStockInDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colStockInDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colStockInDate.FieldName = "StockInDate";
            this.colStockInDate.MinWidth = 27;
            this.colStockInDate.Name = "colStockInDate";
            this.colStockInDate.Visible = true;
            this.colStockInDate.VisibleIndex = 0;
            this.colStockInDate.Width = 103;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Item";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.MinWidth = 27;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 103;
            // 
            // ColItemERP_a
            // 
            this.ColItemERP_a.Caption = "ItemERP";
            this.ColItemERP_a.FieldName = "ItemCodeERP";
            this.ColItemERP_a.MinWidth = 27;
            this.ColItemERP_a.Name = "ColItemERP_a";
            this.ColItemERP_a.Width = 103;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Location";
            this.colLocation.FieldName = "LocationCode";
            this.colLocation.MinWidth = 27;
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 2;
            this.colLocation.Width = 103;
            // 
            // colPalletNo
            // 
            this.colPalletNo.Caption = "Stock Pallet No";
            this.colPalletNo.FieldName = "PalletNo";
            this.colPalletNo.MinWidth = 27;
            this.colPalletNo.Name = "colPalletNo";
            this.colPalletNo.Visible = true;
            this.colPalletNo.VisibleIndex = 3;
            this.colPalletNo.Width = 103;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 27;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 103;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.Caption = "Update Time";
            this.colUpdateTime.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colUpdateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colUpdateTime.FieldName = "UpdateTime";
            this.colUpdateTime.MinWidth = 27;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Visible = true;
            this.colUpdateTime.VisibleIndex = 5;
            this.colUpdateTime.Width = 103;
            // 
            // colActionID
            // 
            this.colActionID.Caption = "ActionID";
            this.colActionID.FieldName = "ActionID";
            this.colActionID.MinWidth = 27;
            this.colActionID.Name = "colActionID";
            this.colActionID.Width = 103;
            // 
            // tpSumarize
            // 
            this.tpSumarize.Controls.Add(this.dgERP);
            this.tpSumarize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSumarize.Name = "tpSumarize";
            this.tpSumarize.Size = new System.Drawing.Size(1613, 666);
            this.tpSumarize.Text = "Stock In Sumarize";
            // 
            // dgERP
            // 
            this.dgERP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgERP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgERP.Location = new System.Drawing.Point(0, 0);
            this.dgERP.MainView = this.gridView2;
            this.dgERP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgERP.Name = "dgERP";
            this.dgERP.Size = new System.Drawing.Size(1613, 666);
            this.dgERP.TabIndex = 0;
            this.dgERP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 481;
            this.gridView2.GridControl = this.dgERP;
            this.gridView2.Name = "gridView2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1411, 902);
            this.splitContainerControl1.SplitterPosition = 54;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboPIC);
            this.layoutControl1.Controls.Add(this.toDateHistory);
            this.layoutControl1.Controls.Add(this.btnExport);
            this.layoutControl1.Controls.Add(this.fromDateHistory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1411, 54);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboPIC
            // 
            this.cboPIC.Location = new System.Drawing.Point(416, 13);
            this.cboPIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPIC.Name = "cboPIC";
            this.cboPIC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPIC.Size = new System.Drawing.Size(165, 28);
            this.cboPIC.StyleController = this.layoutControl1;
            this.cboPIC.TabIndex = 15;
            this.cboPIC.Visible = false;
            this.cboPIC.EditValueChanged += new System.EventHandler(this.cboPIC_EditValueChanged);
            // 
            // toDateHistory
            // 
            this.toDateHistory.EditValue = null;
            this.toDateHistory.Location = new System.Drawing.Point(257, 13);
            this.toDateHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toDateHistory.Name = "toDateHistory";
            this.toDateHistory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateHistory.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateHistory.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.toDateHistory.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.toDateHistory.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.toDateHistory.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.toDateHistory.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.toDateHistory.Size = new System.Drawing.Size(71, 28);
            this.toDateHistory.StyleController = this.layoutControl1;
            this.toDateHistory.TabIndex = 13;
            this.toDateHistory.Visible = false;
            this.toDateHistory.EditValueChanged += new System.EventHandler(this.toDateHistory_EditValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(585, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(812, 27);
            this.btnExport.StyleController = this.layoutControl1;
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // fromDateHistory
            // 
            this.fromDateHistory.EditValue = null;
            this.fromDateHistory.Location = new System.Drawing.Point(98, 13);
            this.fromDateHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromDateHistory.Name = "fromDateHistory";
            this.fromDateHistory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateHistory.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateHistory.Properties.EditFormat.FormatString = "";
            this.fromDateHistory.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fromDateHistory.Size = new System.Drawing.Size(71, 28);
            this.fromDateHistory.StyleController = this.layoutControl1;
            this.fromDateHistory.TabIndex = 4;
            this.fromDateHistory.EditValueChanged += new System.EventHandler(this.fromDateHistory_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FromDate,
            this.ToDate,
            this.layoutControlItem4,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1411, 54);
            this.Root.TextVisible = false;
            // 
            // FromDate
            // 
            this.FromDate.Control = this.fromDateHistory;
            this.FromDate.Location = new System.Drawing.Point(0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(159, 32);
            this.FromDate.TextSize = new System.Drawing.Size(79, 22);
            // 
            // ToDate
            // 
            this.ToDate.Control = this.toDateHistory;
            this.ToDate.Location = new System.Drawing.Point(159, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(159, 32);
            this.ToDate.TextSize = new System.Drawing.Size(79, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboPIC;
            this.layoutControlItem4.Location = new System.Drawing.Point(318, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(253, 32);
            this.layoutControlItem4.Text = "PIC";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 22);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnExport;
            this.layoutControlItem9.Location = new System.Drawing.Point(571, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(816, 32);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1411, 842);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.dgHistory);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1408, 806);
            this.xtraTabPage1.Text = "History";
            // 
            // dgHistory
            // 
            this.dgHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgHistory.Location = new System.Drawing.Point(0, 0);
            this.dgHistory.MainView = this.gvHistory;
            this.dgHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.Size = new System.Drawing.Size(1408, 806);
            this.dgHistory.TabIndex = 0;
            this.dgHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistory,
            this.gridView5});
            // 
            // gvHistory
            // 
            this.gvHistory.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvHistory.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvHistory.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHistory.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvHistory.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvHistory.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvHistory.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvHistory.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvHistory.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvHistory.Appearance.OddRow.Options.UseBackColor = true;
            this.gvHistory.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvHistory.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvHistory.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColWorkingdate2,
            this.ColPic_a,
            this.ColItem_History,
            this.ColPalletno_History,
            this.ColLocation_History,
            this.ColQty_History,
            this.ColAfterQty_History,
            this.ColDateTime_History,
            this.gridColumn8});
            this.gvHistory.DetailHeight = 481;
            this.gvHistory.GridControl = this.dgHistory;
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.OptionsBehavior.Editable = false;
            this.gvHistory.OptionsSelection.MultiSelect = true;
            this.gvHistory.OptionsView.EnableAppearanceOddRow = true;
            this.gvHistory.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColDateTime_History, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // ColWorkingdate2
            // 
            this.ColWorkingdate2.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColWorkingdate2.AppearanceHeader.Options.UseBackColor = true;
            this.ColWorkingdate2.Caption = "Working Type";
            this.ColWorkingdate2.FieldName = "Workingdate2";
            this.ColWorkingdate2.MinWidth = 27;
            this.ColWorkingdate2.Name = "ColWorkingdate2";
            this.ColWorkingdate2.Visible = true;
            this.ColWorkingdate2.VisibleIndex = 0;
            this.ColWorkingdate2.Width = 189;
            // 
            // ColPic_a
            // 
            this.ColPic_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColPic_a.AppearanceHeader.Options.UseBackColor = true;
            this.ColPic_a.Caption = "PIC";
            this.ColPic_a.FieldName = "Pic";
            this.ColPic_a.MinWidth = 27;
            this.ColPic_a.Name = "ColPic_a";
            this.ColPic_a.Visible = true;
            this.ColPic_a.VisibleIndex = 1;
            this.ColPic_a.Width = 189;
            // 
            // ColItem_History
            // 
            this.ColItem_History.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColItem_History.AppearanceHeader.Options.UseBackColor = true;
            this.ColItem_History.Caption = "Item";
            this.ColItem_History.FieldName = "Item";
            this.ColItem_History.MinWidth = 27;
            this.ColItem_History.Name = "ColItem_History";
            this.ColItem_History.Visible = true;
            this.ColItem_History.VisibleIndex = 2;
            this.ColItem_History.Width = 189;
            // 
            // ColPalletno_History
            // 
            this.ColPalletno_History.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColPalletno_History.AppearanceHeader.Options.UseBackColor = true;
            this.ColPalletno_History.Caption = "StockPallet / ShippingPallet";
            this.ColPalletno_History.FieldName = "Palletno";
            this.ColPalletno_History.MinWidth = 27;
            this.ColPalletno_History.Name = "ColPalletno_History";
            this.ColPalletno_History.Visible = true;
            this.ColPalletno_History.VisibleIndex = 3;
            this.ColPalletno_History.Width = 252;
            // 
            // ColLocation_History
            // 
            this.ColLocation_History.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColLocation_History.AppearanceHeader.Options.UseBackColor = true;
            this.ColLocation_History.Caption = "Location / LoadingTime";
            this.ColLocation_History.FieldName = "Location";
            this.ColLocation_History.MinWidth = 27;
            this.ColLocation_History.Name = "ColLocation_History";
            this.ColLocation_History.Visible = true;
            this.ColLocation_History.VisibleIndex = 4;
            this.ColLocation_History.Width = 244;
            // 
            // ColQty_History
            // 
            this.ColQty_History.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColQty_History.AppearanceHeader.Options.UseBackColor = true;
            this.ColQty_History.Caption = "Qty";
            this.ColQty_History.FieldName = "Qty";
            this.ColQty_History.MinWidth = 27;
            this.ColQty_History.Name = "ColQty_History";
            this.ColQty_History.Visible = true;
            this.ColQty_History.VisibleIndex = 5;
            this.ColQty_History.Width = 127;
            // 
            // ColAfterQty_History
            // 
            this.ColAfterQty_History.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColAfterQty_History.AppearanceHeader.Options.UseBackColor = true;
            this.ColAfterQty_History.Caption = "AfterQty";
            this.ColAfterQty_History.FieldName = "AfterQty";
            this.ColAfterQty_History.MinWidth = 27;
            this.ColAfterQty_History.Name = "ColAfterQty_History";
            this.ColAfterQty_History.Visible = true;
            this.ColAfterQty_History.VisibleIndex = 6;
            this.ColAfterQty_History.Width = 120;
            // 
            // ColDateTime_History
            // 
            this.ColDateTime_History.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColDateTime_History.AppearanceHeader.Options.UseBackColor = true;
            this.ColDateTime_History.Caption = "DateTime";
            this.ColDateTime_History.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ColDateTime_History.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColDateTime_History.FieldName = "DateTime";
            this.ColDateTime_History.MinWidth = 27;
            this.ColDateTime_History.Name = "ColDateTime_History";
            this.ColDateTime_History.Visible = true;
            this.ColDateTime_History.VisibleIndex = 7;
            this.ColDateTime_History.Width = 207;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridColumn8.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn8.Caption = "ActionID";
            this.gridColumn8.FieldName = "ActionID";
            this.gridColumn8.MinWidth = 27;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 103;
            // 
            // gridView5
            // 
            this.gridView5.DetailHeight = 481;
            this.gridView5.GridControl = this.dgHistory;
            this.gridView5.Name = "gridView5";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // frm_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 902);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.tabHistory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_History";
            this.Text = "History [Lịch sử]";
            this.Load += new System.EventHandler(this.frm_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabHistory)).EndInit();
            this.tabHistory.ResumeLayout(false);
            this.tpStockIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tpSumarize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgERP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboPIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateHistory.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateHistory.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabHistory_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabHistory;
        private DevExpress.XtraTab.XtraTabPage tpStockIn;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockInDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn ColItemERP_a;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colPalletNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colActionID;
        private DevExpress.XtraTab.XtraTabPage tpSumarize;
        private DevExpress.XtraGrid.GridControl dgERP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit toDateHistory;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.DateEdit fromDateHistory;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem FromDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem ToDate;
        private DevExpress.XtraEditors.LookUpEdit cboPIC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl dgHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistory;
        private DevExpress.XtraGrid.Columns.GridColumn ColWorkingdate2;
        private DevExpress.XtraGrid.Columns.GridColumn ColPic_a;
        private DevExpress.XtraGrid.Columns.GridColumn ColItem_History;
        private DevExpress.XtraGrid.Columns.GridColumn ColPalletno_History;
        private DevExpress.XtraGrid.Columns.GridColumn ColLocation_History;
        private DevExpress.XtraGrid.Columns.GridColumn ColQty_History;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn ColAfterQty_History;
        private DevExpress.XtraGrid.Columns.GridColumn ColDateTime_History;
    }
}