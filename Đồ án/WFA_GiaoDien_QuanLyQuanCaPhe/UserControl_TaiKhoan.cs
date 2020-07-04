using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    public partial class UserControl_TaiKhoan : UserControl
    {
        public UserControl_TaiKhoan()
        {
            InitializeComponent();
        }
        public void Ds_TaiKhoan()
        {
            BAL_TAIKHOAN xuly = new BAL_TAIKHOAN();
            dgv_TaiKhoan.DataSource = xuly.get_Taikhoan();
        }
    }
}
