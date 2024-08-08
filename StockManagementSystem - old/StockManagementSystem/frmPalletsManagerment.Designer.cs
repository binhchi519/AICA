
namespace StockManagementSystem
{
    partial class frmPalletsManagerment
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_PalletNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Enable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdateData = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRevokeAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dgDetail);
            this.layoutControl1.Controls.Add(this.btnUpdateData);
            this.layoutControl1.Controls.Add(this.btnDeSelectAll);
            this.layoutControl1.Controls.Add(this.btnSelectAll);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1137, 713);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dgDetail
            // 
            this.dgDetail.Location = new System.Drawing.Point(12, 67);
            this.dgDetail.MainView = this.gridView1;
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1113, 634);
            this.dgDetail.TabIndex = 8;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ItemCode,
            this.col_PalletNo,
            this.col_LocationCode,
            this.col_Enable});
            this.gridView1.GridControl = this.dgDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // col_ItemCode
            // 
            this.col_ItemCode.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_ItemCode.AppearanceHeader.Options.UseBackColor = true;
            this.col_ItemCode.Caption = "ItemCode";
            this.col_ItemCode.FieldName = "ItemCode";
            this.col_ItemCode.MinWidth = 25;
            this.col_ItemCode.Name = "col_ItemCode";
            this.col_ItemCode.Visible = true;
            this.col_ItemCode.VisibleIndex = 1;
            this.col_ItemCode.Width = 94;
            // 
            // col_PalletNo
            // 
            this.col_PalletNo.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_PalletNo.AppearanceHeader.Options.UseBackColor = true;
            this.col_PalletNo.Caption = "PalletNo";
            this.col_PalletNo.FieldName = "PalletNo";
            this.col_PalletNo.MinWidth = 25;
            this.col_PalletNo.Name = "col_PalletNo";
            this.col_PalletNo.Visible = true;
            this.col_PalletNo.VisibleIndex = 2;
            this.col_PalletNo.Width = 94;
            // 
            // col_LocationCode
            // 
            this.col_LocationCode.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_LocationCode.AppearanceHeader.Options.UseBackColor = true;
            this.col_LocationCode.Caption = "LocationCode";
            this.col_LocationCode.FieldName = "LocationCode";
            this.col_LocationCode.MinWidth = 25;
            this.col_LocationCode.Name = "col_LocationCode";
            this.col_LocationCode.Visible = true;
            this.col_LocationCode.VisibleIndex = 3;
            this.col_LocationCode.Width = 94;
            // 
            // col_Enable
            // 
            this.col_Enable.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.col_Enable.AppearanceHeader.Options.UseBackColor = true;
            this.col_Enable.Caption = "Enable";
            this.col_Enable.FieldName = "IsEnable";
            this.col_Enable.MinWidth = 25;
            this.col_Enable.Name = "col_Enable";
            this.col_Enable.Visible = true;
            this.col_Enable.VisibleIndex = 4;
            this.col_Enable.Width = 94;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(353, 51);
            this.btnUpdateData.StyleController = this.layoutControl1;
            this.btnUpdateData.TabIndex = 7;
            this.btnUpdateData.Text = "Update\r\n[Cập Nhật]";
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnDeSelectAll
            // 
            this.btnDeSelectAll.Location = new System.Drawing.Point(369, 12);
            this.btnDeSelectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeSelectAll.Name = "btnDeSelectAll";
            this.btnDeSelectAll.Size = new System.Drawing.Size(375, 51);
            this.btnDeSelectAll.StyleController = this.layoutControl1;
            this.btnDeSelectAll.TabIndex = 6;
            this.btnDeSelectAll.Text = "De-Select All\r\n[Không Sử Dụng Các Pallets Được Đánh Dấu]";
            this.btnDeSelectAll.Click += new System.EventHandler(this.btnDeSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(748, 12);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(377, 51);
            this.btnSelectAll.StyleController = this.layoutControl1;
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Select All\r\n[Sử Dụng Tất Cả Các Pallets Được Đánh Dấu]\r\n";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1137, 713);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSelectAll;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(736, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(381, 55);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnUpdateData;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(357, 55);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnDeSelectAll;
            this.layoutControlItem1.Location = new System.Drawing.Point(357, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(379, 55);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dgDetail;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1117, 638);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnRevokeAll
            // 
            this.btnRevokeAll.Location = new System.Drawing.Point(543, 44);
            this.btnRevokeAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRevokeAll.Name = "btnRevokeAll";
            this.btnRevokeAll.Size = new System.Drawing.Size(397, 51);
            this.btnRevokeAll.TabIndex = 6;
            this.btnRevokeAll.Text = "Revoke All\r\n[Thu Hồi Toàn Bộ Quyền Truy Cập]";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 44);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(527, 51);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update\r\n[ Cập nhật ]";
            // 
            // frmPalletsManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 713);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPalletsManagerment";
            this.Text = "PalletsManagerment [ Quản Lý Pallets In Nhãn ]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_PalletNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_LocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_Enable;
        private DevExpress.XtraEditors.SimpleButton btnUpdateData;
        private DevExpress.XtraEditors.SimpleButton btnDeSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnRevokeAll;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}