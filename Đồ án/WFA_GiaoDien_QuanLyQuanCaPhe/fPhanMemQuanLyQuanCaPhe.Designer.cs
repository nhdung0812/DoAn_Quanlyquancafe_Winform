namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    partial class fPhanMemQuanLyQuanCaPhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhanMemQuanLyQuanCaPhe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountProFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.cboChuyenBan = new System.Windows.Forms.ComboBox();
            this.bntThanhToan = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.plListTable = new System.Windows.Forms.Panel();
            this.nCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.cboDanhMucMonAn = new System.Windows.Forms.ComboBox();
            this.plBill = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp_ban = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).BeginInit();
            this.plBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerToolStripMenuItem,
            this.AccountProFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1605, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.ManagerToolStripMenuItem.Text = "Người Quản Lý";
            this.ManagerToolStripMenuItem.Click += new System.EventHandler(this.ManagerToolStripMenuItem_Click);
            // 
            // AccountProFileToolStripMenuItem
            // 
            this.AccountProFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.TSMIDangXuat});
            this.AccountProFileToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.AccountProFileToolStripMenuItem.Name = "AccountProFileToolStripMenuItem";
            this.AccountProFileToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.AccountProFileToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(238, 30);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // TSMIDangXuat
            // 
            this.TSMIDangXuat.ForeColor = System.Drawing.Color.Red;
            this.TSMIDangXuat.Name = "TSMIDangXuat";
            this.TSMIDangXuat.Size = new System.Drawing.Size(238, 30);
            this.TSMIDangXuat.Text = "Đăng xuất";
            this.TSMIDangXuat.Click += new System.EventHandler(this.TSMIDangXuat_Click);
            // 
            // cboMonAn
            // 
            this.cboMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonAn.ForeColor = System.Drawing.Color.Black;
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(132, 52);
            this.cboMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(307, 30);
            this.cboMonAn.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_totalprice);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.cboChuyenBan);
            this.panel3.Controls.Add(this.bntThanhToan);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Location = new System.Drawing.Point(830, 629);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 92);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng Tiền";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Purple;
            this.txt_totalprice.Location = new System.Drawing.Point(441, 48);
            this.txt_totalprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.ReadOnly = true;
            this.txt_totalprice.Size = new System.Drawing.Size(152, 30);
            this.txt_totalprice.TabIndex = 10;
            this.txt_totalprice.Text = "0";
            this.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboChuyenBan
            // 
            this.cboChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenBan.FormattingEnabled = true;
            this.cboChuyenBan.Location = new System.Drawing.Point(4, 49);
            this.cboChuyenBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChuyenBan.Name = "cboChuyenBan";
            this.cboChuyenBan.Size = new System.Drawing.Size(140, 30);
            this.cboChuyenBan.TabIndex = 7;
            this.cboChuyenBan.Text = "-- Chọn Bàn --";
            // 
            // bntThanhToan
            // 
            this.bntThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThanhToan.ForeColor = System.Drawing.Color.Red;
            this.bntThanhToan.Location = new System.Drawing.Point(604, 5);
            this.bntThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntThanhToan.Name = "bntThanhToan";
            this.bntThanhToan.Size = new System.Drawing.Size(153, 83);
            this.bntThanhToan.TabIndex = 9;
            this.bntThanhToan.Text = "Thanh Toán";
            this.bntThanhToan.UseVisualStyleBackColor = true;
            this.bntThanhToan.Click += new System.EventHandler(this.bntThanhToan_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.ForeColor = System.Drawing.Color.Red;
            this.btnChuyenBan.Location = new System.Drawing.Point(4, 5);
            this.btnChuyenBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(142, 38);
            this.btnChuyenBan.TabIndex = 8;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // plListTable
            // 
            this.plListTable.Controls.Add(this.nCount);
            this.plListTable.Controls.Add(this.label1);
            this.plListTable.Controls.Add(this.lblNameFood);
            this.plListTable.Controls.Add(this.cboMonAn);
            this.plListTable.Controls.Add(this.btnThemMon);
            this.plListTable.Controls.Add(this.cboDanhMucMonAn);
            this.plListTable.Location = new System.Drawing.Point(830, 51);
            this.plListTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plListTable.Name = "plListTable";
            this.plListTable.Size = new System.Drawing.Size(762, 92);
            this.plListTable.TabIndex = 3;
            // 
            // nCount
            // 
            this.nCount.Location = new System.Drawing.Point(642, 35);
            this.nCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(51, 26);
            this.nCount.TabIndex = 7;
            this.nCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh Mục";
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.ForeColor = System.Drawing.Color.Red;
            this.lblNameFood.Location = new System.Drawing.Point(2, 57);
            this.lblNameFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(112, 26);
            this.lblNameFood.TabIndex = 5;
            this.lblNameFood.Text = "Chọn Món";
            // 
            // cboDanhMucMonAn
            // 
            this.cboDanhMucMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDanhMucMonAn.ForeColor = System.Drawing.Color.Black;
            this.cboDanhMucMonAn.FormattingEnabled = true;
            this.cboDanhMucMonAn.Location = new System.Drawing.Point(132, 5);
            this.cboDanhMucMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDanhMucMonAn.Name = "cboDanhMucMonAn";
            this.cboDanhMucMonAn.Size = new System.Drawing.Size(307, 30);
            this.cboDanhMucMonAn.TabIndex = 1;
            this.cboDanhMucMonAn.SelectedIndexChanged += new System.EventHandler(this.cboDanhMucMonAn_SelectedIndexChanged);
            // 
            // plBill
            // 
            this.plBill.Controls.Add(this.lsvBill);
            this.plBill.Location = new System.Drawing.Point(830, 152);
            this.plBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plBill.Name = "plBill";
            this.plBill.Size = new System.Drawing.Size(762, 468);
            this.plBill.TabIndex = 5;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(4, 5);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(751, 456);
            this.lsvBill.TabIndex = 4;
            this.lsvBill.Tag = "1";
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Nước";
            this.columnHeader1.Width = 219;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 214;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flp_ban);
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 675);
            this.panel1.TabIndex = 6;
            // 
            // flp_ban
            // 
            this.flp_ban.AutoScroll = true;
            this.flp_ban.Location = new System.Drawing.Point(4, 5);
            this.flp_ban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flp_ban.Name = "flp_ban";
            this.flp_ban.Size = new System.Drawing.Size(794, 666);
            this.flp_ban.TabIndex = 0;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.Red;
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(450, 5);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnThemMon.Size = new System.Drawing.Size(142, 83);
            this.btnThemMon.TabIndex = 3;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.bntThemMon_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(292, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(130, 83);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(156, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(130, 83);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sữa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // fPhanMemQuanLyQuanCaPhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1605, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plBill);
            this.Controls.Add(this.plListTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fPhanMemQuanLyQuanCaPhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Quán Cà Phê";
            this.TransparencyKey = System.Drawing.SystemColors.ControlText;
            this.Load += new System.EventHandler(this.fPhanMemQuanLyQuanCaPhe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.plListTable.ResumeLayout(false);
            this.plListTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).EndInit();
            this.plBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountProFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMIDangXuat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plListTable;
        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.ComboBox cboDanhMucMonAn;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button bntThanhToan;
        private System.Windows.Forms.ComboBox cboChuyenBan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel plBill;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.FlowLayoutPanel flp_ban;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.NumericUpDown nCount;
    }
}