
namespace StockManagementSystem
{
    partial class frmLabelPrint
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPalletsManagerment = new DevExpress.XtraEditors.SimpleButton();
            this.cboPrinterName = new System.Windows.Forms.ComboBox();
            this.txtPrintQty = new DevExpress.XtraEditors.TextEdit();
            this.btnReprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cboLocation = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPalletNo = new DevExpress.XtraEditors.TextEdit();
            this.cboItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.gvLabelPrint = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalletNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPIC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrintQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalletNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabelPrint)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.dgDetail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1295, 651);
            this.splitContainerControl1.SplitterPosition = 103;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPalletsManagerment);
            this.layoutControl1.Controls.Add(this.cboPrinterName);
            this.layoutControl1.Controls.Add(this.txtPrintQty);
            this.layoutControl1.Controls.Add(this.btnReprint);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.cboLocation);
            this.layoutControl1.Controls.Add(this.txtPalletNo);
            this.layoutControl1.Controls.Add(this.cboItemCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1295, 103);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPalletsManagerment
            // 
            this.btnPalletsManagerment.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalletsManagerment.Appearance.Options.UseFont = true;
            this.btnPalletsManagerment.Location = new System.Drawing.Point(961, 44);
            this.btnPalletsManagerment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPalletsManagerment.Name = "btnPalletsManagerment";
            this.btnPalletsManagerment.Size = new System.Drawing.Size(322, 47);
            this.btnPalletsManagerment.StyleController = this.layoutControl1;
            this.btnPalletsManagerment.TabIndex = 12;
            this.btnPalletsManagerment.Text = "Pallet Managerment\r\n[Quản Lý Pallets]";
            this.btnPalletsManagerment.Click += new System.EventHandler(this.btnPalletsManagerment_Click);
            // 
            // cboPrinterName
            // 
            this.cboPrinterName.FormattingEnabled = true;
            this.cboPrinterName.Location = new System.Drawing.Point(1074, 12);
            this.cboPrinterName.Margin = new System.Windows.Forms.Padding(4);
            this.cboPrinterName.Name = "cboPrinterName";
            this.cboPrinterName.Size = new System.Drawing.Size(209, 30);
            this.cboPrinterName.TabIndex = 11;
            // 
            // txtPrintQty
            // 
            this.txtPrintQty.Location = new System.Drawing.Point(790, 12);
            this.txtPrintQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrintQty.Name = "txtPrintQty";
            this.txtPrintQty.Size = new System.Drawing.Size(167, 28);
            this.txtPrintQty.StyleController = this.layoutControl1;
            this.txtPrintQty.TabIndex = 10;
            // 
            // btnReprint
            // 
            this.btnReprint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprint.Appearance.Options.UseFont = true;
            this.btnReprint.Location = new System.Drawing.Point(526, 44);
            this.btnReprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(431, 47);
            this.btnReprint.StyleController = this.layoutControl1;
            this.btnReprint.TabIndex = 8;
            this.btnReprint.Text = "Reprint\r\n[In lại nhãn]";
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(12, 44);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(510, 47);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print\r\n[In Nhãn]";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboLocation
            // 
            this.cboLocation.Location = new System.Drawing.Point(423, 12);
            this.cboLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLocation.Size = new System.Drawing.Size(99, 28);
            this.cboLocation.StyleController = this.layoutControl1;
            this.cboLocation.TabIndex = 6;
            this.cboLocation.EditValueChanged += new System.EventHandler(this.cboLocation_EditValueChanged);
            // 
            // txtPalletNo
            // 
            this.txtPalletNo.Enabled = false;
            this.txtPalletNo.Location = new System.Drawing.Point(601, 12);
            this.txtPalletNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalletNo.Name = "txtPalletNo";
            this.txtPalletNo.Size = new System.Drawing.Size(72, 28);
            this.txtPalletNo.StyleController = this.layoutControl1;
            this.txtPalletNo.TabIndex = 5;
            // 
            // cboItemCode
            // 
            this.cboItemCode.Location = new System.Drawing.Point(51, 12);
            this.cboItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboItemCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Size", "Size", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboItemCode.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.cboItemCode.Size = new System.Drawing.Size(255, 28);
            this.cboItemCode.StyleController = this.layoutControl1;
            this.cboItemCode.TabIndex = 4;
            this.cboItemCode.EditValueChanged += new System.EventHandler(this.cboItemCode_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1295, 103);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboItemCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(298, 32);
            this.layoutControlItem1.Text = "Item";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(34, 22);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPalletNo;
            this.layoutControlItem2.Location = new System.Drawing.Point(514, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(151, 32);
            this.layoutControlItem2.Text = "PalletNo";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 22);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnPrint;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(514, 51);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnReprint;
            this.layoutControlItem5.Location = new System.Drawing.Point(514, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(435, 51);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboLocation;
            this.layoutControlItem3.Location = new System.Drawing.Point(298, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(216, 32);
            this.layoutControlItem3.Text = "Location";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 22);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtPrintQty;
            this.layoutControlItem7.Location = new System.Drawing.Point(665, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(284, 32);
            this.layoutControlItem7.Text = "Print Quantity";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(109, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cboPrinterName;
            this.layoutControlItem6.Location = new System.Drawing.Point(949, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(326, 32);
            this.layoutControlItem6.Text = "Printer";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(109, 22);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnPalletsManagerment;
            this.layoutControlItem8.Location = new System.Drawing.Point(949, 32);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(326, 51);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // dgDetail
            // 
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.MainView = this.gvLabelPrint;
            this.dgDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1295, 542);
            this.dgDetail.TabIndex = 0;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLabelPrint});
            // 
            // gvLabelPrint
            // 
            this.gvLabelPrint.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gvLabelPrint.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gvLabelPrint.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLabelPrint.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gvLabelPrint.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gvLabelPrint.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gvLabelPrint.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvLabelPrint.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvLabelPrint.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvLabelPrint.Appearance.OddRow.Options.UseBackColor = true;
            this.gvLabelPrint.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gvLabelPrint.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gvLabelPrint.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvLabelPrint.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName,
            this.colSize,
            this.colPalletNo,
            this.colLocationCode,
            this.colUpdateTime,
            this.colPIC,
            this.colID});
            this.gvLabelPrint.DetailHeight = 437;
            this.gvLabelPrint.GridControl = this.dgDetail;
            this.gvLabelPrint.Name = "gvLabelPrint";
            this.gvLabelPrint.OptionsBehavior.Editable = false;
            this.gvLabelPrint.OptionsView.EnableAppearanceOddRow = true;
            this.gvLabelPrint.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvLabelPrint_CustomDrawRowIndicator);
            // 
            // colItemCode
            // 
            this.colItemCode.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colItemCode.AppearanceHeader.Options.UseBackColor = true;
            this.colItemCode.Caption = "Item";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.MinWidth = 25;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 94;
            // 
            // colItemName
            // 
            this.colItemName.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colItemName.AppearanceHeader.Options.UseBackColor = true;
            this.colItemName.Caption = "Print Name";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.MinWidth = 25;
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 94;
            // 
            // colSize
            // 
            this.colSize.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colSize.AppearanceHeader.Options.UseBackColor = true;
            this.colSize.Caption = "Size";
            this.colSize.FieldName = "Size";
            this.colSize.MinWidth = 25;
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 2;
            this.colSize.Width = 94;
            // 
            // colPalletNo
            // 
            this.colPalletNo.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPalletNo.AppearanceHeader.Options.UseBackColor = true;
            this.colPalletNo.Caption = "Pallet No";
            this.colPalletNo.FieldName = "PalletNo";
            this.colPalletNo.MinWidth = 25;
            this.colPalletNo.Name = "colPalletNo";
            this.colPalletNo.Visible = true;
            this.colPalletNo.VisibleIndex = 4;
            this.colPalletNo.Width = 94;
            // 
            // colLocationCode
            // 
            this.colLocationCode.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colLocationCode.AppearanceHeader.Options.UseBackColor = true;
            this.colLocationCode.Caption = "Location";
            this.colLocationCode.FieldName = "LocationCode";
            this.colLocationCode.MinWidth = 25;
            this.colLocationCode.Name = "colLocationCode";
            this.colLocationCode.Visible = true;
            this.colLocationCode.VisibleIndex = 3;
            this.colLocationCode.Width = 94;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colUpdateTime.AppearanceHeader.Options.UseBackColor = true;
            this.colUpdateTime.Caption = "Update Time";
            this.colUpdateTime.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colUpdateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colUpdateTime.FieldName = "UpdateTime";
            this.colUpdateTime.MinWidth = 25;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Visible = true;
            this.colUpdateTime.VisibleIndex = 5;
            this.colUpdateTime.Width = 94;
            // 
            // colPIC
            // 
            this.colPIC.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPIC.AppearanceHeader.Options.UseBackColor = true;
            this.colPIC.Caption = "PIC";
            this.colPIC.FieldName = "Pic";
            this.colPIC.MinWidth = 25;
            this.colPIC.Name = "colPIC";
            this.colPIC.Visible = true;
            this.colPIC.VisibleIndex = 6;
            this.colPIC.Width = 94;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colID.AppearanceHeader.Options.UseBackColor = true;
            this.colID.Caption = "IDPalletMaster";
            this.colID.FieldName = "IdPalletMaster";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // frmLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1295, 651);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLabelPrint";
            this.Text = "Label Print [In nhãn]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmLabelPrint_Activated);
            this.Load += new System.EventHandler(this.frmLabelPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrintQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalletNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabelPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnReprint;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LookUpEdit cboLocation;
        private DevExpress.XtraEditors.TextEdit txtPalletNo;
        private DevExpress.XtraEditors.LookUpEdit cboItemCode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLabelPrint;
        private DevExpress.XtraEditors.TextEdit txtPrintQty;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.ComboBox cboPrinterName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colPalletNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPIC;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.SimpleButton btnPalletsManagerment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}