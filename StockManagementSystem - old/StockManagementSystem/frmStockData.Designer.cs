
namespace StockManagementSystem
{
    partial class frmStockData
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.tabDetail = new DevExpress.XtraTab.XtraTabControl();
            this.tabStockData = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExportStockData = new DevExpress.XtraEditors.SimpleButton();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.gridStockData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ItemCode_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ItemERP_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_PalletNo_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_InventoryQty_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_StockInDate_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_BackLog_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LocationCode_StockData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabInventory = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgERP = new DevExpress.XtraGrid.GridControl();
            this.gvInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_DefaultFilm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColItemcode_b = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TotalQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Backlog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.tabStockData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgERP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetail
            // 
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetail.Location = new System.Drawing.Point(0, 0);
            this.tabDetail.LookAndFeel.SkinName = "Metropolis";
            this.tabDetail.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.tabStockData;
            this.tabDetail.Size = new System.Drawing.Size(1270, 701);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabStockData,
            this.tabInventory});
            this.tabDetail.Selected += new DevExpress.XtraTab.TabPageEventHandler(this.tabDetail_Selected);
            // 
            // tabStockData
            // 
            this.tabStockData.Controls.Add(this.layoutControl2);
            this.tabStockData.Margin = new System.Windows.Forms.Padding(4);
            this.tabStockData.Name = "tabStockData";
            this.tabStockData.Size = new System.Drawing.Size(1268, 665);
            this.tabStockData.Text = "Stock Data Detail";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnExportStockData);
            this.layoutControl2.Controls.Add(this.dgDetail);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1268, 665);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnExportStockData
            // 
            this.btnExportStockData.Enabled = false;
            this.btnExportStockData.Location = new System.Drawing.Point(12, 12);
            this.btnExportStockData.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportStockData.Name = "btnExportStockData";
            this.btnExportStockData.Size = new System.Drawing.Size(1244, 29);
            this.btnExportStockData.StyleController = this.layoutControl2;
            this.btnExportStockData.TabIndex = 4;
            this.btnExportStockData.Text = "Export";
            this.btnExportStockData.Click += new System.EventHandler(this.btnExportStockData_Click);
            // 
            // dgDetail
            // 
            this.dgDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetail.Location = new System.Drawing.Point(12, 45);
            this.dgDetail.MainView = this.gridStockData;
            this.dgDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1244, 608);
            this.dgDetail.TabIndex = 0;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStockData});
            this.dgDetail.Click += new System.EventHandler(this.dgDetail_Click);
            // 
            // gridStockData
            // 
            this.gridStockData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gridStockData.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gridStockData.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridStockData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gridStockData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gridStockData.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gridStockData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridStockData.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridStockData.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridStockData.Appearance.OddRow.Options.UseBackColor = true;
            this.gridStockData.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridStockData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gridStockData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridStockData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ItemCode_StockData,
            this.Col_ItemERP_StockData,
            this.col_PalletNo_StockData,
            this.col_InventoryQty_StockData,
            this.col_StockInDate_StockData,
            this.col_BackLog_StockData,
            this.col_LocationCode_StockData});
            this.gridStockData.DetailHeight = 437;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[BackLog] < 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridStockData.FormatRules.Add(gridFormatRule1);
            this.gridStockData.GridControl = this.dgDetail;
            this.gridStockData.Name = "gridStockData";
            this.gridStockData.OptionsBehavior.Editable = false;
            this.gridStockData.OptionsMenu.ShowFooterItem = true;
            this.gridStockData.OptionsSelection.MultiSelect = true;
            this.gridStockData.OptionsView.EnableAppearanceOddRow = true;
            this.gridStockData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // col_ItemCode_StockData
            // 
            this.col_ItemCode_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ItemCode_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.col_ItemCode_StockData.Caption = "Item";
            this.col_ItemCode_StockData.FieldName = "ItemCode";
            this.col_ItemCode_StockData.MinWidth = 25;
            this.col_ItemCode_StockData.Name = "col_ItemCode_StockData";
            this.col_ItemCode_StockData.Visible = true;
            this.col_ItemCode_StockData.VisibleIndex = 0;
            this.col_ItemCode_StockData.Width = 94;
            // 
            // Col_ItemERP_StockData
            // 
            this.Col_ItemERP_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_ItemERP_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.Col_ItemERP_StockData.Caption = "ItemERP";
            this.Col_ItemERP_StockData.FieldName = "ItemCodeERP";
            this.Col_ItemERP_StockData.MinWidth = 25;
            this.Col_ItemERP_StockData.Name = "Col_ItemERP_StockData";
            this.Col_ItemERP_StockData.Width = 94;
            // 
            // col_PalletNo_StockData
            // 
            this.col_PalletNo_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_PalletNo_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.col_PalletNo_StockData.Caption = "Pallet No";
            this.col_PalletNo_StockData.FieldName = "PalletNo";
            this.col_PalletNo_StockData.MinWidth = 25;
            this.col_PalletNo_StockData.Name = "col_PalletNo_StockData";
            this.col_PalletNo_StockData.Visible = true;
            this.col_PalletNo_StockData.VisibleIndex = 1;
            this.col_PalletNo_StockData.Width = 94;
            // 
            // col_InventoryQty_StockData
            // 
            this.col_InventoryQty_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_InventoryQty_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.col_InventoryQty_StockData.Caption = "Current Stock";
            this.col_InventoryQty_StockData.FieldName = "InventoryQuantity";
            this.col_InventoryQty_StockData.MinWidth = 25;
            this.col_InventoryQty_StockData.Name = "col_InventoryQty_StockData";
            this.col_InventoryQty_StockData.Visible = true;
            this.col_InventoryQty_StockData.VisibleIndex = 3;
            this.col_InventoryQty_StockData.Width = 94;
            // 
            // col_StockInDate_StockData
            // 
            this.col_StockInDate_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_StockInDate_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.col_StockInDate_StockData.Caption = "Lastest Stock In Date";
            this.col_StockInDate_StockData.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.col_StockInDate_StockData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_StockInDate_StockData.FieldName = "StockInDate";
            this.col_StockInDate_StockData.MinWidth = 25;
            this.col_StockInDate_StockData.Name = "col_StockInDate_StockData";
            this.col_StockInDate_StockData.Visible = true;
            this.col_StockInDate_StockData.VisibleIndex = 4;
            this.col_StockInDate_StockData.Width = 94;
            // 
            // col_BackLog_StockData
            // 
            this.col_BackLog_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_BackLog_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.col_BackLog_StockData.Caption = "Backlog";
            this.col_BackLog_StockData.FieldName = "BackLog";
            this.col_BackLog_StockData.MinWidth = 25;
            this.col_BackLog_StockData.Name = "col_BackLog_StockData";
            this.col_BackLog_StockData.Width = 94;
            // 
            // col_LocationCode_StockData
            // 
            this.col_LocationCode_StockData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_LocationCode_StockData.AppearanceHeader.Options.UseBackColor = true;
            this.col_LocationCode_StockData.Caption = "LocationCode";
            this.col_LocationCode_StockData.FieldName = "LocationCode";
            this.col_LocationCode_StockData.MinWidth = 25;
            this.col_LocationCode_StockData.Name = "col_LocationCode_StockData";
            this.col_LocationCode_StockData.Visible = true;
            this.col_LocationCode_StockData.VisibleIndex = 2;
            this.col_LocationCode_StockData.Width = 94;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1268, 665);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnExportStockData;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1248, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dgDetail;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1248, 612);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.splitContainerControl1);
            this.tabInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(1268, 665);
            this.tabInventory.Text = "Stock Data Summarize";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dgERP);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1268, 665);
            this.splitContainerControl1.SplitterPosition = 47;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExport);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1268, 47);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(12, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(1244, 29);
            this.btnExport.StyleController = this.layoutControl1;
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1268, 53);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExport;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1248, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dgERP
            // 
            this.dgERP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgERP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgERP.Location = new System.Drawing.Point(0, 0);
            this.dgERP.MainView = this.gvInventory;
            this.dgERP.Margin = new System.Windows.Forms.Padding(4);
            this.dgERP.Name = "dgERP";
            this.dgERP.Size = new System.Drawing.Size(1268, 612);
            this.dgERP.TabIndex = 0;
            this.dgERP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInventory});
            this.dgERP.Click += new System.EventHandler(this.dgERP_Click);
            // 
            // gvInventory
            // 
            this.gvInventory.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvInventory.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvInventory.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvInventory.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvInventory.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvInventory.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvInventory.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInventory.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvInventory.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvInventory.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInventory.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvInventory.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvInventory.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_DefaultFilm,
            this.ColItemcode_b,
            this.Col_TotalQty,
            this.col_Backlog});
            this.gvInventory.DetailHeight = 437;
            this.gvInventory.GridControl = this.dgERP;
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.OptionsSelection.MultiSelect = true;
            this.gvInventory.OptionsView.EnableAppearanceOddRow = true;
            this.gvInventory.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvInventory_CustomDrawRowIndicator);
            // 
            // col_DefaultFilm
            // 
            this.col_DefaultFilm.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_DefaultFilm.AppearanceHeader.Options.UseBackColor = true;
            this.col_DefaultFilm.Caption = "Default Film";
            this.col_DefaultFilm.FieldName = "Film";
            this.col_DefaultFilm.MinWidth = 25;
            this.col_DefaultFilm.Name = "col_DefaultFilm";
            this.col_DefaultFilm.Visible = true;
            this.col_DefaultFilm.VisibleIndex = 2;
            this.col_DefaultFilm.Width = 320;
            // 
            // ColItemcode_b
            // 
            this.ColItemcode_b.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColItemcode_b.AppearanceHeader.Options.UseBackColor = true;
            this.ColItemcode_b.Caption = "ItemCode";
            this.ColItemcode_b.FieldName = "ItemCode";
            this.ColItemcode_b.MinWidth = 25;
            this.ColItemcode_b.Name = "ColItemcode_b";
            this.ColItemcode_b.Visible = true;
            this.ColItemcode_b.VisibleIndex = 0;
            this.ColItemcode_b.Width = 307;
            // 
            // Col_TotalQty
            // 
            this.Col_TotalQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_TotalQty.AppearanceHeader.Options.UseBackColor = true;
            this.Col_TotalQty.Caption = "TotalQty";
            this.Col_TotalQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Col_TotalQty.FieldName = "InventoryQuantity";
            this.Col_TotalQty.MinWidth = 25;
            this.Col_TotalQty.Name = "Col_TotalQty";
            this.Col_TotalQty.Visible = true;
            this.Col_TotalQty.VisibleIndex = 1;
            this.Col_TotalQty.Width = 342;
            // 
            // col_Backlog
            // 
            this.col_Backlog.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_Backlog.AppearanceHeader.Options.UseBackColor = true;
            this.col_Backlog.Caption = "BackLog";
            this.col_Backlog.FieldName = "BackLog";
            this.col_Backlog.MinWidth = 25;
            this.col_Backlog.Name = "col_Backlog";
            this.col_Backlog.Visible = true;
            this.col_Backlog.VisibleIndex = 3;
            this.col_Backlog.Width = 269;
            // 
            // frmStockData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1270, 701);
            this.Controls.Add(this.tabDetail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockData";
            this.Text = "Stock Data [Dữ Liệu Tồn Kho]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockData_FormClosing);
            this.Load += new System.EventHandler(this.frmStockData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.tabStockData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgERP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage tabStockData;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStockData;
        private DevExpress.XtraTab.XtraTabPage tabInventory;
        private DevExpress.XtraGrid.Columns.GridColumn col_ItemCode_StockData;
        private DevExpress.XtraGrid.Columns.GridColumn col_PalletNo_StockData;
        private DevExpress.XtraGrid.Columns.GridColumn col_InventoryQty_StockData;
        private DevExpress.XtraGrid.Columns.GridColumn col_StockInDate_StockData;
        private DevExpress.XtraGrid.Columns.GridColumn col_BackLog_StockData;
        private DevExpress.XtraGrid.GridControl dgERP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventory;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton btnExportStockData;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ItemERP_StockData;
        private DevExpress.XtraGrid.Columns.GridColumn ColItemcode_b;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TotalQty;
        private DevExpress.XtraGrid.Columns.GridColumn col_Backlog;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn col_DefaultFilm;
        private DevExpress.XtraGrid.Columns.GridColumn col_LocationCode_StockData;
    }
}