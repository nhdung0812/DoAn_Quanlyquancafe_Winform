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
namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    public partial class fNguoiquanly : Form
    {
        public fNguoiquanly()
        {
            InitializeComponent();
            
        }

        private void userControl_TaiKhoan1_Load(object sender, EventArgs e)
        {
           
        }

        private void fNguoiquanly_Load(object sender, EventArgs e)
        {
            userControl_TaiKhoan1.Ds_TaiKhoan();
        }
    }
}
