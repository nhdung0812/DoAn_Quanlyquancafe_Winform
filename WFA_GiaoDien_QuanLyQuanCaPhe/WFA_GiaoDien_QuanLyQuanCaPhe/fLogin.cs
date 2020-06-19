using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
namespace WFA_GiaoDien_QuanLyQuanCaPhe
{

    public partial class fLogin : Form
    {
        private string name;
        public fLogin()
        {
            InitializeComponent();
            BAL_TAIKHOAN get_user = new BAL_TAIKHOAN();
            cboChonTenDangNhap.DataSource = get_user.getDs_User();
            cboChonTenDangNhap.DisplayMember = "TenDangNhap";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }
        // hiện username đăng nhập
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            fPhanMemQuanLyQuanCaPhe Mo_from_PhanMemQuanLyQuanCaPhe = new fPhanMemQuanLyQuanCaPhe();
             string matkhau = txtMatKhau.Text;
            if (matkhau != "")
            {
                if (dangnhap(name, matkhau))
                {
                    this.Hide();
                    Mo_from_PhanMemQuanLyQuanCaPhe.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Nhập Sai Tên Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được bỏ trống ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            
        }
        public bool dangnhap(string tendangnhap, string matkhau)
        {
            BAL_TAIKHOAN kt = new BAL_TAIKHOAN();
            if (kt.kiemtra(tendangnhap, matkhau))
                return true;
            return false;
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn muốn thoát? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private string name_User(string n)
        {
            return n;
        }
        private void cboChonTenDangNhap_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            BEL_TAIKHOAN value = cb.SelectedValue as BEL_TAIKHOAN;
            name = value.TenDangNhap;
        }
    }
}
