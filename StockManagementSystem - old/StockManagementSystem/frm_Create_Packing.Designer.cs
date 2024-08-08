
namespace StockManagementSystem
{
    partial class frm_Create_Packing
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
            this.chkLoadingTimeNextMonth = new DevExpress.XtraEditors.CheckEdit();
            this.chkLoadingtime = new DevExpress.XtraEditors.CheckEdit();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.cboLoadingTime = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.b = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadingTimeNextMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadingtime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoadingTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1665, 198);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chkLoadingTimeNextMonth);
            this.layoutControl1.Controls.Add(this.chkLoadingtime);
            this.layoutControl1.Controls.Add(this.btnCreate);
            this.layoutControl1.Controls.Add(this.txtCustomer);
            this.layoutControl1.Controls.Add(this.cboLoadingTime);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1665, 184);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkLoadingTimeNextMonth
            // 
            this.chkLoadingTimeNextMonth.Location = new System.Drawing.Point(562, 13);
            this.chkLoadingTimeNextMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLoadingTimeNextMonth.Name = "chkLoadingTimeNextMonth";
            this.chkLoadingTimeNextMonth.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoadingTimeNextMonth.Properties.Appearance.Options.UseFont = true;
            this.chkLoadingTimeNextMonth.Properties.Caption = "Tạo Loadingtime Tháng Tiếp Theo";
            this.chkLoadingTimeNextMonth.Size = new System.Drawing.Size(541, 29);
            this.chkLoadingTimeNextMonth.StyleController = this.layoutControl1;
            this.chkLoadingTimeNextMonth.TabIndex = 24;
            this.chkLoadingTimeNextMonth.CheckedChanged += new System.EventHandler(this.twoCHK_CheckedChanged);
            // 
            // chkLoadingtime
            // 
            this.chkLoadingtime.Location = new System.Drawing.Point(1107, 13);
            this.chkLoadingtime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLoadingtime.Name = "chkLoadingtime";
            this.chkLoadingtime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoadingtime.Properties.Appearance.Options.UseFont = true;
            this.chkLoadingtime.Properties.Caption = "Tạo Loadingtime mới";
            this.chkLoadingtime.Size = new System.Drawing.Size(544, 29);
            this.chkLoadingtime.StyleController = this.layoutControl1;
            this.chkLoadingtime.TabIndex = 17;
            this.chkLoadingtime.CheckedChanged += new System.EventHandler(this.twoCHK_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Appearance.Options.UseFont = true;
            this.btnCreate.Location = new System.Drawing.Point(14, 78);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(1637, 32);
            this.btnCreate.StyleController = this.layoutControl1;
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(180, 13);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(378, 28);
            this.txtCustomer.StyleController = this.layoutControl1;
            this.txtCustomer.TabIndex = 23;
            this.txtCustomer.EditValueChanged += new System.EventHandler(this.txtCustomer_EditValueChanged);
            // 
            // cboLoadingTime
            // 
            this.cboLoadingTime.Location = new System.Drawing.Point(180, 46);
            this.cboLoadingTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoadingTime.Name = "cboLoadingTime";
            this.cboLoadingTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoadingTime.Properties.DisplayFormat.FormatString = "d";
            this.cboLoadingTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboLoadingTime.Properties.EditFormat.FormatString = "d";
            this.cboLoadingTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboLoadingTime.Properties.NullText = "";
            this.cboLoadingTime.Properties.PopupSizeable = false;
            this.cboLoadingTime.Size = new System.Drawing.Size(1471, 28);
            this.cboLoadingTime.StyleController = this.layoutControl1;
            this.cboLoadingTime.TabIndex = 20;
            this.cboLoadingTime.EditValueChanged += new System.EventHandler(this.cboLoadingTime_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.b,
            this.layoutControlItem12,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1665, 184);
            this.Root.TextVisible = false;
            // 
            // b
            // 
            this.b.Control = this.cboLoadingTime;
            this.b.Location = new System.Drawing.Point(0, 33);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(1641, 32);
            this.b.Text = "Chọn Loading Time:";
            this.b.TextSize = new System.Drawing.Size(161, 22);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnCreate;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(1641, 97);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkLoadingtime;
            this.layoutControlItem1.Location = new System.Drawing.Point(1093, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(548, 33);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCustomer;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(548, 33);
            this.layoutControlItem2.Text = "Customer";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(161, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkLoadingTimeNextMonth;
            this.layoutControlItem3.Location = new System.Drawing.Point(548, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(545, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frm_Create_Packing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 198);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Create_Packing";
            this.Text = "Create Packing [Tạo Packing]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Create_Packing_FormClosing);
            this.Load += new System.EventHandler(this.frm_Create_Packing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadingTimeNextMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadingtime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoadingTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit chkLoadingtime;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem b;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit cboLoadingTime;
        private DevExpress.XtraEditors.CheckEdit chkLoadingTimeNextMonth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}