using BAL;
using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;
namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    public partial class fPhanMemQuanLyQuanCaPhe : Form
    {
        public static int trangthai = 0;
       
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
            //fHoaDon XuatHoaDon = new fHoaDon();
           // XuatHoaDon.ShowDialog();
            BAL_HOADON hd = new BAL_HOADON();
            DAL_HOADON bill = new DAL_HOADON();
            BAL_BAN ban = new BAL_BAN();
            BEL_BAN table = lsvBill.Tag as BEL_BAN;
            ban.get_lv(lsvBill, txt_totalprice);
            if (hd.Check_out(lsvBill,txt_totalprice) != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.Tenban, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    bill.CheckOut(bill.GetBill(table.Soban));
                    ban.showBill(table.Soban);

                    loadban();
                }
            }
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
            load_categoryFood();
        }
        public void loadban()
        {
            flp_ban.Controls.Clear();
            BAL_BAN xuly = new BAL_BAN();
            xuly.getDSban(flp_ban,lsvBill,txt_totalprice);
            
        }
        
        public void load_categoryFood()
        {
            BAL_LOAINUOC nuoc = new BAL_LOAINUOC();
            cboDanhMucMonAn.DataSource = nuoc.get_categoryFood();
            cboDanhMucMonAn.DisplayMember = "Tenloainuoc";
        }
        public void load_Food(int id)
        {
             BAL_NUOC id_nuoc = new BAL_NUOC();
            cboMonAn.DataSource = id_nuoc.lay_nuoc(id);
            cboMonAn.DisplayMember = "Tennuoc";
        }

        private void cboDanhMucMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            BEL_LOAINUOC select = cb.SelectedItem as BEL_LOAINUOC;
            id = select.Maloainuoc;
            load_Food(id);
            
        }

        private void bntThemMon_Click(object sender, EventArgs e)
        {
            
            BEL_BAN table = lsvBill.Tag as BEL_BAN;
            BAL_HOADON hd = new BAL_HOADON();
            hd.Insert_bill(btnThemMon, lsvBill,cboMonAn,nCount,txt_totalprice);
            loadban();
        }

       
    }
}
