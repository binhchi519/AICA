
namespace StockManagementSystem
{
    partial class frmStocktake
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabDetail = new DevExpress.XtraTab.XtraTabControl();
            this.tpStockIn = new DevExpress.XtraTab.XtraTabPage();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIDStocktake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActionname_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalletNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualQty_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisChecked_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIIncludedTime_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEnough = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColItemERP_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpSumarize = new DevExpress.XtraTab.XtraTabPage();
            this.dgERP = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ItemCodeERP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ERPData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Differrence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpSTHistory = new DevExpress.XtraTab.XtraTabPage();
            this.dgHistory = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ERPItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_InventoryQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ERPQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Difference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_UpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.tpStockIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tpSumarize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgERP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tpSTHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tabDetail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1256, 713);
            this.splitContainerControl1.SplitterPosition = 48;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExport);
            this.layoutControl1.Controls.Add(this.btnImport);
            this.layoutControl1.Controls.Add(this.btnEnd);
            this.layoutControl1.Controls.Add(this.btnStart);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1256, 48);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(927, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(302, 23);
            this.btnExport.StyleController = this.layoutControl1;
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Location = new System.Drawing.Point(622, 11);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(301, 23);
            this.btnImport.StyleController = this.layoutControl1;
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Appearance.Options.UseFont = true;
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(316, 11);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(302, 23);
            this.btnEnd.StyleController = this.layoutControl1;
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "Close StockTake";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Location = new System.Drawing.Point(10, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(302, 23);
            this.btnStart.StyleController = this.layoutControl1;
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start StockTake";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1239, 55);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 27);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1223, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnStart;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(306, 27);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnEnd;
            this.layoutControlItem9.Location = new System.Drawing.Point(306, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(306, 27);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnImport;
            this.layoutControlItem2.Location = new System.Drawing.Point(612, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(305, 27);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnExport;
            this.layoutControlItem1.Location = new System.Drawing.Point(917, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(306, 27);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tabDetail
            // 
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetail.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabDetail.Location = new System.Drawing.Point(0, 0);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.tpStockIn;
            this.tabDetail.Size = new System.Drawing.Size(1256, 660);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpStockIn,
            this.tpSumarize,
            this.tpSTHistory});
            this.tabDetail.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabDetail_SelectedPageChanged);
            // 
            // tpStockIn
            // 
            this.tpStockIn.Controls.Add(this.dgDetail);
            this.tpStockIn.Name = "tpStockIn";
            this.tpStockIn.Size = new System.Drawing.Size(1253, 629);
            this.tpStockIn.Text = "Stock Take Detail";
            // 
            // dgDetail
            // 
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.MainView = this.gridView1;
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1253, 629);
            this.dgDetail.TabIndex = 0;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIDStocktake,
            this.ColActionname_a,
            this.colItemCode,
            this.colPalletNo,
            this.colLocation,
            this.colQuantity,
            this.colActualQty_a,
            this.colisChecked_a,
            this.colIIncludedTime_a,
            this.colIsEnough,
            this.ColItemERP_a,
            this.colActionID});
            this.gridView1.DetailHeight = 415;
            this.gridView1.GridControl = this.dgDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridView1_CustomRowFilter);
            // 
            // ColIDStocktake
            // 
            this.ColIDStocktake.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColIDStocktake.AppearanceHeader.Options.UseBackColor = true;
            this.ColIDStocktake.Caption = "ID";
            this.ColIDStocktake.FieldName = "Actionid";
            this.ColIDStocktake.MinWidth = 22;
            this.ColIDStocktake.Name = "ColIDStocktake";
            this.ColIDStocktake.Width = 84;
            // 
            // ColActionname_a
            // 
            this.ColActionname_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColActionname_a.AppearanceHeader.Options.UseBackColor = true;
            this.ColActionname_a.Caption = "Actionname";
            this.ColActionname_a.FieldName = "Actionname";
            this.ColActionname_a.MinWidth = 22;
            this.ColActionname_a.Name = "ColActionname_a";
            this.ColActionname_a.Width = 84;
            // 
            // colItemCode
            // 
            this.colItemCode.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colItemCode.AppearanceHeader.Options.UseBackColor = true;
            this.colItemCode.Caption = "Item";
            this.colItemCode.FieldName = "Itemcode";
            this.colItemCode.MinWidth = 22;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 84;
            // 
            // colPalletNo
            // 
            this.colPalletNo.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPalletNo.AppearanceHeader.Options.UseBackColor = true;
            this.colPalletNo.Caption = "Stock Pallet No";
            this.colPalletNo.FieldName = "Palletno";
            this.colPalletNo.MinWidth = 22;
            this.colPalletNo.Name = "colPalletNo";
            this.colPalletNo.Visible = true;
            this.colPalletNo.VisibleIndex = 1;
            this.colPalletNo.Width = 84;
            // 
            // colLocation
            // 
            this.colLocation.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colLocation.AppearanceHeader.Options.UseBackColor = true;
            this.colLocation.Caption = "Location";
            this.colLocation.FieldName = "Location";
            this.colLocation.MinWidth = 22;
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 2;
            this.colLocation.Width = 84;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Qty";
            this.colQuantity.MinWidth = 22;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 84;
            // 
            // colActualQty_a
            // 
            this.colActualQty_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colActualQty_a.AppearanceHeader.Options.UseBackColor = true;
            this.colActualQty_a.Caption = "ActualQty";
            this.colActualQty_a.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colActualQty_a.FieldName = "Actualqty";
            this.colActualQty_a.MinWidth = 22;
            this.colActualQty_a.Name = "colActualQty_a";
            this.colActualQty_a.Visible = true;
            this.colActualQty_a.VisibleIndex = 4;
            this.colActualQty_a.Width = 84;
            // 
            // colisChecked_a
            // 
            this.colisChecked_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colisChecked_a.AppearanceHeader.Options.UseBackColor = true;
            this.colisChecked_a.Caption = "Checked";
            this.colisChecked_a.FieldName = "IsCheck";
            this.colisChecked_a.MinWidth = 22;
            this.colisChecked_a.Name = "colisChecked_a";
            this.colisChecked_a.Visible = true;
            this.colisChecked_a.VisibleIndex = 5;
            this.colisChecked_a.Width = 84;
            // 
            // colIIncludedTime_a
            // 
            this.colIIncludedTime_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colIIncludedTime_a.AppearanceHeader.Options.UseBackColor = true;
            this.colIIncludedTime_a.Caption = "Created Time";
            this.colIIncludedTime_a.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colIIncludedTime_a.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIIncludedTime_a.FieldName = "IncludedTime";
            this.colIIncludedTime_a.MinWidth = 22;
            this.colIIncludedTime_a.Name = "colIIncludedTime_a";
            this.colIIncludedTime_a.Visible = true;
            this.colIIncludedTime_a.VisibleIndex = 6;
            this.colIIncludedTime_a.Width = 84;
            // 
            // colIsEnough
            // 
            this.colIsEnough.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colIsEnough.AppearanceHeader.Options.UseBackColor = true;
            this.colIsEnough.Caption = "Enough";
            this.colIsEnough.FieldName = "Enough";
            this.colIsEnough.MinWidth = 22;
            this.colIsEnough.Name = "colIsEnough";
            this.colIsEnough.Visible = true;
            this.colIsEnough.VisibleIndex = 7;
            this.colIsEnough.Width = 84;
            // 
            // ColItemERP_a
            // 
            this.ColItemERP_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColItemERP_a.AppearanceHeader.Options.UseBackColor = true;
            this.ColItemERP_a.Caption = "ItemERP";
            this.ColItemERP_a.FieldName = "ItemCodeERP";
            this.ColItemERP_a.MinWidth = 22;
            this.ColItemERP_a.Name = "ColItemERP_a";
            this.ColItemERP_a.Width = 84;
            // 
            // colActionID
            // 
            this.colActionID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colActionID.AppearanceHeader.Options.UseBackColor = true;
            this.colActionID.Caption = "ActionID";
            this.colActionID.FieldName = "Actionid";
            this.colActionID.MinWidth = 22;
            this.colActionID.Name = "colActionID";
            this.colActionID.Width = 84;
            // 
            // tpSumarize
            // 
            this.tpSumarize.Controls.Add(this.dgERP);
            this.tpSumarize.Name = "tpSumarize";
            this.tpSumarize.Size = new System.Drawing.Size(1253, 629);
            this.tpSumarize.Text = "Stock Take Summarize";
            // 
            // dgERP
            // 
            this.dgERP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgERP.Location = new System.Drawing.Point(0, 0);
            this.dgERP.MainView = this.gridView2;
            this.dgERP.Name = "dgERP";
            this.dgERP.Size = new System.Drawing.Size(1253, 629);
            this.dgERP.TabIndex = 0;
            this.dgERP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ItemCode,
            this.col_ItemCodeERP,
            this.col_Quantity,
            this.col_ERPData,
            this.col_Differrence});
            this.gridView2.DetailHeight = 415;
            this.gridView2.GridControl = this.dgERP;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            // 
            // col_ItemCode
            // 
            this.col_ItemCode.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ItemCode.AppearanceHeader.Options.UseBackColor = true;
            this.col_ItemCode.Caption = "ItemCode";
            this.col_ItemCode.FieldName = "ItemCode";
            this.col_ItemCode.Name = "col_ItemCode";
            this.col_ItemCode.Visible = true;
            this.col_ItemCode.VisibleIndex = 0;
            this.col_ItemCode.Width = 77;
            // 
            // col_ItemCodeERP
            // 
            this.col_ItemCodeERP.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ItemCodeERP.AppearanceHeader.Options.UseBackColor = true;
            this.col_ItemCodeERP.Caption = "ItemCode ERP";
            this.col_ItemCodeERP.FieldName = "ItemCodeERP";
            this.col_ItemCodeERP.Name = "col_ItemCodeERP";
            this.col_ItemCodeERP.Visible = true;
            this.col_ItemCodeERP.VisibleIndex = 1;
            this.col_ItemCodeERP.Width = 77;
            // 
            // col_Quantity
            // 
            this.col_Quantity.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_Quantity.AppearanceHeader.Options.UseBackColor = true;
            this.col_Quantity.Caption = "Quantity";
            this.col_Quantity.FieldName = "Quantity";
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.Visible = true;
            this.col_Quantity.VisibleIndex = 2;
            this.col_Quantity.Width = 77;
            // 
            // col_ERPData
            // 
            this.col_ERPData.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ERPData.AppearanceHeader.Options.UseBackColor = true;
            this.col_ERPData.Caption = "ERP Quantity";
            this.col_ERPData.FieldName = "ERPData";
            this.col_ERPData.Name = "col_ERPData";
            this.col_ERPData.Visible = true;
            this.col_ERPData.VisibleIndex = 3;
            this.col_ERPData.Width = 77;
            // 
            // col_Differrence
            // 
            this.col_Differrence.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_Differrence.AppearanceHeader.Options.UseBackColor = true;
            this.col_Differrence.Caption = "Differrence";
            this.col_Differrence.FieldName = "Differrence";
            this.col_Differrence.Name = "col_Differrence";
            this.col_Differrence.Visible = true;
            this.col_Differrence.VisibleIndex = 4;
            this.col_Differrence.Width = 77;
            // 
            // tpSTHistory
            // 
            this.tpSTHistory.Controls.Add(this.dgHistory);
            this.tpSTHistory.Name = "tpSTHistory";
            this.tpSTHistory.Size = new System.Drawing.Size(1253, 629);
            this.tpSTHistory.Text = "Stock Take History";
            this.tpSTHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // dgHistory
            // 
            this.dgHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistory.Location = new System.Drawing.Point(0, 0);
            this.dgHistory.MainView = this.gridView3;
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.Size = new System.Drawing.Size(1253, 629);
            this.dgHistory.TabIndex = 0;
            this.dgHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gridView3.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView3.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ERPItem,
            this.col_InventoryQty,
            this.col_ERPQty,
            this.col_Difference,
            this.col_CreatedDate,
            this.col_UpdateTime});
            this.gridView3.DetailHeight = 415;
            this.gridView3.GridControl = this.dgHistory;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            // 
            // col_ERPItem
            // 
            this.col_ERPItem.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ERPItem.AppearanceHeader.Options.UseBackColor = true;
            this.col_ERPItem.Caption = "ERP Itemcode";
            this.col_ERPItem.FieldName = "ERPItemcode";
            this.col_ERPItem.Name = "col_ERPItem";
            this.col_ERPItem.Visible = true;
            this.col_ERPItem.VisibleIndex = 0;
            this.col_ERPItem.Width = 77;
            // 
            // col_InventoryQty
            // 
            this.col_InventoryQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_InventoryQty.AppearanceHeader.Options.UseBackColor = true;
            this.col_InventoryQty.Caption = "Inventory Qty";
            this.col_InventoryQty.FieldName = "InventoryQty";
            this.col_InventoryQty.Name = "col_InventoryQty";
            this.col_InventoryQty.Visible = true;
            this.col_InventoryQty.VisibleIndex = 1;
            this.col_InventoryQty.Width = 77;
            // 
            // col_ERPQty
            // 
            this.col_ERPQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ERPQty.AppearanceHeader.Options.UseBackColor = true;
            this.col_ERPQty.Caption = "ERP Qty";
            this.col_ERPQty.FieldName = "ERPQty";
            this.col_ERPQty.Name = "col_ERPQty";
            this.col_ERPQty.Visible = true;
            this.col_ERPQty.VisibleIndex = 2;
            this.col_ERPQty.Width = 77;
            // 
            // col_Difference
            // 
            this.col_Difference.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_Difference.AppearanceHeader.Options.UseBackColor = true;
            this.col_Difference.Caption = "Difference";
            this.col_Difference.FieldName = "Difference";
            this.col_Difference.Name = "col_Difference";
            this.col_Difference.Visible = true;
            this.col_Difference.VisibleIndex = 3;
            this.col_Difference.Width = 77;
            // 
            // col_CreatedDate
            // 
            this.col_CreatedDate.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_CreatedDate.AppearanceHeader.Options.UseBackColor = true;
            this.col_CreatedDate.Caption = "Created Date";
            this.col_CreatedDate.FieldName = "CreatedDate";
            this.col_CreatedDate.Name = "col_CreatedDate";
            this.col_CreatedDate.Visible = true;
            this.col_CreatedDate.VisibleIndex = 4;
            this.col_CreatedDate.Width = 77;
            // 
            // col_UpdateTime
            // 
            this.col_UpdateTime.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_UpdateTime.AppearanceHeader.Options.UseBackColor = true;
            this.col_UpdateTime.Caption = "Update Time";
            this.col_UpdateTime.FieldName = "UpdateTime";
            this.col_UpdateTime.Name = "col_UpdateTime";
            this.col_UpdateTime.Visible = true;
            this.col_UpdateTime.VisibleIndex = 5;
            this.col_UpdateTime.Width = 77;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(337, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 31);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmStocktake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 713);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmStocktake";
            this.Text = "Stocktake [Kiểm Kho]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStocktake_FormClosing);
            this.Load += new System.EventHandler(this.frmStocktake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.tpStockIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tpSumarize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgERP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tpSTHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraTab.XtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage tpStockIn;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColIDStocktake;
        private DevExpress.XtraGrid.Columns.GridColumn ColActionname_a;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPalletNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colActualQty_a;
        private DevExpress.XtraGrid.Columns.GridColumn colisChecked_a;
        private DevExpress.XtraGrid.Columns.GridColumn colIIncludedTime_a;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEnough;
        private DevExpress.XtraGrid.Columns.GridColumn ColItemERP_a;
        private DevExpress.XtraGrid.Columns.GridColumn colActionID;
        private DevExpress.XtraTab.XtraTabPage tpSumarize;
        private DevExpress.XtraGrid.GridControl dgERP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage tpSTHistory;
        private DevExpress.XtraGrid.GridControl dgHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn col_ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_ItemCodeERP;
        private DevExpress.XtraGrid.Columns.GridColumn col_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn col_ERPData;
        private DevExpress.XtraGrid.Columns.GridColumn col_Differrence;
        private DevExpress.XtraGrid.Columns.GridColumn col_ERPItem;
        private DevExpress.XtraGrid.Columns.GridColumn col_InventoryQty;
        private DevExpress.XtraGrid.Columns.GridColumn col_ERPQty;
        private DevExpress.XtraGrid.Columns.GridColumn col_Difference;
        private DevExpress.XtraGrid.Columns.GridColumn col_CreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn col_UpdateTime;
    }
}