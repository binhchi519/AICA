
using System;
using System.Windows.Forms;

namespace StockManagementSystem
{
    partial class frmPoDetail
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
            DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate formatConditionRuleUniqueDuplicate1 = new DevExpress.XtraEditors.FormatConditionRuleUniqueDuplicate();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkFilm = new DevExpress.XtraEditors.CheckEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtThickness = new DevExpress.XtraEditors.TextEdit();
            this.txtItem = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.txtPONo = new DevExpress.XtraEditors.TextEdit();
            this.dpkDate = new DevExpress.XtraEditors.DateEdit();
            this.txtTotalQty = new DevExpress.XtraEditors.TextEdit();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.cboPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.gridPODetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPONo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPODate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilmPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThicknessPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriorityPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AvailableQty = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkFilm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPODetail)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.dgDetail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1142, 582);
            this.splitContainerControl1.SplitterPosition = 108;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkFilm);
            this.layoutControl1.Controls.Add(this.btnExport);
            this.layoutControl1.Controls.Add(this.btnImport);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.txtThickness);
            this.layoutControl1.Controls.Add(this.txtItem);
            this.layoutControl1.Controls.Add(this.txtCustomer);
            this.layoutControl1.Controls.Add(this.txtPONo);
            this.layoutControl1.Controls.Add(this.dpkDate);
            this.layoutControl1.Controls.Add(this.txtTotalQty);
            this.layoutControl1.Controls.Add(this.txtQty);
            this.layoutControl1.Controls.Add(this.cboPriority);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1142, 108);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkFilm
            // 
            this.chkFilm.Location = new System.Drawing.Point(293, 40);
            this.chkFilm.Name = "chkFilm";
            this.chkFilm.Properties.Caption = "Film";
            this.chkFilm.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkFilm.Size = new System.Drawing.Size(49, 23);
            this.chkFilm.StyleController = this.layoutControl1;
            this.chkFilm.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(898, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(293, 23);
            this.btnExport.StyleController = this.layoutControl1;
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Location = new System.Drawing.Point(602, 70);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(292, 23);
            this.btnImport.StyleController = this.layoutControl1;
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "Import PI";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(306, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(292, 23);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(10, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(292, 23);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtThickness
            // 
            this.txtThickness.Enabled = false;
            this.txtThickness.Location = new System.Drawing.Point(575, 40);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(50, 26);
            this.txtThickness.StyleController = this.layoutControl1;
            this.txtThickness.TabIndex = 8;
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(239, 40);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(50, 26);
            this.txtItem.StyleController = this.layoutControl1;
            this.txtItem.TabIndex = 7;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(572, 10);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(51, 26);
            this.txtCustomer.StyleController = this.layoutControl1;
            this.txtCustomer.TabIndex = 6;
            // 
            // txtPONo
            // 
            this.txtPONo.Enabled = false;
            this.txtPONo.Location = new System.Drawing.Point(856, 10);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(51, 26);
            this.txtPONo.StyleController = this.layoutControl1;
            this.txtPONo.TabIndex = 5;
            // 
            // dpkDate
            // 
            this.dpkDate.EditValue = null;
            this.dpkDate.Location = new System.Drawing.Point(239, 10);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpkDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpkDate.Size = new System.Drawing.Size(100, 26);
            this.dpkDate.StyleController = this.layoutControl1;
            this.dpkDate.TabIndex = 4;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Enabled = false;
            this.txtTotalQty.Location = new System.Drawing.Point(858, 40);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(50, 26);
            this.txtTotalQty.StyleController = this.layoutControl1;
            this.txtTotalQty.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(1141, 40);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(50, 26);
            this.txtQty.StyleController = this.layoutControl1;
            this.txtQty.TabIndex = 5;
            // 
            // cboPriority
            // 
            this.cboPriority.Location = new System.Drawing.Point(1140, 10);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPriority.Properties.DisplayFormat.FormatString = "d";
            this.cboPriority.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboPriority.Properties.EditFormat.FormatString = "d";
            this.cboPriority.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboPriority.Properties.Items.AddRange(new object[] {
            "A",
            "B-1",
            "B-2",
            "C",
            "D",
            "E"});
            this.cboPriority.Size = new System.Drawing.Size(51, 26);
            this.cboPriority.StyleController = this.layoutControl1;
            this.cboPriority.TabIndex = 4;
            this.cboPriority.SelectedIndexChanged += new System.EventHandler(this.cboPriority_SelectedIndexChanged);
            this.cboPriority.SelectedValueChanged += new System.EventHandler(this.cboPriority_SelectedValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem12,
            this.layoutControlItem10,
            this.layoutControlItem5,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1201, 103);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(296, 27);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnImport;
            this.layoutControlItem8.Location = new System.Drawing.Point(592, 60);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(296, 27);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnExport;
            this.layoutControlItem9.Location = new System.Drawing.Point(888, 60);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(297, 27);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDelete;
            this.layoutControlItem7.Location = new System.Drawing.Point(296, 60);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(296, 27);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dpkDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(333, 30);
            this.layoutControlItem1.Text = "PO Date [Ngày Nhập Đơn]";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtItem;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(283, 30);
            this.layoutControlItem4.Text = "Item [Tên Hàng]";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCustomer;
            this.layoutControlItem3.Location = new System.Drawing.Point(333, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(284, 30);
            this.layoutControlItem3.Text = "Customer No[Mã Khách Hàng]";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.cboPriority;
            this.layoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem12.CustomizationFormText = "PO Date [Ngày Nhập Đơn]";
            this.layoutControlItem12.Location = new System.Drawing.Point(901, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(284, 30);
            this.layoutControlItem12.Text = "Priority [Độ Ưu Tiên]";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.chkFilm;
            this.layoutControlItem10.Location = new System.Drawing.Point(283, 30);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(53, 30);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtThickness;
            this.layoutControlItem5.Location = new System.Drawing.Point(336, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(283, 30);
            this.layoutControlItem5.Text = "Thickness[Độ Dày]";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtTotalQty;
            this.layoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem11.CustomizationFormText = "PO No [Mã Đơn Hàng]";
            this.layoutControlItem11.Location = new System.Drawing.Point(619, 30);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(283, 30);
            this.layoutControlItem11.Text = "Total Quantity [Tổng Số Lượng]";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtQty;
            this.layoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem13.CustomizationFormText = "PO No [Mã Đơn Hàng]";
            this.layoutControlItem13.Location = new System.Drawing.Point(902, 30);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(283, 30);
            this.layoutControlItem13.Text = "Priority Quantity [Số Lượng Ưu Tiên]";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(226, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPONo;
            this.layoutControlItem2.Location = new System.Drawing.Point(617, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(284, 30);
            this.layoutControlItem2.Text = "PO No [Mã Đơn Hàng]";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(226, 19);
            // 
            // dgDetail
            // 
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.MainView = this.gridPODetail;
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1142, 469);
            this.dgDetail.TabIndex = 0;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPODetail});
            this.dgDetail.Click += new System.EventHandler(this.dgDetail_Click);
            // 
            // gridPODetail
            // 
            this.gridPODetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.gridPODetail.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.gridPODetail.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridPODetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.gridPODetail.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.gridPODetail.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gridPODetail.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridPODetail.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridPODetail.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridPODetail.Appearance.OddRow.Options.UseBackColor = true;
            this.gridPODetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridPODetail.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.gridPODetail.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridPODetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPONo,
            this.colPODate,
            this.colCustomerPO,
            this.colItemPO,
            this.colFilmPO,
            this.colThicknessPO,
            this.colQtyTotal,
            this.colPriorityPO,
            this.colQtyPO,
            this.col_ID,
            this.col_AvailableQty});
            this.gridPODetail.CustomizationFormBounds = new System.Drawing.Rectangle(1174, 597, 251, 244);
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "FormatPOQuantityLessThanInventory";
            formatConditionRuleExpression1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[AvailableQuantity] < [Qty]";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleUniqueDuplicate1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleUniqueDuplicate1.Appearance.Options.UseBackColor = true;
            gridFormatRule2.Rule = formatConditionRuleUniqueDuplicate1;
            this.gridPODetail.FormatRules.Add(gridFormatRule1);
            this.gridPODetail.FormatRules.Add(gridFormatRule2);
            this.gridPODetail.GridControl = this.dgDetail;
            this.gridPODetail.Name = "gridPODetail";
            this.gridPODetail.OptionsBehavior.Editable = false;
            this.gridPODetail.OptionsSelection.MultiSelect = true;
            this.gridPODetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridPODetail.OptionsView.EnableAppearanceOddRow = true;
            this.gridPODetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridPODetail_CustomDrawRowIndicator);
            // 
            // colPONo
            // 
            this.colPONo.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPONo.AppearanceHeader.Options.UseBackColor = true;
            this.colPONo.Caption = "PO No";
            this.colPONo.FieldName = "PONo";
            this.colPONo.Name = "colPONo";
            this.colPONo.Visible = true;
            this.colPONo.VisibleIndex = 1;
            this.colPONo.Width = 79;
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
            this.colPODate.Width = 107;
            // 
            // colCustomerPO
            // 
            this.colCustomerPO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colCustomerPO.AppearanceHeader.Options.UseBackColor = true;
            this.colCustomerPO.Caption = "Customer";
            this.colCustomerPO.FieldName = "Customer";
            this.colCustomerPO.Name = "colCustomerPO";
            this.colCustomerPO.Visible = true;
            this.colCustomerPO.VisibleIndex = 3;
            this.colCustomerPO.Width = 53;
            // 
            // colItemPO
            // 
            this.colItemPO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colItemPO.AppearanceHeader.Options.UseBackColor = true;
            this.colItemPO.Caption = "Item";
            this.colItemPO.FieldName = "Item";
            this.colItemPO.Name = "colItemPO";
            this.colItemPO.Visible = true;
            this.colItemPO.VisibleIndex = 4;
            this.colItemPO.Width = 71;
            // 
            // colFilmPO
            // 
            this.colFilmPO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colFilmPO.AppearanceHeader.Options.UseBackColor = true;
            this.colFilmPO.Caption = "Film";
            this.colFilmPO.FieldName = "Film";
            this.colFilmPO.Name = "colFilmPO";
            this.colFilmPO.Visible = true;
            this.colFilmPO.VisibleIndex = 5;
            this.colFilmPO.Width = 119;
            // 
            // colThicknessPO
            // 
            this.colThicknessPO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colThicknessPO.AppearanceHeader.Options.UseBackColor = true;
            this.colThicknessPO.Caption = "Thickness";
            this.colThicknessPO.FieldName = "Thickness";
            this.colThicknessPO.Name = "colThicknessPO";
            this.colThicknessPO.Visible = true;
            this.colThicknessPO.VisibleIndex = 6;
            this.colThicknessPO.Width = 119;
            // 
            // colQtyTotal
            // 
            this.colQtyTotal.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colQtyTotal.AppearanceHeader.Options.UseBackColor = true;
            this.colQtyTotal.Caption = "PO Quantity";
            this.colQtyTotal.FieldName = "TotalQty";
            this.colQtyTotal.Name = "colQtyTotal";
            this.colQtyTotal.Visible = true;
            this.colQtyTotal.VisibleIndex = 8;
            this.colQtyTotal.Width = 119;
            // 
            // colPriorityPO
            // 
            this.colPriorityPO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colPriorityPO.AppearanceHeader.Options.UseBackColor = true;
            this.colPriorityPO.Caption = "Priority";
            this.colPriorityPO.FieldName = "Priority";
            this.colPriorityPO.Name = "colPriorityPO";
            this.colPriorityPO.Visible = true;
            this.colPriorityPO.VisibleIndex = 10;
            this.colPriorityPO.Width = 151;
            // 
            // colQtyPO
            // 
            this.colQtyPO.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colQtyPO.AppearanceHeader.Options.UseBackColor = true;
            this.colQtyPO.Caption = "ShippingQty";
            this.colQtyPO.FieldName = "Qty";
            this.colQtyPO.Name = "colQtyPO";
            this.colQtyPO.Visible = true;
            this.colQtyPO.VisibleIndex = 7;
            this.colQtyPO.Width = 119;
            // 
            // col_ID
            // 
            this.col_ID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ID.AppearanceHeader.Options.UseBackColor = true;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "ID";
            this.col_ID.Name = "col_ID";
            // 
            // col_AvailableQty
            // 
            this.col_AvailableQty.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_AvailableQty.AppearanceHeader.Options.UseBackColor = true;
            this.col_AvailableQty.Caption = "Available Quantity";
            this.col_AvailableQty.FieldName = "AvailableQuantity";
            this.col_AvailableQty.Name = "col_AvailableQty";
            this.col_AvailableQty.Visible = true;
            this.col_AvailableQty.VisibleIndex = 9;
            this.col_AvailableQty.Width = 119;
            // 
            // frmPoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1142, 582);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPoDetail";
            this.Text = "PO Detail [Chi Tiết PO]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkFilm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpkDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPODetail)).EndInit();
            this.ResumeLayout(false);

        }

        private void form_onKeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dpkDate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtThickness;
        private DevExpress.XtraEditors.TextEdit txtItem;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.TextEdit txtPONo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.CheckEdit chkFilm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.TextEdit txtTotalQty;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.ComboBoxEdit cboPriority;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPODetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPONo;
        private DevExpress.XtraGrid.Columns.GridColumn colPODate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPO;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPO;
        private DevExpress.XtraGrid.Columns.GridColumn colFilmPO;
        private DevExpress.XtraGrid.Columns.GridColumn colThicknessPO;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPriorityPO;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyPO;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_AvailableQty;
    }
}