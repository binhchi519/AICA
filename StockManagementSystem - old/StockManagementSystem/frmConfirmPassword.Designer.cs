
namespace StockManagementSystem
{
    partial class frmConfirmPassword
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
            this.editPassword = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(93, 47);
            this.editPassword.Name = "editPassword";
            this.editPassword.Properties.UseSystemPasswordChar = true;
            this.editPassword.Size = new System.Drawing.Size(193, 26);
            this.editPassword.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Mật Khẩu";
            this.textEdit1.Location = new System.Drawing.Point(12, 47);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 26);
            this.textEdit1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConfirmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 127);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.textEdit1);
            this.Name = "frmConfirmPassword";
            this.Text = " Confirm Password [ Xác Nhận Mật Khẩu ]";
            this.Load += new System.EventHandler(this.frm_ConfrimPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.TextEdit editPassword;
    }
}