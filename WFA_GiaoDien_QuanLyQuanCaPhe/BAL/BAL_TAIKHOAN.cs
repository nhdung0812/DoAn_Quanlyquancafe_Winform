using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_TAIKHOAN
    {
        public DataTable get_Taikhoan()
        {
            try
            {
                DAL_TAIKHOAN tk = new DAL_TAIKHOAN();
                return tk.DsNhapvien();
            }
            catch
            {
                throw;
            }
        }
        // Đăng nhập 
        public bool kiemtra(string tendangnhap, string matkhau)
        {
            try
            {
                DAL_TAIKHOAN kt = new DAL_TAIKHOAN();
                return kt.login(tendangnhap, matkhau);
            }
            catch
            {
                throw;
            }
        }
        // load danh sách user
        public List<BEL_TAIKHOAN> getDs_User()
        {
            DAL_TAIKHOAN ds = new DAL_TAIKHOAN();
            return ds.load_User();
        }
    }
}
