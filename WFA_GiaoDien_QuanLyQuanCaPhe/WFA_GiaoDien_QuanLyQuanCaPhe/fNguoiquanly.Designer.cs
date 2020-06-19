namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    partial class fNguoiquanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNguoiquanly));
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tpDanhMucFood = new System.Windows.Forms.TabPage();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.tbPage = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tbBillEnter = new System.Windows.Forms.TabPage();
            this.tbBillOut = new System.Windows.Forms.TabPage();
            this.userControl_DoanhThu1 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_DoanhThu();
            this.userControl_ThucUong1 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_ThucUong();
            this.userControl_DanhMuc1 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_DanhMuc();
            this.userControl_Ban1 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_Ban();
            this.userControl_TaiKhoan1 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_TaiKhoan();
            this.userControl_HoaDonNhap1 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_HoaDonNhap();
            this.userControl_HoaDonNhap2 = new WFA_GiaoDien_QuanLyQuanCaPhe.UserControl_HoaDonNhap();
            this.tpTable.SuspendLayout();
            this.tpDanhMucFood.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.tbPage.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.tbBillEnter.SuspendLayout();
            this.tbBillOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.userControl_Ban1);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(743, 442);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tpDanhMucFood
            // 
            this.tpDanhMucFood.Controls.Add(this.userControl_DanhMuc1);
            this.tpDanhMucFood.Location = new System.Drawing.Point(4, 22);
            this.tpDanhMucFood.Name = "tpDanhMucFood";
            this.tpDanhMucFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMucFood.Size = new System.Drawing.Size(743, 442);
            this.tpDanhMucFood.TabIndex = 2;
            this.tpDanhMucFood.Text = "Danh mục";
            this.tpDanhMucFood.UseVisualStyleBackColor = true;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.userControl_ThucUong1);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(743, 442);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức uống";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.userControl_DoanhThu1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(743, 442);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // tbPage
            // 
            this.tbPage.Controls.Add(this.tpBill);
            this.tbPage.Controls.Add(this.tpFood);
            this.tbPage.Controls.Add(this.tpDanhMucFood);
            this.tbPage.Controls.Add(this.tpTable);
            this.tbPage.Controls.Add(this.tpAccount);
            this.tbPage.Controls.Add(this.tbBillEnter);
            this.tbPage.Controls.Add(this.tbBillOut);
            this.tbPage.Location = new System.Drawing.Point(12, 12);
            this.tbPage.Name = "tbPage";
            this.tbPage.SelectedIndex = 0;
            this.tbPage.Size = new System.Drawing.Size(751, 468);
            this.tbPage.TabIndex = 1;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.userControl_TaiKhoan1);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(743, 442);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // tbBillEnter
            // 
            this.tbBillEnter.Controls.Add(this.userControl_HoaDonNhap1);
            this.tbBillEnter.Location = new System.Drawing.Point(4, 22);
            this.tbBillEnter.Name = "tbBillEnter";
            this.tbBillEnter.Padding = new System.Windows.Forms.Padding(3);
            this.tbBillEnter.Size = new System.Drawing.Size(743, 442);
            this.tbBillEnter.TabIndex = 5;
            this.tbBillEnter.Text = "Hóa đơn nhập";
            this.tbBillEnter.UseVisualStyleBackColor = true;
            // 
            // tbBillOut
            // 
            this.tbBillOut.Controls.Add(this.userControl_HoaDonNhap2);
            this.tbBillOut.Location = new System.Drawing.Point(4, 22);
            this.tbBillOut.Name = "tbBillOut";
            this.tbBillOut.Padding = new System.Windows.Forms.Padding(3);
            this.tbBillOut.Size = new System.Drawing.Size(743, 442);
            this.tbBillOut.TabIndex = 6;
            this.tbBillOut.Text = "Hóa đơn xuất";
            this.tbBillOut.UseVisualStyleBackColor = true;
            // 
            // userControl_DoanhThu1
            // 
            this.userControl_DoanhThu1.Location = new System.Drawing.Point(0, 0);
            this.userControl_DoanhThu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_DoanhThu1.Name = "userControl_DoanhThu1";
            this.userControl_DoanhThu1.Size = new System.Drawing.Size(742, 442);
            this.userControl_DoanhThu1.TabIndex = 2;
            // 
            // userControl_ThucUong1
            // 
            this.userControl_ThucUong1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ThucUong1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_ThucUong1.Name = "userControl_ThucUong1";
            this.userControl_ThucUong1.Size = new System.Drawing.Size(743, 442);
            this.userControl_ThucUong1.TabIndex = 4;
            // 
            // userControl_DanhMuc1
            // 
            this.userControl_DanhMuc1.Location = new System.Drawing.Point(0, 0);
            this.userControl_DanhMuc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_DanhMuc1.Name = "userControl_DanhMuc1";
            this.userControl_DanhMuc1.Size = new System.Drawing.Size(743, 442);
            this.userControl_DanhMuc1.TabIndex = 6;
            // 
            // userControl_Ban1
            // 
            this.userControl_Ban1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Ban1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_Ban1.Name = "userControl_Ban1";
            this.userControl_Ban1.Size = new System.Drawing.Size(743, 442);
            this.userControl_Ban1.TabIndex = 0;
            // 
            // userControl_TaiKhoan1
            // 
            this.userControl_TaiKhoan1.Location = new System.Drawing.Point(0, 2);
            this.userControl_TaiKhoan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_TaiKhoan1.Name = "userControl_TaiKhoan1";
            this.userControl_TaiKhoan1.Size = new System.Drawing.Size(745, 441);
            this.userControl_TaiKhoan1.TabIndex = 0;
            // 
            // userControl_HoaDonNhap1
            // 
            this.userControl_HoaDonNhap1.Location = new System.Drawing.Point(0, 0);
            this.userControl_HoaDonNhap1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_HoaDonNhap1.Name = "userControl_HoaDonNhap1";
            this.userControl_HoaDonNhap1.Size = new System.Drawing.Size(743, 442);
            this.userControl_HoaDonNhap1.TabIndex = 0;
            // 
            // userControl_HoaDonNhap2
            // 
            this.userControl_HoaDonNhap2.Location = new System.Drawing.Point(0, 0);
            this.userControl_HoaDonNhap2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl_HoaDonNhap2.Name = "userControl_HoaDonNhap2";
            this.userControl_HoaDonNhap2.Size = new System.Drawing.Size(743, 442);
            this.userControl_HoaDonNhap2.TabIndex = 0;
            // 
            // fNguoiquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.tbPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNguoiquanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Quản Lý";
            this.Load += new System.EventHandler(this.fNguoiquanly_Load);
            this.tpTable.ResumeLayout(false);
            this.tpDanhMucFood.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tbPage.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.tbBillEnter.ResumeLayout(false);
            this.tbBillOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpTable;
        private UserControl_Ban userControl_Ban1;
        private System.Windows.Forms.TabPage tpDanhMucFood;
        private UserControl_DanhMuc userControl_DanhMuc1;
        private System.Windows.Forms.TabPage tpFood;
        private UserControl_ThucUong userControl_ThucUong1;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabControl tbPage;
        private System.Windows.Forms.TabPage tbBillEnter;
        private UserControl_DoanhThu userControl_DoanhThu1;
        private System.Windows.Forms.TabPage tpAccount;
        private UserControl_TaiKhoan userControl_TaiKhoan1;
        private UserControl_HoaDonNhap userControl_HoaDonNhap1;
        private System.Windows.Forms.TabPage tbBillOut;
        private UserControl_HoaDonNhap userControl_HoaDonNhap2;


    }
}