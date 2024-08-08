
namespace StockManagementSystem
{
    partial class frmChangePassword
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
            this.oldPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.newPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.txtConfim = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.confirmPassCheck = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.oldPassCheck);
            this.layoutControl1.Controls.Add(this.newPassCheck);
            this.layoutControl1.Controls.Add(this.btnChange);
            this.layoutControl1.Controls.Add(this.txtConfim);
            this.layoutControl1.Controls.Add(this.txtNewPass);
            this.layoutControl1.Controls.Add(this.txtOldPass);
            this.layoutControl1.Controls.Add(this.confirmPassCheck);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(465, 235, 1156, 558);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(987, 144);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // oldPassCheck
            // 
            this.oldPassCheck.Location = new System.Drawing.Point(919, 12);
            this.oldPassCheck.Name = "oldPassCheck";
            this.oldPassCheck.Properties.Caption = "👁";
            this.oldPassCheck.Size = new System.Drawing.Size(56, 24);
            this.oldPassCheck.StyleController = this.layoutControl1;
            this.oldPassCheck.TabIndex = 12;
            this.oldPassCheck.TabStop = false;
            this.oldPassCheck.CheckedChanged += new System.EventHandler(this.oldPassCheck_CheckedChanged);
            // 
            // newPassCheck
            // 
            this.newPassCheck.Location = new System.Drawing.Point(919, 42);
            this.newPassCheck.Name = "newPassCheck";
            this.newPassCheck.Properties.Caption = "👁";
            this.newPassCheck.Size = new System.Drawing.Size(56, 24);
            this.newPassCheck.StyleController = this.layoutControl1;
            this.newPassCheck.TabIndex = 11;
            this.newPassCheck.TabStop = false;
            this.newPassCheck.CheckedChanged += new System.EventHandler(this.newPassCheck_CheckedChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 102);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(963, 27);
            this.btnChange.StyleController = this.layoutControl1;
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change Password [Đổi Mật Khẩu]";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtConfim
            // 
            this.txtConfim.Location = new System.Drawing.Point(319, 72);
            this.txtConfim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfim.Name = "txtConfim";
            this.txtConfim.Size = new System.Drawing.Size(596, 26);
            this.txtConfim.StyleController = this.layoutControl1;
            this.txtConfim.TabIndex = 7;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(319, 42);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(596, 26);
            this.txtNewPass.StyleController = this.layoutControl1;
            this.txtNewPass.TabIndex = 5;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(319, 12);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(596, 26);
            this.txtOldPass.StyleController = this.layoutControl1;
            this.txtOldPass.TabIndex = 5;
            // 
            // confirmPassCheck
            // 
            this.confirmPassCheck.Location = new System.Drawing.Point(919, 72);
            this.confirmPassCheck.Name = "confirmPassCheck";
            this.confirmPassCheck.Properties.Caption = "👁";
            this.confirmPassCheck.Size = new System.Drawing.Size(56, 24);
            this.confirmPassCheck.StyleController = this.layoutControl1;
            this.confirmPassCheck.TabIndex = 10;
            this.confirmPassCheck.TabStop = false;
            this.confirmPassCheck.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(987, 144);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNewPass;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(907, 30);
            this.layoutControlItem2.Text = "New Password [Mật khẩu mới]:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(295, 20);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtConfim;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(907, 30);
            this.layoutControlItem4.Text = "Confim Password [Xác nhận mật khẩu]:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(295, 20);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnChange;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(967, 34);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtOldPass;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(907, 30);
            this.layoutControlItem3.Text = "Old Password [Mật khẩu cũ]:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(295, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.confirmPassCheck;
            this.layoutControlItem1.Location = new System.Drawing.Point(907, 60);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(60, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.newPassCheck;
            this.layoutControlItem5.Location = new System.Drawing.Point(907, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(60, 30);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.oldPassCheck;
            this.layoutControlItem7.Location = new System.Drawing.Point(907, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(60, 30);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(987, 175);
            this.splitContainerControl1.SplitterPosition = 144;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 175);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChangePassword";
            this.Text = "Change Password [Đổi mật khẩu]";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oldPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.TextEdit txtConfim;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckEdit oldPassCheck;
        private DevExpress.XtraEditors.CheckEdit newPassCheck;
        private DevExpress.XtraEditors.CheckEdit confirmPassCheck;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}