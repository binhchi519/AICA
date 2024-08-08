
namespace StockManagementSystem
{
    partial class frmChangeDeletePOPass
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
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.oldPassCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.newPassCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.confirmPassCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtConfim = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.editOldPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.editNewPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.editConfirmPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.newPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.confirmPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.oldPassCheck = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnConfirm);
            this.layoutControl1.Controls.Add(this.oldPassCheckBox);
            this.layoutControl1.Controls.Add(this.newPassCheckBox);
            this.layoutControl1.Controls.Add(this.confirmPassCheckBox);
            this.layoutControl1.Controls.Add(this.txtOldPass);
            this.layoutControl1.Controls.Add(this.txtNewPass);
            this.layoutControl1.Controls.Add(this.txtConfim);
            this.layoutControl1.Location = new System.Drawing.Point(13, 13);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 393, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1290, 706);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 102);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(1266, 27);
            this.btnConfirm.StyleController = this.layoutControl1;
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Change Password [Đổi Mật Khẩu]";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // oldPassCheckBox
            // 
            this.oldPassCheckBox.Location = new System.Drawing.Point(1221, 12);
            this.oldPassCheckBox.Name = "oldPassCheckBox";
            this.oldPassCheckBox.Properties.Caption = "👁";
            this.oldPassCheckBox.Size = new System.Drawing.Size(57, 24);
            this.oldPassCheckBox.StyleController = this.layoutControl1;
            this.oldPassCheckBox.TabIndex = 20;
            this.oldPassCheckBox.TabStop = false;
            this.oldPassCheckBox.CheckedChanged += new System.EventHandler(this.oldPassCheckBox_CheckedChanged);
            // 
            // newPassCheckBox
            // 
            this.newPassCheckBox.Location = new System.Drawing.Point(1221, 42);
            this.newPassCheckBox.Name = "newPassCheckBox";
            this.newPassCheckBox.Properties.Caption = "👁";
            this.newPassCheckBox.Size = new System.Drawing.Size(57, 24);
            this.newPassCheckBox.StyleController = this.layoutControl1;
            this.newPassCheckBox.TabIndex = 19;
            this.newPassCheckBox.TabStop = false;
            this.newPassCheckBox.CheckedChanged += new System.EventHandler(this.newPassCheckBox_CheckedChanged);
            // 
            // confirmPassCheckBox
            // 
            this.confirmPassCheckBox.Location = new System.Drawing.Point(1221, 72);
            this.confirmPassCheckBox.Name = "confirmPassCheckBox";
            this.confirmPassCheckBox.Properties.Caption = "👁";
            this.confirmPassCheckBox.Size = new System.Drawing.Size(57, 24);
            this.confirmPassCheckBox.StyleController = this.layoutControl1;
            this.confirmPassCheckBox.TabIndex = 18;
            this.confirmPassCheckBox.TabStop = false;
            this.confirmPassCheckBox.CheckedChanged += new System.EventHandler(this.confirmPassCheckBox_CheckedChanged);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(325, 12);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(892, 26);
            this.txtOldPass.StyleController = this.layoutControl1;
            this.txtOldPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(325, 42);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(892, 26);
            this.txtNewPass.StyleController = this.layoutControl1;
            this.txtNewPass.TabIndex = 5;
            // 
            // txtConfim
            // 
            this.txtConfim.Location = new System.Drawing.Point(325, 72);
            this.txtConfim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfim.Name = "txtConfim";
            this.txtConfim.Size = new System.Drawing.Size(892, 26);
            this.txtConfim.StyleController = this.layoutControl1;
            this.txtConfim.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.editOldPass,
            this.editNewPass,
            this.editConfirmPass,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1290, 706);
            this.Root.TextVisible = false;
            // 
            // editOldPass
            // 
            this.editOldPass.Control = this.txtOldPass;
            this.editOldPass.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.editOldPass.CustomizationFormText = "Old Password [Mật khẩu cũ]:";
            this.editOldPass.Location = new System.Drawing.Point(0, 0);
            this.editOldPass.Name = "editOldPass";
            this.editOldPass.Size = new System.Drawing.Size(1209, 30);
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
            this.editNewPass.Size = new System.Drawing.Size(1209, 30);
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
            this.editConfirmPass.Size = new System.Drawing.Size(1209, 30);
            this.editConfirmPass.Text = "Confirm Password [Xác nhận mật khẩu]:";
            this.editConfirmPass.TextLocation = DevExpress.Utils.Locations.Left;
            this.editConfirmPass.TextSize = new System.Drawing.Size(301, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnConfirm;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1270, 596);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.oldPassCheckBox;
            this.layoutControlItem2.Location = new System.Drawing.Point(1209, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(61, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.newPassCheckBox;
            this.layoutControlItem3.Location = new System.Drawing.Point(1209, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(61, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.confirmPassCheckBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(1209, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(61, 30);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // newPassCheck
            // 
            this.newPassCheck.Location = new System.Drawing.Point(1040, 42);
            this.newPassCheck.Name = "newPassCheck";
            this.newPassCheck.Properties.Caption = "👁";
            this.newPassCheck.Size = new System.Drawing.Size(148, 24);
            this.newPassCheck.TabIndex = 14;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 102);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(1176, 27);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change Password [Đổi Mật Khẩu]";
            // 
            // confirmPassCheck
            // 
            this.confirmPassCheck.Location = new System.Drawing.Point(1040, 72);
            this.confirmPassCheck.Name = "confirmPassCheck";
            this.confirmPassCheck.Properties.Caption = "👁";
            this.confirmPassCheck.Size = new System.Drawing.Size(148, 24);
            this.confirmPassCheck.TabIndex = 15;
            // 
            // oldPassCheck
            // 
            this.oldPassCheck.Location = new System.Drawing.Point(1040, 12);
            this.oldPassCheck.Name = "oldPassCheck";
            this.oldPassCheck.Properties.Caption = "👁";
            this.oldPassCheck.Size = new System.Drawing.Size(148, 24);
            this.oldPassCheck.TabIndex = 13;
            // 
            // frmChangeDeletePOPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 414);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmChangeDeletePOPass";
            this.Text = "Change Delete PO Password [Thay đổi mật khẩu Xóa PO]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtConfim;
        private DevExpress.XtraLayout.LayoutControlItem editOldPass;
        private DevExpress.XtraLayout.LayoutControlItem editNewPass;
        private DevExpress.XtraLayout.LayoutControlItem editConfirmPass;
        private DevExpress.XtraEditors.CheckEdit newPassCheck;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.CheckEdit confirmPassCheck;
        private DevExpress.XtraEditors.CheckEdit oldPassCheck;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.CheckEdit oldPassCheckBox;
        private DevExpress.XtraEditors.CheckEdit newPassCheckBox;
        private DevExpress.XtraEditors.CheckEdit confirmPassCheckBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}