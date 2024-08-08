
namespace StockManagementSystem
{
    partial class frmChangeRePrintPass
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
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.confirmPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.newPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.oldPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtConfim = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.editOldPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.editNewPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.editConfirmPass = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editConfirmPass)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnChange);
            this.layoutControl1.Controls.Add(this.confirmPassCheck);
            this.layoutControl1.Controls.Add(this.newPassCheck);
            this.layoutControl1.Controls.Add(this.oldPassCheck);
            this.layoutControl1.Controls.Add(this.txtNewPass);
            this.layoutControl1.Controls.Add(this.txtConfim);
            this.layoutControl1.Controls.Add(this.txtOldPass);
            this.layoutControl1.Location = new System.Drawing.Point(16, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 697);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 102);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(1176, 27);
            this.btnChange.StyleController = this.layoutControl1;
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change Password [Đổi Mật Khẩu]";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // confirmPassCheck
            // 
            this.confirmPassCheck.Location = new System.Drawing.Point(1040, 72);
            this.confirmPassCheck.Name = "confirmPassCheck";
            this.confirmPassCheck.Properties.Caption = "👁";
            this.confirmPassCheck.Size = new System.Drawing.Size(148, 24);
            this.confirmPassCheck.StyleController = this.layoutControl1;
            this.confirmPassCheck.TabIndex = 15;
            this.confirmPassCheck.CheckedChanged += new System.EventHandler(this.confirmPassCheck_CheckedChanged);
            // 
            // newPassCheck
            // 
            this.newPassCheck.Location = new System.Drawing.Point(1040, 42);
            this.newPassCheck.Name = "newPassCheck";
            this.newPassCheck.Properties.Caption = "👁";
            this.newPassCheck.Size = new System.Drawing.Size(148, 24);
            this.newPassCheck.StyleController = this.layoutControl1;
            this.newPassCheck.TabIndex = 14;
            this.newPassCheck.CheckedChanged += new System.EventHandler(this.newPassCheck_CheckedChanged_1);
            // 
            // oldPassCheck
            // 
            this.oldPassCheck.Location = new System.Drawing.Point(1040, 12);
            this.oldPassCheck.Name = "oldPassCheck";
            this.oldPassCheck.Properties.Caption = "👁";
            this.oldPassCheck.Size = new System.Drawing.Size(148, 24);
            this.oldPassCheck.StyleController = this.layoutControl1;
            this.oldPassCheck.TabIndex = 13;
            this.oldPassCheck.CheckedChanged += new System.EventHandler(this.oldPassCheck_CheckedChanged_1);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(325, 42);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(711, 26);
            this.txtNewPass.StyleController = this.layoutControl1;
            this.txtNewPass.TabIndex = 5;
            // 
            // txtConfim
            // 
            this.txtConfim.Location = new System.Drawing.Point(325, 72);
            this.txtConfim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfim.Name = "txtConfim";
            this.txtConfim.Size = new System.Drawing.Size(711, 26);
            this.txtConfim.StyleController = this.layoutControl1;
            this.txtConfim.TabIndex = 7;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(325, 12);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(711, 26);
            this.txtOldPass.StyleController = this.layoutControl1;
            this.txtOldPass.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.editOldPass,
            this.editNewPass,
            this.editConfirmPass});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1200, 697);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 121);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1180, 556);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.oldPassCheck;
            this.layoutControlItem5.Location = new System.Drawing.Point(1028, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(152, 30);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.newPassCheck;
            this.layoutControlItem4.Location = new System.Drawing.Point(1028, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(152, 30);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.confirmPassCheck;
            this.layoutControlItem6.Location = new System.Drawing.Point(1028, 60);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(152, 30);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnChange;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1180, 31);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // editOldPass
            // 
            this.editOldPass.Control = this.txtOldPass;
            this.editOldPass.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.editOldPass.CustomizationFormText = "Old Password [Mật khẩu cũ]:";
            this.editOldPass.Location = new System.Drawing.Point(0, 0);
            this.editOldPass.Name = "editOldPass";
            this.editOldPass.Size = new System.Drawing.Size(1028, 30);
            this.editOldPass.Text = "Old Password [Mật khẩu cũ]:";
            this.editOldPass.TextSize = new System.Drawing.Size(301, 20);
            // 
            // editNewPass
            // 
            this.editNewPass.Control = this.txtNewPass;
            this.editNewPass.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.editNewPass.CustomizationFormText = "New Password [Mật khẩu mới]:";
            this.editNewPass.Location = new System.Drawing.Point(0, 30);
            this.editNewPass.Name = "editNewPass";
            this.editNewPass.Size = new System.Drawing.Size(1028, 30);
            this.editNewPass.Text = "New Password [Mật khẩu mới]:";
            this.editNewPass.TextSize = new System.Drawing.Size(301, 20);
            // 
            // editConfirmPass
            // 
            this.editConfirmPass.Control = this.txtConfim;
            this.editConfirmPass.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.editConfirmPass.CustomizationFormText = "Confirm Password [Xác nhận mật khẩu]:";
            this.editConfirmPass.Location = new System.Drawing.Point(0, 60);
            this.editConfirmPass.Name = "editConfirmPass";
            this.editConfirmPass.Size = new System.Drawing.Size(1028, 30);
            this.editConfirmPass.Text = "Confirm Password [Xác nhận mật khẩu]:";
            this.editConfirmPass.TextLocation = DevExpress.Utils.Locations.Left;
            this.editConfirmPass.TextSize = new System.Drawing.Size(301, 20);
            // 
            // frmChangeRePrintPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 163);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmChangeRePrintPass";
            this.Text = "Change RePrint Label Password [ Thay đổi mật khẩu In Lại Nhãn ] ";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editConfirmPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit confirmPassCheck;
        private DevExpress.XtraEditors.CheckEdit newPassCheck;
        private DevExpress.XtraEditors.CheckEdit oldPassCheck;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtConfim;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraLayout.LayoutControlItem editOldPass;
        private DevExpress.XtraLayout.LayoutControlItem editNewPass;
        private DevExpress.XtraLayout.LayoutControlItem editConfirmPass;
    }
}