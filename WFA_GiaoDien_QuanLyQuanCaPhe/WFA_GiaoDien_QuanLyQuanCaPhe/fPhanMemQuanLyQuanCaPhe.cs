using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    public partial class fPhanMemQuanLyQuanCaPhe : Form
    {
        public static int trangthai = 0;
        public static int dai = 85;
        public static int Cao = 85;
        public fPhanMemQuanLyQuanCaPhe()
        {
            InitializeComponent();
        }

        private void TSMIDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN có muốn đăng xuất không?","THÔNG BÁO",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            fHoaDon XuatHoaDon = new fHoaDon();
            XuatHoaDon.ShowDialog();

        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThongtincanhan form_thongtincanhan = new fThongtincanhan();
            form_thongtincanhan.Show();

        }

        private void ManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNguoiquanly form_NguoiQuanLy = new fNguoiquanly();
            form_NguoiQuanLy.ShowDialog();
        }

        private void fPhanMemQuanLyQuanCaPhe_Load(object sender, EventArgs e)
        {
            loadban();
        }
        public void loadban()
        {
            BAL_BAN xuly = new BAL_BAN();
            xuly.getDSban(dai, Cao, flp_ban);
        }








    }
}
