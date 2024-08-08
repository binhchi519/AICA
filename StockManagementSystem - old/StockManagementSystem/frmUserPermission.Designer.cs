
namespace StockManagementSystem
{
    partial class frmUserPermission
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
            this.txtAfftectedUser = new DevExpress.XtraEditors.TextEdit();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnRevokeAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllowAll = new DevExpress.XtraEditors.SimpleButton();
            this.dgDetail = new DevExpress.XtraGrid.GridControl();
            this.viewsData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFunctionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAllow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfftectedUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtAfftectedUser);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnRevokeAll);
            this.layoutControl1.Controls.Add(this.btnAllowAll);
            this.layoutControl1.Controls.Add(this.dgDetail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1353, 570);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtAfftectedUser
            // 
            this.txtAfftectedUser.EditValue = " ";
            this.txtAfftectedUser.Enabled = false;
            this.txtAfftectedUser.Location = new System.Drawing.Point(127, 12);
            this.txtAfftectedUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAfftectedUser.Name = "txtAfftectedUser";
            this.txtAfftectedUser.Size = new System.Drawing.Size(1214, 28);
            this.txtAfftectedUser.StyleController = this.layoutControl1;
            this.txtAfftectedUser.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 44);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(527, 51);
            this.btnUpdate.StyleController = this.layoutControl1;
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update\r\n[ Cập nhật ]";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRevokeAll
            // 
            this.btnRevokeAll.Location = new System.Drawing.Point(543, 44);
            this.btnRevokeAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRevokeAll.Name = "btnRevokeAll";
            this.btnRevokeAll.Size = new System.Drawing.Size(397, 51);
            this.btnRevokeAll.StyleController = this.layoutControl1;
            this.btnRevokeAll.TabIndex = 6;
            this.btnRevokeAll.Text = "Revoke All\r\n[Thu Hồi Toàn Bộ Quyền Truy Cập]";
            this.btnRevokeAll.Click += new System.EventHandler(this.btnRevokeAll_Click);
            // 
            // btnAllowAll
            // 
            this.btnAllowAll.Location = new System.Drawing.Point(944, 44);
            this.btnAllowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllowAll.Name = "btnAllowAll";
            this.btnAllowAll.Size = new System.Drawing.Size(397, 51);
            this.btnAllowAll.StyleController = this.layoutControl1;
            this.btnAllowAll.TabIndex = 5;
            this.btnAllowAll.Text = "Allow All\r\n[Cho Phép Truy Cập Tất Cả]";
            this.btnAllowAll.Click += new System.EventHandler(this.btnAllowAll_Click);
            // 
            // dgDetail
            // 
            this.dgDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgDetail.Location = new System.Drawing.Point(12, 99);
            this.dgDetail.MainView = this.viewsData;
            this.dgDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(1329, 459);
            this.dgDetail.TabIndex = 4;
            this.dgDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewsData});
            // 
            // viewsData
            // 
            this.viewsData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gold;
            this.viewsData.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Gold;
            this.viewsData.Appearance.FocusedCell.Options.UseBackColor = true;
            this.viewsData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gold;
            this.viewsData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Gold;
            this.viewsData.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.viewsData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.viewsData.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.viewsData.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewsData.Appearance.OddRow.Options.UseBackColor = true;
            this.viewsData.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow;
            this.viewsData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow;
            this.viewsData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.viewsData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFunctionID,
            this.colDevice,
            this.colForm,
            this.colFunctionName,
            this.ColAllow});
            this.viewsData.DetailHeight = 385;
            this.viewsData.GridControl = this.dgDetail;
            this.viewsData.Name = "viewsData";
            // 
            // colFunctionID
            // 
            this.colFunctionID.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colFunctionID.AppearanceHeader.Options.UseBackColor = true;
            this.colFunctionID.Caption = "FunctionID";
            this.colFunctionID.FieldName = "ID";
            this.colFunctionID.MinWidth = 31;
            this.colFunctionID.Name = "colFunctionID";
            this.colFunctionID.Width = 115;
            // 
            // colDevice
            // 
            this.colDevice.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colDevice.AppearanceHeader.Options.UseBackColor = true;
            this.colDevice.Caption = "Devices";
            this.colDevice.FieldName = "Device";
            this.colDevice.MinWidth = 31;
            this.colDevice.Name = "colDevice";
            this.colDevice.Width = 115;
            // 
            // colForm
            // 
            this.colForm.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colForm.AppearanceHeader.Options.UseBackColor = true;
            this.colForm.Caption = "Screen";
            this.colForm.FieldName = "MenuScreen";
            this.colForm.MinWidth = 31;
            this.colForm.Name = "colForm";
            this.colForm.Visible = true;
            this.colForm.VisibleIndex = 0;
            this.colForm.Width = 115;
            // 
            // colFunctionName
            // 
            this.colFunctionName.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colFunctionName.AppearanceHeader.Options.UseBackColor = true;
            this.colFunctionName.Caption = "Function";
            this.colFunctionName.FieldName = "FunctionName";
            this.colFunctionName.MinWidth = 31;
            this.colFunctionName.Name = "colFunctionName";
            this.colFunctionName.Visible = true;
            this.colFunctionName.VisibleIndex = 1;
            this.colFunctionName.Width = 115;
            // 
            // ColAllow
            // 
            this.ColAllow.AppearanceHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColAllow.AppearanceHeader.Options.UseBackColor = true;
            this.ColAllow.Caption = "Allowed";
            this.ColAllow.FieldName = "IsAllowed";
            this.ColAllow.MinWidth = 31;
            this.ColAllow.Name = "ColAllow";
            this.ColAllow.Visible = true;
            this.ColAllow.VisibleIndex = 2;
            this.ColAllow.Width = 115;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1353, 570);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgDetail;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1333, 463);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRevokeAll;
            this.layoutControlItem3.Location = new System.Drawing.Point(531, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(401, 55);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnUpdate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(531, 55);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtAfftectedUser;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1333, 32);
            this.layoutControlItem5.Text = "Affected User";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(111, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAllowAll;
            this.layoutControlItem2.Location = new System.Drawing.Point(932, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(401, 55);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmUserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 570);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUserPermission";
            this.Text = "User Permission [Phân Quyền Truy Cập]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAfftectedUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtAfftectedUser;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRevokeAll;
        private DevExpress.XtraEditors.SimpleButton btnAllowAll;
        private DevExpress.XtraGrid.GridControl dgDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView viewsData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colForm;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionName;
        private DevExpress.XtraGrid.Columns.GridColumn ColAllow;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionID;
    }
}