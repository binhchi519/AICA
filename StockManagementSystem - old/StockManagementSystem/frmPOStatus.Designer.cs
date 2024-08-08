
namespace StockManagementSystem
{
    partial class frmPOStatus
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnHeightCounter = new DevExpress.XtraEditors.SimpleButton();
            this.btnCounter = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturnsPacking = new DevExpress.XtraEditors.SimpleButton();
            this.cboPrinterName = new System.Windows.Forms.ComboBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPackingListIssue = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateLoadingDate = new DevExpress.XtraEditors.SimpleButton();
            this.btnPickListUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnPickingList_Issue = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateShippingPallet = new DevExpress.XtraEditors.SimpleButton();
            this.cboETD = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabDetail = new DevExpress.XtraTab.XtraTabControl();
            this.tabPOStatus = new DevExpress.XtraTab.XtraTabPage();
            this.dgPOStatus = new DevExpress.XtraGrid.GridControl();
            this.gvPOStatus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_poNo_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Podate_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_customer_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Item_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Film_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Po_Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_PStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Picking_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Masking_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Packing_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_AllStock_a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Backlog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_PackStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ShipOutted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabItemList = new DevExpress.XtraTab.XtraTabPage();
            this.dgShippingList = new DevExpress.XtraGrid.GridControl();
            this.gvShippingList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPODate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPONo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColShippingQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualThickness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AvailableQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_OldDateExisted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPackingList = new DevExpress.XtraTab.XtraTabPage();
            this.dgPackingList = new DevExpress.XtraGrid.GridControl();
            this.gvPackingList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPODates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPONos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCodes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlims = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipPalletNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoadingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipoutDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPODeatailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_packingStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPickingList = new DevExpress.XtraTab.XtraTabPage();
            this.dgPickingList = new DevExpress.XtraGrid.GridControl();
            this.gvPickingList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColPickID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ItemCodE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_LocatioN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Film = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_StockQtY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_QtytoPick = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_OutStanding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_CustomeR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ShippingPalletNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ETDs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_POPrioritY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_FilmInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LoadingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboETD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboETD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.tabPOStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPOStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOStatus)).BeginInit();
            this.tabItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShippingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShippingList)).BeginInit();
            this.tabPackingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackingList)).BeginInit();
            this.tabPickingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPickingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPickingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // colID
            // 
            this.colID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colID.AppearanceHeader.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.colID.AppearanceHeader.Options.UseBackColor = true;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AutoSize = true;
            this.layoutControl1.Controls.Add(this.btnHeightCounter);
            this.layoutControl1.Controls.Add(this.btnCounter);
            this.layoutControl1.Controls.Add(this.btnExport);
            this.layoutControl1.Controls.Add(this.btnReturnsPacking);
            this.layoutControl1.Controls.Add(this.cboPrinterName);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnPackingListIssue);
            this.layoutControl1.Controls.Add(this.btnUpdateLoadingDate);
            this.layoutControl1.Controls.Add(this.btnPickListUpdate);
            this.layoutControl1.Controls.Add(this.btnPickingList_Issue);
            this.layoutControl1.Controls.Add(this.btnUpdateShippingPallet);
            this.layoutControl1.Controls.Add(this.cboETD);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1132, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1084, 101);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnHeightCounter
            // 
            this.btnHeightCounter.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeightCounter.Appearance.Options.UseFont = true;
            this.btnHeightCounter.Location = new System.Drawing.Point(864, 69);
            this.btnHeightCounter.Name = "btnHeightCounter";
            this.btnHeightCounter.Size = new System.Drawing.Size(208, 20);
            this.btnHeightCounter.StyleController = this.layoutControl1;
            this.btnHeightCounter.TabIndex = 12;
            // 
            // btnCounter
            // 
            this.btnCounter.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounter.Appearance.Options.UseFont = true;
            this.btnCounter.Location = new System.Drawing.Point(527, 69);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(247, 20);
            this.btnCounter.StyleController = this.layoutControl1;
            this.btnCounter.TabIndex = 11;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(194, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(243, 23);
            this.btnExport.StyleController = this.layoutControl1;
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReturnsPacking
            // 
            this.btnReturnsPacking.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnsPacking.Appearance.Options.UseFont = true;
            this.btnReturnsPacking.Location = new System.Drawing.Point(12, 42);
            this.btnReturnsPacking.Name = "btnReturnsPacking";
            this.btnReturnsPacking.Size = new System.Drawing.Size(178, 23);
            this.btnReturnsPacking.StyleController = this.layoutControl1;
            this.btnReturnsPacking.TabIndex = 8;
            this.btnReturnsPacking.Text = "Returns";
            this.btnReturnsPacking.Click += new System.EventHandler(this.btnReturnsPacking_Click);
            // 
            // cboPrinterName
            // 
            this.cboPrinterName.FormattingEnabled = true;
            this.cboPrinterName.Location = new System.Drawing.Point(739, 12);
            this.cboPrinterName.Name = "cboPrinterName";
            this.cboPrinterName.Size = new System.Drawing.Size(119, 27);
            this.cboPrinterName.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(653, 42);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(205, 23);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print Shipping Label";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnPackingListIssue
            // 
            this.btnPackingListIssue.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackingListIssue.Appearance.Options.UseFont = true;
            this.btnPackingListIssue.Location = new System.Drawing.Point(12, 12);
            this.btnPackingListIssue.Name = "btnPackingListIssue";
            this.btnPackingListIssue.Size = new System.Drawing.Size(178, 23);
            this.btnPackingListIssue.StyleController = this.layoutControl1;
            this.btnPackingListIssue.TabIndex = 4;
            this.btnPackingListIssue.Text = "Packing List Issue";
            this.btnPackingListIssue.Click += new System.EventHandler(this.btnPackingListIssue_Click);
            // 
            // btnUpdateLoadingDate
            // 
            this.btnUpdateLoadingDate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLoadingDate.Appearance.Options.UseFont = true;
            this.btnUpdateLoadingDate.Location = new System.Drawing.Point(441, 42);
            this.btnUpdateLoadingDate.Name = "btnUpdateLoadingDate";
            this.btnUpdateLoadingDate.Size = new System.Drawing.Size(208, 23);
            this.btnUpdateLoadingDate.StyleController = this.layoutControl1;
            this.btnUpdateLoadingDate.TabIndex = 5;
            this.btnUpdateLoadingDate.Text = "Update Loading Day";
            this.btnUpdateLoadingDate.Click += new System.EventHandler(this.btnPackingListUpdate_Click);
            // 
            // btnPickListUpdate
            // 
            this.btnPickListUpdate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickListUpdate.Appearance.Options.UseFont = true;
            this.btnPickListUpdate.Location = new System.Drawing.Point(862, 12);
            this.btnPickListUpdate.Name = "btnPickListUpdate";
            this.btnPickListUpdate.Size = new System.Drawing.Size(210, 23);
            this.btnPickListUpdate.StyleController = this.layoutControl1;
            this.btnPickListUpdate.TabIndex = 7;
            this.btnPickListUpdate.Text = "Picking List Update";
            this.btnPickListUpdate.Click += new System.EventHandler(this.btnPickListUpdate_Click);
            // 
            // btnPickingList_Issue
            // 
            this.btnPickingList_Issue.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickingList_Issue.Appearance.Options.UseFont = true;
            this.btnPickingList_Issue.Location = new System.Drawing.Point(862, 42);
            this.btnPickingList_Issue.Name = "btnPickingList_Issue";
            this.btnPickingList_Issue.Size = new System.Drawing.Size(210, 23);
            this.btnPickingList_Issue.StyleController = this.layoutControl1;
            this.btnPickingList_Issue.TabIndex = 6;
            this.btnPickingList_Issue.Text = "Picking List Issue";
            this.btnPickingList_Issue.Click += new System.EventHandler(this.btnPickingList_Issue_Click);
            // 
            // btnUpdateShippingPallet
            // 
            this.btnUpdateShippingPallet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShippingPallet.Appearance.Options.UseFont = true;
            this.btnUpdateShippingPallet.Location = new System.Drawing.Point(194, 12);
            this.btnUpdateShippingPallet.Name = "btnUpdateShippingPallet";
            this.btnUpdateShippingPallet.Size = new System.Drawing.Size(243, 23);
            this.btnUpdateShippingPallet.StyleController = this.layoutControl1;
            this.btnUpdateShippingPallet.TabIndex = 3;
            this.btnUpdateShippingPallet.Text = "Update PalletNo && LoadingTime";
            this.btnUpdateShippingPallet.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cboETD
            // 
            this.cboETD.EditValue = null;
            this.cboETD.Location = new System.Drawing.Point(527, 12);
            this.cboETD.Name = "cboETD";
            this.cboETD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboETD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboETD.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cboETD.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cboETD.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cboETD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cboETD.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.cboETD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cboETD.Properties.Mask.EditMask = "";
            this.cboETD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cboETD.Properties.NullDate = new System.DateTime(2023, 6, 7, 17, 17, 12, 0);
            this.cboETD.Size = new System.Drawing.Size(122, 26);
            this.cboETD.StyleController = this.layoutControl1;
            this.cboETD.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(12, 69);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(425, 20);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 13;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem11,
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem13});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1084, 101);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnPickingList_Issue;
            this.layoutControlItem6.Location = new System.Drawing.Point(850, 30);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(214, 27);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.cboPrinterName;
            this.layoutControlItem12.Location = new System.Drawing.Point(641, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(209, 30);
            this.layoutControlItem12.Text = "Printer";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(82, 19);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnUpdateLoadingDate;
            this.layoutControlItem8.Location = new System.Drawing.Point(429, 30);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(212, 27);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.cboETD;
            this.layoutControlItem11.Location = new System.Drawing.Point(429, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(212, 30);
            this.layoutControlItem11.Text = "Loading Date";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(82, 19);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnPackingListIssue;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(182, 30);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnUpdateShippingPallet;
            this.layoutControlItem5.Location = new System.Drawing.Point(182, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(247, 30);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnPickListUpdate;
            this.layoutControlItem7.Location = new System.Drawing.Point(850, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(214, 30);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnReturnsPacking;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(182, 27);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnExport;
            this.layoutControlItem1.Location = new System.Drawing.Point(182, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(247, 27);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnPrint;
            this.layoutControlItem10.Location = new System.Drawing.Point(641, 30);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(209, 27);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCounter;
            this.layoutControlItem3.Location = new System.Drawing.Point(429, 57);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(337, 24);
            this.layoutControlItem3.Text = "Sum Quantity";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnHeightCounter;
            this.layoutControlItem4.Location = new System.Drawing.Point(766, 57);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(298, 24);
            this.layoutControlItem4.Text = "Sum Height";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 19);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.simpleButton1;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 57);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // tabDetail
            // 
            this.tabDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetail.Location = new System.Drawing.Point(0, 109);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.tabPOStatus;
            this.tabDetail.Size = new System.Drawing.Size(1084, 403);
            this.tabDetail.TabIndex = 3;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPOStatus,
            this.tabItemList,
            this.tabPackingList,
            this.tabPickingList});
            this.tabDetail.Selected += new DevExpress.XtraTab.TabPageEventHandler(this.tabDetail_Selected);
            // 
            // tabPOStatus
            // 
            this.tabPOStatus.Controls.Add(this.dgPOStatus);
            this.tabPOStatus.Name = "tabPOStatus";
            this.tabPOStatus.Size = new System.Drawing.Size(1081, 372);
            this.tabPOStatus.Text = "PO Status";
            // 
            // dgPOStatus
            // 
            this.dgPOStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPOStatus.Location = new System.Drawing.Point(0, 0);
            this.dgPOStatus.MainView = this.gvPOStatus;
            this.dgPOStatus.Name = "dgPOStatus";
            this.dgPOStatus.Size = new System.Drawing.Size(1081, 372);
            this.dgPOStatus.TabIndex = 0;
            this.dgPOStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPOStatus});
            // 
            // gvPOStatus
            // 
            this.gvPOStatus.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvPOStatus.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvPOStatus.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPOStatus.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvPOStatus.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvPOStatus.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvPOStatus.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPOStatus.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPOStatus.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvPOStatus.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPOStatus.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvPOStatus.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvPOStatus.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPOStatus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_poNo_a,
            this.Col_Podate_a,
            this.Col_customer_a,
            this.Col_Item_a,
            this.Col_Film_a,
            this.Col_Po_Qty,
            this.Col_PStock,
            this.Col_Picking_a,
            this.Col_Masking_a,
            this.Col_Packing_a,
            this.Col_AllStock_a,
            this.Col_Backlog,
            this.Col_PackStatus,
            this.col_ShipOutted});
            this.gvPOStatus.CustomizationFormBounds = new System.Drawing.Rectangle(1069, 537, 251, 244);
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[POQty] = [ShipOutted]";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvPOStatus.FormatRules.Add(gridFormatRule1);
            this.gvPOStatus.GridControl = this.dgPOStatus;
            this.gvPOStatus.Name = "gvPOStatus";
            this.gvPOStatus.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPOStatus.OptionsSelection.MultiSelect = true;
            this.gvPOStatus.OptionsView.EnableAppearanceOddRow = true;
            this.gvPOStatus.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvPOStatus_CustomDrawRowIndicator);
            // 
            // Col_poNo_a
            // 
            this.Col_poNo_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_poNo_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_poNo_a.Caption = "PO.No";
            this.Col_poNo_a.FieldName = "PONo";
            this.Col_poNo_a.Name = "Col_poNo_a";
            this.Col_poNo_a.Visible = true;
            this.Col_poNo_a.VisibleIndex = 0;
            // 
            // Col_Podate_a
            // 
            this.Col_Podate_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Podate_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Podate_a.Caption = "PO Date";
            this.Col_Podate_a.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Col_Podate_a.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Col_Podate_a.FieldName = "PODate";
            this.Col_Podate_a.Name = "Col_Podate_a";
            this.Col_Podate_a.Visible = true;
            this.Col_Podate_a.VisibleIndex = 1;
            // 
            // Col_customer_a
            // 
            this.Col_customer_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_customer_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_customer_a.Caption = "Customer";
            this.Col_customer_a.FieldName = "Customer";
            this.Col_customer_a.Name = "Col_customer_a";
            this.Col_customer_a.Visible = true;
            this.Col_customer_a.VisibleIndex = 2;
            // 
            // Col_Item_a
            // 
            this.Col_Item_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Item_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Item_a.Caption = "Item";
            this.Col_Item_a.FieldName = "Item";
            this.Col_Item_a.Name = "Col_Item_a";
            this.Col_Item_a.Visible = true;
            this.Col_Item_a.VisibleIndex = 3;
            // 
            // Col_Film_a
            // 
            this.Col_Film_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Film_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Film_a.Caption = "Film On PO";
            this.Col_Film_a.FieldName = "Film";
            this.Col_Film_a.Name = "Col_Film_a";
            this.Col_Film_a.Visible = true;
            this.Col_Film_a.VisibleIndex = 4;
            // 
            // Col_Po_Qty
            // 
            this.Col_Po_Qty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Po_Qty.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Po_Qty.Caption = "PoQty";
            this.Col_Po_Qty.FieldName = "POQty";
            this.Col_Po_Qty.Name = "Col_Po_Qty";
            this.Col_Po_Qty.Visible = true;
            this.Col_Po_Qty.VisibleIndex = 5;
            // 
            // Col_PStock
            // 
            this.Col_PStock.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_PStock.AppearanceHeader.Options.UseBackColor = true;
            this.Col_PStock.Caption = "P-Stock";
            this.Col_PStock.FieldName = "PStock";
            this.Col_PStock.Name = "Col_PStock";
            this.Col_PStock.Visible = true;
            this.Col_PStock.VisibleIndex = 6;
            // 
            // Col_Picking_a
            // 
            this.Col_Picking_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Picking_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Picking_a.Caption = "Picked";
            this.Col_Picking_a.FieldName = "Picking";
            this.Col_Picking_a.Name = "Col_Picking_a";
            this.Col_Picking_a.Visible = true;
            this.Col_Picking_a.VisibleIndex = 7;
            // 
            // Col_Masking_a
            // 
            this.Col_Masking_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Masking_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Masking_a.Caption = "Masked";
            this.Col_Masking_a.FieldName = "Masking";
            this.Col_Masking_a.Name = "Col_Masking_a";
            this.Col_Masking_a.Visible = true;
            this.Col_Masking_a.VisibleIndex = 8;
            // 
            // Col_Packing_a
            // 
            this.Col_Packing_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Packing_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Packing_a.Caption = "Packed";
            this.Col_Packing_a.FieldName = "Packing";
            this.Col_Packing_a.Name = "Col_Packing_a";
            this.Col_Packing_a.Visible = true;
            this.Col_Packing_a.VisibleIndex = 9;
            // 
            // Col_AllStock_a
            // 
            this.Col_AllStock_a.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_AllStock_a.AppearanceHeader.Options.UseBackColor = true;
            this.Col_AllStock_a.Caption = "All Stock";
            this.Col_AllStock_a.FieldName = "AllStock";
            this.Col_AllStock_a.Name = "Col_AllStock_a";
            this.Col_AllStock_a.Visible = true;
            this.Col_AllStock_a.VisibleIndex = 10;
            // 
            // Col_Backlog
            // 
            this.Col_Backlog.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Backlog.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Backlog.Caption = "Backlog";
            this.Col_Backlog.FieldName = "Backlog";
            this.Col_Backlog.Name = "Col_Backlog";
            this.Col_Backlog.Visible = true;
            this.Col_Backlog.VisibleIndex = 12;
            // 
            // Col_PackStatus
            // 
            this.Col_PackStatus.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_PackStatus.AppearanceHeader.Options.UseBackColor = true;
            this.Col_PackStatus.Caption = "Status";
            this.Col_PackStatus.FieldName = "PackingStatus";
            this.Col_PackStatus.Name = "Col_PackStatus";
            this.Col_PackStatus.Visible = true;
            this.Col_PackStatus.VisibleIndex = 13;
            // 
            // col_ShipOutted
            // 
            this.col_ShipOutted.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ShipOutted.AppearanceHeader.Options.UseBackColor = true;
            this.col_ShipOutted.Caption = "ShipOut";
            this.col_ShipOutted.FieldName = "ShipOutted";
            this.col_ShipOutted.Name = "col_ShipOutted";
            this.col_ShipOutted.Visible = true;
            this.col_ShipOutted.VisibleIndex = 11;
            // 
            // tabItemList
            // 
            this.tabItemList.Controls.Add(this.dgShippingList);
            this.tabItemList.Name = "tabItemList";
            this.tabItemList.Size = new System.Drawing.Size(1081, 372);
            this.tabItemList.Text = "ItemList";
            // 
            // dgShippingList
            // 
            this.dgShippingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgShippingList.Location = new System.Drawing.Point(0, 0);
            this.dgShippingList.MainView = this.gvShippingList;
            this.dgShippingList.Name = "dgShippingList";
            this.dgShippingList.Size = new System.Drawing.Size(1081, 372);
            this.dgShippingList.TabIndex = 0;
            this.dgShippingList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShippingList});
            this.dgShippingList.Click += new System.EventHandler(this.dgShippingList_Click);
            // 
            // gvShippingList
            // 
            this.gvShippingList.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvShippingList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvShippingList.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvShippingList.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvShippingList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvShippingList.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvShippingList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvShippingList.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvShippingList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvShippingList.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvShippingList.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvShippingList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvShippingList.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvShippingList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvShippingList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvShippingList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colPODate,
            this.colPONo,
            this.colItem,
            this.colFilm,
            this.ColShippingQty,
            this.colPOQuantity,
            this.colPriority,
            this.colSize,
            this.colActualThickness,
            this.colID,
            this.col_AvailableQty,
            this.col_OldDateExisted});
            this.gvShippingList.CustomizationFormBounds = new System.Drawing.Rectangle(1101, 508, 251, 244);
            this.gvShippingList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "BoldPOIsNotTheOldestPO";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "[OldDateExisted] < [PODate]";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.gvShippingList.FormatRules.Add(gridFormatRule2);
            this.gvShippingList.FormatRules.Add(gridFormatRule3);
            this.gvShippingList.GridControl = this.dgShippingList;
            this.gvShippingList.Name = "gvShippingList";
            this.gvShippingList.OptionsMenu.EnableFooterMenu = false;
            this.gvShippingList.OptionsMenu.ShowFooterItem = true;
            this.gvShippingList.OptionsPrint.PrintFooter = false;
            this.gvShippingList.OptionsPrint.PrintGroupFooter = false;
            this.gvShippingList.OptionsPrint.PrintHorzLines = false;
            this.gvShippingList.OptionsPrint.PrintVertLines = false;
            this.gvShippingList.OptionsSelection.MultiSelect = true;
            this.gvShippingList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvShippingList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gvShippingList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvShippingList.OptionsView.EnableAppearanceOddRow = true;
            this.gvShippingList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvShippingList_CustomDrawRowIndicator);
            this.gvShippingList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvShippingList_SelectionChanged);
            // 
            // colCustomer
            // 
            this.colCustomer.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colCustomer.AppearanceHeader.Options.UseBackColor = true;
            this.colCustomer.Caption = "Customer";
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            // 
            // colPODate
            // 
            this.colPODate.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPODate.AppearanceHeader.Options.UseBackColor = true;
            this.colPODate.Caption = "PO Date";
            this.colPODate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPODate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPODate.FieldName = "PODate";
            this.colPODate.Name = "colPODate";
            this.colPODate.Visible = true;
            this.colPODate.VisibleIndex = 2;
            // 
            // colPONo
            // 
            this.colPONo.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPONo.AppearanceHeader.Options.UseBackColor = true;
            this.colPONo.Caption = "PONo";
            this.colPONo.FieldName = "PONo";
            this.colPONo.Name = "colPONo";
            this.colPONo.Visible = true;
            this.colPONo.VisibleIndex = 3;
            // 
            // colItem
            // 
            this.colItem.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colItem.AppearanceHeader.Options.UseBackColor = true;
            this.colItem.Caption = "Item";
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 4;
            // 
            // colFilm
            // 
            this.colFilm.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colFilm.AppearanceHeader.Options.UseBackColor = true;
            this.colFilm.Caption = "Film On PO";
            this.colFilm.FieldName = "Film";
            this.colFilm.Name = "colFilm";
            this.colFilm.Visible = true;
            this.colFilm.VisibleIndex = 5;
            // 
            // ColShippingQty
            // 
            this.ColShippingQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColShippingQty.AppearanceHeader.Options.UseBackColor = true;
            this.ColShippingQty.Caption = "ShippingQty";
            this.ColShippingQty.FieldName = "ShippingQty";
            this.ColShippingQty.Name = "ColShippingQty";
            this.ColShippingQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, DevExpress.Data.SummaryMode.Selection, "ShippingQty", "SUM={0:0.##}")});
            this.ColShippingQty.Visible = true;
            this.ColShippingQty.VisibleIndex = 6;
            this.ColShippingQty.Width = 60;
            // 
            // colPOQuantity
            // 
            this.colPOQuantity.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPOQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colPOQuantity.Caption = "PO Quantity";
            this.colPOQuantity.FieldName = "TotalQty";
            this.colPOQuantity.Name = "colPOQuantity";
            this.colPOQuantity.Visible = true;
            this.colPOQuantity.VisibleIndex = 7;
            // 
            // colPriority
            // 
            this.colPriority.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPriority.AppearanceHeader.Options.UseBackColor = true;
            this.colPriority.Caption = "Priority";
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.Visible = true;
            this.colPriority.VisibleIndex = 9;
            // 
            // colSize
            // 
            this.colSize.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colSize.AppearanceHeader.Options.UseBackColor = true;
            this.colSize.Caption = "Size";
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            // 
            // colActualThickness
            // 
            this.colActualThickness.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colActualThickness.AppearanceHeader.Options.UseBackColor = true;
            this.colActualThickness.Caption = "ActualThickness";
            this.colActualThickness.FieldName = "ActualThickness";
            this.colActualThickness.Name = "colActualThickness";
            // 
            // col_AvailableQty
            // 
            this.col_AvailableQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_AvailableQty.AppearanceHeader.Options.UseBackColor = true;
            this.col_AvailableQty.Caption = "AvailableQty";
            this.col_AvailableQty.FieldName = "AvailableQuantity";
            this.col_AvailableQty.Name = "col_AvailableQty";
            this.col_AvailableQty.Visible = true;
            this.col_AvailableQty.VisibleIndex = 8;
            // 
            // col_OldDateExisted
            // 
            this.col_OldDateExisted.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_OldDateExisted.AppearanceHeader.Options.UseBackColor = true;
            this.col_OldDateExisted.Caption = "OldDateExisted";
            this.col_OldDateExisted.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.col_OldDateExisted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_OldDateExisted.FieldName = "OldDateExisted";
            this.col_OldDateExisted.Name = "col_OldDateExisted";
            // 
            // tabPackingList
            // 
            this.tabPackingList.Controls.Add(this.dgPackingList);
            this.tabPackingList.Name = "tabPackingList";
            this.tabPackingList.Size = new System.Drawing.Size(1081, 372);
            this.tabPackingList.Text = "Packing List";
            // 
            // dgPackingList
            // 
            this.dgPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPackingList.Location = new System.Drawing.Point(0, 0);
            this.dgPackingList.MainView = this.gvPackingList;
            this.dgPackingList.Name = "dgPackingList";
            this.dgPackingList.Size = new System.Drawing.Size(1081, 372);
            this.dgPackingList.TabIndex = 0;
            this.dgPackingList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPackingList});
            // 
            // gvPackingList
            // 
            this.gvPackingList.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvPackingList.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvPackingList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPackingList.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvPackingList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvPackingList.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvPackingList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPackingList.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPackingList.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvPackingList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPackingList.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvPackingList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvPackingList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPackingList.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.Red;
            this.gvPackingList.AppearancePrint.GroupRow.BackColor2 = System.Drawing.Color.Blue;
            this.gvPackingList.AppearancePrint.GroupRow.Options.UseBackColor = true;
            this.gvPackingList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomers,
            this.colPODates,
            this.colPONos,
            this.colItemCodes,
            this.colFlims,
            this.colPackQty,
            this.colShipPalletNo,
            this.colLoadingTime,
            this.colShipoutDate,
            this.colPickedDate,
            this.colPackedDate,
            this.ColPODeatailID,
            this.Col_packingStatus});
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "FormatStatus";
            formatConditionRuleExpression4.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression4.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression4.Expression = "Status>1";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            this.gvPackingList.FormatRules.Add(gridFormatRule4);
            this.gvPackingList.GridControl = this.dgPackingList;
            this.gvPackingList.GroupCount = 3;
            this.gvPackingList.Name = "gvPackingList";
            this.gvPackingList.OptionsSelection.MultiSelect = true;
            this.gvPackingList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvPackingList.OptionsView.EnableAppearanceOddRow = true;
            this.gvPackingList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomers, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLoadingTime, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShipPalletNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPackingList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvPackingList_CustomDrawRowIndicator);
            this.gvPackingList.CustomColumnGroup += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gvPackingList_CustomColumnGroup);
            this.gvPackingList.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvPackingList_CustomColumnDisplayText);
            // 
            // colCustomers
            // 
            this.colCustomers.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colCustomers.AppearanceHeader.Options.UseBackColor = true;
            this.colCustomers.Caption = "Customer";
            this.colCustomers.FieldName = "Customer";
            this.colCustomers.Name = "colCustomers";
            this.colCustomers.Visible = true;
            this.colCustomers.VisibleIndex = 1;
            this.colCustomers.Width = 63;
            // 
            // colPODates
            // 
            this.colPODates.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPODates.AppearanceHeader.Options.UseBackColor = true;
            this.colPODates.Caption = "PODate";
            this.colPODates.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPODates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPODates.FieldName = "PODate";
            this.colPODates.Name = "colPODates";
            this.colPODates.Visible = true;
            this.colPODates.VisibleIndex = 1;
            this.colPODates.Width = 71;
            // 
            // colPONos
            // 
            this.colPONos.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPONos.AppearanceHeader.Options.UseBackColor = true;
            this.colPONos.Caption = "PONo";
            this.colPONos.FieldName = "PONo";
            this.colPONos.Name = "colPONos";
            this.colPONos.Visible = true;
            this.colPONos.VisibleIndex = 2;
            this.colPONos.Width = 73;
            // 
            // colItemCodes
            // 
            this.colItemCodes.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colItemCodes.AppearanceHeader.Options.UseBackColor = true;
            this.colItemCodes.Caption = "ItemCode";
            this.colItemCodes.FieldName = "ItemCode";
            this.colItemCodes.Name = "colItemCodes";
            this.colItemCodes.Visible = true;
            this.colItemCodes.VisibleIndex = 3;
            this.colItemCodes.Width = 111;
            // 
            // colFlims
            // 
            this.colFlims.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colFlims.AppearanceHeader.Options.UseBackColor = true;
            this.colFlims.Caption = "Film On PO";
            this.colFlims.FieldName = "Flim";
            this.colFlims.Name = "colFlims";
            this.colFlims.Visible = true;
            this.colFlims.VisibleIndex = 4;
            this.colFlims.Width = 82;
            // 
            // colPackQty
            // 
            this.colPackQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPackQty.AppearanceHeader.Options.UseBackColor = true;
            this.colPackQty.Caption = "PackQty";
            this.colPackQty.FieldName = "PackQty";
            this.colPackQty.Name = "colPackQty";
            this.colPackQty.Visible = true;
            this.colPackQty.VisibleIndex = 5;
            this.colPackQty.Width = 56;
            // 
            // colShipPalletNo
            // 
            this.colShipPalletNo.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colShipPalletNo.AppearanceHeader.Options.UseBackColor = true;
            this.colShipPalletNo.Caption = "ShipPalletNo";
            this.colShipPalletNo.FieldName = "ShipPalletNo";
            this.colShipPalletNo.Name = "colShipPalletNo";
            this.colShipPalletNo.Visible = true;
            this.colShipPalletNo.VisibleIndex = 6;
            this.colShipPalletNo.Width = 83;
            // 
            // colLoadingTime
            // 
            this.colLoadingTime.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colLoadingTime.AppearanceHeader.Options.UseBackColor = true;
            this.colLoadingTime.Caption = "LoadingTime";
            this.colLoadingTime.FieldName = "LoadingTime";
            this.colLoadingTime.Name = "colLoadingTime";
            this.colLoadingTime.Visible = true;
            this.colLoadingTime.VisibleIndex = 7;
            this.colLoadingTime.Width = 84;
            // 
            // colShipoutDate
            // 
            this.colShipoutDate.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colShipoutDate.AppearanceHeader.Options.UseBackColor = true;
            this.colShipoutDate.Caption = "Loading Date";
            this.colShipoutDate.DisplayFormat.FormatString = "d";
            this.colShipoutDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colShipoutDate.FieldName = "ShipoutDate";
            this.colShipoutDate.Name = "colShipoutDate";
            this.colShipoutDate.Visible = true;
            this.colShipoutDate.VisibleIndex = 6;
            this.colShipoutDate.Width = 92;
            // 
            // colPickedDate
            // 
            this.colPickedDate.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPickedDate.AppearanceHeader.Options.UseBackColor = true;
            this.colPickedDate.Caption = "PickedDate";
            this.colPickedDate.DisplayFormat.FormatString = "ss:mm:hh dd/MM/yyyy";
            this.colPickedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPickedDate.FieldName = "PickedDate";
            this.colPickedDate.Name = "colPickedDate";
            this.colPickedDate.Visible = true;
            this.colPickedDate.VisibleIndex = 7;
            this.colPickedDate.Width = 126;
            // 
            // colPackedDate
            // 
            this.colPackedDate.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPackedDate.AppearanceHeader.Options.UseBackColor = true;
            this.colPackedDate.Caption = "PackedDate";
            this.colPackedDate.DisplayFormat.FormatString = "ss:mm:hh dd/MM/yyyy";
            this.colPackedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPackedDate.FieldName = "PackedDate";
            this.colPackedDate.Name = "colPackedDate";
            this.colPackedDate.Visible = true;
            this.colPackedDate.VisibleIndex = 8;
            this.colPackedDate.Width = 157;
            // 
            // ColPODeatailID
            // 
            this.ColPODeatailID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColPODeatailID.AppearanceHeader.Options.UseBackColor = true;
            this.ColPODeatailID.Caption = "PODeatailID";
            this.ColPODeatailID.FieldName = "PODeatailID";
            this.ColPODeatailID.Name = "ColPODeatailID";
            // 
            // Col_packingStatus
            // 
            this.Col_packingStatus.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_packingStatus.AppearanceHeader.Options.UseBackColor = true;
            this.Col_packingStatus.Caption = "Status";
            this.Col_packingStatus.FieldName = "Status";
            this.Col_packingStatus.Name = "Col_packingStatus";
            // 
            // tabPickingList
            // 
            this.tabPickingList.Controls.Add(this.dgPickingList);
            this.tabPickingList.Name = "tabPickingList";
            this.tabPickingList.Size = new System.Drawing.Size(1081, 372);
            this.tabPickingList.Text = "Picking List";
            // 
            // dgPickingList
            // 
            this.dgPickingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPickingList.Location = new System.Drawing.Point(0, 0);
            this.dgPickingList.MainView = this.gvPickingList;
            this.dgPickingList.Name = "dgPickingList";
            this.dgPickingList.Size = new System.Drawing.Size(1081, 372);
            this.dgPickingList.TabIndex = 0;
            this.dgPickingList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPickingList});
            this.dgPickingList.Click += new System.EventHandler(this.dgPickingList_Click);
            // 
            // gvPickingList
            // 
            this.gvPickingList.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvPickingList.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvPickingList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPickingList.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvPickingList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvPickingList.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvPickingList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPickingList.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPickingList.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvPickingList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPickingList.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvPickingList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvPickingList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPickingList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColPickID,
            this.col_ItemCodE,
            this.Col_LocatioN,
            this.Col_Film,
            this.Col_StockQtY,
            this.Col_QtytoPick,
            this.Col_OutStanding,
            this.Col_CustomeR,
            this.Col_ShippingPalletNO,
            this.Col_ETDs,
            this.Col_POPrioritY,
            this.Col_FilmInventory,
            this.col_LoadingTime});
            this.gvPickingList.GridControl = this.dgPickingList;
            this.gvPickingList.Name = "gvPickingList";
            this.gvPickingList.OptionsSelection.MultiSelect = true;
            this.gvPickingList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvPickingList.OptionsView.EnableAppearanceOddRow = true;
            this.gvPickingList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvPickingList_CustomDrawRowIndicator);
            // 
            // ColPickID
            // 
            this.ColPickID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColPickID.AppearanceHeader.Options.UseBackColor = true;
            this.ColPickID.Caption = "PickID";
            this.ColPickID.FieldName = "PickingID";
            this.ColPickID.Name = "ColPickID";
            // 
            // col_ItemCodE
            // 
            this.col_ItemCodE.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ItemCodE.AppearanceHeader.Options.UseBackColor = true;
            this.col_ItemCodE.Caption = "ItemCode";
            this.col_ItemCodE.FieldName = "ItemCode";
            this.col_ItemCodE.Name = "col_ItemCodE";
            this.col_ItemCodE.Visible = true;
            this.col_ItemCodE.VisibleIndex = 1;
            // 
            // Col_LocatioN
            // 
            this.Col_LocatioN.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_LocatioN.AppearanceHeader.Options.UseBackColor = true;
            this.Col_LocatioN.Caption = "Location";
            this.Col_LocatioN.FieldName = "Location";
            this.Col_LocatioN.Name = "Col_LocatioN";
            this.Col_LocatioN.Visible = true;
            this.Col_LocatioN.VisibleIndex = 2;
            // 
            // Col_Film
            // 
            this.Col_Film.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_Film.AppearanceHeader.Options.UseBackColor = true;
            this.Col_Film.Caption = "Film On PO";
            this.Col_Film.FieldName = "Film";
            this.Col_Film.Name = "Col_Film";
            this.Col_Film.Visible = true;
            this.Col_Film.VisibleIndex = 3;
            // 
            // Col_StockQtY
            // 
            this.Col_StockQtY.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_StockQtY.AppearanceHeader.Options.UseBackColor = true;
            this.Col_StockQtY.Caption = "StockQty";
            this.Col_StockQtY.FieldName = "InventoryAreaQty";
            this.Col_StockQtY.Name = "Col_StockQtY";
            this.Col_StockQtY.Visible = true;
            this.Col_StockQtY.VisibleIndex = 4;
            // 
            // Col_QtytoPick
            // 
            this.Col_QtytoPick.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_QtytoPick.AppearanceHeader.Options.UseBackColor = true;
            this.Col_QtytoPick.Caption = "QtyToPick";
            this.Col_QtytoPick.FieldName = "QtyToPick";
            this.Col_QtytoPick.Name = "Col_QtytoPick";
            this.Col_QtytoPick.Visible = true;
            this.Col_QtytoPick.VisibleIndex = 5;
            // 
            // Col_OutStanding
            // 
            this.Col_OutStanding.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_OutStanding.AppearanceHeader.Options.UseBackColor = true;
            this.Col_OutStanding.Caption = "OutStanding";
            this.Col_OutStanding.FieldName = "OutStanding";
            this.Col_OutStanding.Name = "Col_OutStanding";
            this.Col_OutStanding.Visible = true;
            this.Col_OutStanding.VisibleIndex = 6;
            // 
            // Col_CustomeR
            // 
            this.Col_CustomeR.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_CustomeR.AppearanceHeader.Options.UseBackColor = true;
            this.Col_CustomeR.Caption = "Customer";
            this.Col_CustomeR.FieldName = "Customer";
            this.Col_CustomeR.Name = "Col_CustomeR";
            this.Col_CustomeR.Visible = true;
            this.Col_CustomeR.VisibleIndex = 7;
            // 
            // Col_ShippingPalletNO
            // 
            this.Col_ShippingPalletNO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_ShippingPalletNO.AppearanceHeader.Options.UseBackColor = true;
            this.Col_ShippingPalletNO.Caption = "ShippingPalletNo";
            this.Col_ShippingPalletNO.FieldName = "ShippingPalletNo";
            this.Col_ShippingPalletNO.Name = "Col_ShippingPalletNO";
            this.Col_ShippingPalletNO.Visible = true;
            this.Col_ShippingPalletNO.VisibleIndex = 8;
            // 
            // Col_ETDs
            // 
            this.Col_ETDs.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_ETDs.AppearanceHeader.Options.UseBackColor = true;
            this.Col_ETDs.Caption = "Loading Date";
            this.Col_ETDs.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Col_ETDs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Col_ETDs.FieldName = "ETD";
            this.Col_ETDs.Name = "Col_ETDs";
            this.Col_ETDs.Visible = true;
            this.Col_ETDs.VisibleIndex = 10;
            // 
            // Col_POPrioritY
            // 
            this.Col_POPrioritY.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_POPrioritY.AppearanceHeader.Options.UseBackColor = true;
            this.Col_POPrioritY.Caption = "POPriority";
            this.Col_POPrioritY.FieldName = "POPriority";
            this.Col_POPrioritY.Name = "Col_POPrioritY";
            this.Col_POPrioritY.Visible = true;
            this.Col_POPrioritY.VisibleIndex = 11;
            // 
            // Col_FilmInventory
            // 
            this.Col_FilmInventory.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col_FilmInventory.AppearanceHeader.Options.UseBackColor = true;
            this.Col_FilmInventory.Caption = "FilmInventory";
            this.Col_FilmInventory.FieldName = "InventoryFilm";
            this.Col_FilmInventory.Name = "Col_FilmInventory";
            // 
            // col_LoadingTime
            // 
            this.col_LoadingTime.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_LoadingTime.AppearanceHeader.Options.UseBackColor = true;
            this.col_LoadingTime.Caption = "LoadingTime";
            this.col_LoadingTime.FieldName = "LoadingTime";
            this.col_LoadingTime.Name = "col_LoadingTime";
            this.col_LoadingTime.Visible = true;
            this.col_LoadingTime.VisibleIndex = 9;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 103);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(120, 10);
            // 
            // frmPOStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1084, 524);
            this.Controls.Add(this.tabDetail);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::StockManagementSystem.Properties.Resources.RFID_Solution_Sato02;
            this.IconOptions.LargeImage = global::StockManagementSystem.Properties.Resources.RFID_Solution_Sato02;
            this.Name = "frmPOStatus";
            this.Text = "PO Status [Trạng thái đơn hàng]";
            this.Load += new System.EventHandler(this.frmPOStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboETD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboETD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.tabPOStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPOStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOStatus)).EndInit();
            this.tabItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgShippingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShippingList)).EndInit();
            this.tabPackingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPackingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackingList)).EndInit();
            this.tabPickingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPickingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPickingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnPackingListIssue;
        private DevExpress.XtraEditors.SimpleButton btnUpdateLoadingDate;
        private DevExpress.XtraEditors.SimpleButton btnPickListUpdate;
        private DevExpress.XtraEditors.SimpleButton btnPickingList_Issue;
        private DevExpress.XtraEditors.SimpleButton btnUpdateShippingPallet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraTab.XtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage tabPOStatus;
        private DevExpress.XtraTab.XtraTabPage tabItemList;
        private DevExpress.XtraTab.XtraTabPage tabPickingList;
        private DevExpress.XtraTab.XtraTabPage tabPackingList;
        private DevExpress.XtraGrid.GridControl dgPOStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPOStatus;
        private DevExpress.XtraGrid.GridControl dgShippingList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShippingList;
        private DevExpress.XtraGrid.GridControl dgPickingList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPickingList;
        private DevExpress.XtraGrid.GridControl dgPackingList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPackingList;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colPODate;
        private DevExpress.XtraGrid.Columns.GridColumn colPONo;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colFilm;
        private DevExpress.XtraGrid.Columns.GridColumn colPOQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colActualThickness;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private System.Windows.Forms.ComboBox cboPrinterName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.DateEdit cboETD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colPODates;
        private DevExpress.XtraGrid.Columns.GridColumn colPONos;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCodes;
        private DevExpress.XtraGrid.Columns.GridColumn colFlims;
        private DevExpress.XtraGrid.Columns.GridColumn colPackQty;
        private DevExpress.XtraGrid.Columns.GridColumn colShipPalletNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPickedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPackedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipoutDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLoadingTime;
        private DevExpress.XtraGrid.Columns.GridColumn col_ItemCodE;
        private DevExpress.XtraGrid.Columns.GridColumn Col_LocatioN;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Film;
        private DevExpress.XtraGrid.Columns.GridColumn Col_StockQtY;
        private DevExpress.XtraGrid.Columns.GridColumn Col_QtytoPick;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CustomeR;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ShippingPalletNO;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ETDs;
        private DevExpress.XtraGrid.Columns.GridColumn Col_POPrioritY;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ColPODeatailID;
        private DevExpress.XtraGrid.Columns.GridColumn Col_FilmInventory;
        private DevExpress.XtraGrid.Columns.GridColumn ColPickID;
        private DevExpress.XtraGrid.Columns.GridColumn Col_OutStanding;
        private DevExpress.XtraGrid.Columns.GridColumn Col_poNo_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Podate_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_customer_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Item_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Film_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Po_Qty;
        private DevExpress.XtraGrid.Columns.GridColumn Col_PStock;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Picking_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Masking_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Packing_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_AllStock_a;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Backlog;
        private DevExpress.XtraEditors.SimpleButton btnReturnsPacking;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_packingStatus;
        private DevExpress.XtraGrid.Columns.GridColumn ColShippingQty;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_PackStatus;
        private DevExpress.XtraGrid.Columns.GridColumn col_ShipOutted;
        private DevExpress.XtraEditors.SimpleButton btnCounter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnHeightCounter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn col_LoadingTime;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraGrid.Columns.GridColumn col_AvailableQty;
        private DevExpress.XtraGrid.Columns.GridColumn col_OldDateExisted;
    }
}