namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    partial class UserControl_DoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvList_doanhthu = new System.Windows.Forms.DataGridView();
            this.palDoanhThu = new System.Windows.Forms.Panel();
            this.btnThongKe_doanhthu = new System.Windows.Forms.Button();
            this.tbpDateEnd_doanhthu = new System.Windows.Forms.DateTimePicker();
            this.tbpDateStart_doanhthu = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList_doanhthu)).BeginInit();
            this.palDoanhThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvList_doanhthu);
            this.panel1.Controls.Add(this.palDoanhThu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 507);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvList_doanhthu
            // 
            this.dgvList_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList_doanhthu.Location = new System.Drawing.Point(3, 38);
            this.dgvList_doanhthu.Name = "dgvList_doanhthu";
            this.dgvList_doanhthu.Size = new System.Drawing.Size(830, 466);
            this.dgvList_doanhthu.TabIndex = 4;
            // 
            // palDoanhThu
            // 
            this.palDoanhThu.Controls.Add(this.btnThongKe_doanhthu);
            this.palDoanhThu.Controls.Add(this.tbpDateEnd_doanhthu);
            this.palDoanhThu.Controls.Add(this.tbpDateStart_doanhthu);
            this.palDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.palDoanhThu.Name = "palDoanhThu";
            this.palDoanhThu.Size = new System.Drawing.Size(830, 32);
            this.palDoanhThu.TabIndex = 2;
            // 
            // btnThongKe_doanhthu
            // 
            this.btnThongKe_doanhthu.Location = new System.Drawing.Point(369, 0);
            this.btnThongKe_doanhthu.Name = "btnThongKe_doanhthu";
            this.btnThongKe_doanhthu.Size = new System.Drawing.Size(115, 27);
            this.btnThongKe_doanhthu.TabIndex = 3;
            this.btnThongKe_doanhthu.Text = "Thống kê";
            this.btnThongKe_doanhthu.UseVisualStyleBackColor = true;
            // 
            // tbpDateEnd_doanhthu
            // 
            this.tbpDateEnd_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDateEnd_doanhthu.Location = new System.Drawing.Point(540, 3);
            this.tbpDateEnd_doanhthu.Name = "tbpDateEnd_doanhthu";
            this.tbpDateEnd_doanhthu.Size = new System.Drawing.Size(287, 24);
            this.tbpDateEnd_doanhthu.TabIndex = 2;
            // 
            // tbpDateStart_doanhthu
            // 
            this.tbpDateStart_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDateStart_doanhthu.Location = new System.Drawing.Point(1, 3);
            this.tbpDateStart_doanhthu.Name = "tbpDateStart_doanhthu";
            this.tbpDateStart_doanhthu.Size = new System.Drawing.Size(317, 24);
            this.tbpDateStart_doanhthu.TabIndex = 1;
            // 
            // UserControl_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_DoanhThu";
            this.Size = new System.Drawing.Size(841, 513);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList_doanhthu)).EndInit();
            this.palDoanhThu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel palDoanhThu;
        private System.Windows.Forms.Button btnThongKe_doanhthu;
        private System.Windows.Forms.DateTimePicker tbpDateEnd_doanhthu;
        private System.Windows.Forms.DateTimePicker tbpDateStart_doanhthu;
        private System.Windows.Forms.DataGridView dgvList_doanhthu;
    }
}
