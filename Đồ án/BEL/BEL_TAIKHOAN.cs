using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_TAIKHOAN
    {
        private int _loai;
        private string _tendangnhap;
        private string _matkhau;
        private string _ten;

        public BEL_TAIKHOAN(int loai, string tendangnhap, string matkau, string ten)
        {
            this._loai = loai;
            this._tendangnhap = tendangnhap;
            this._matkhau = matkau;
            this._ten = ten;
        }
        public BEL_TAIKHOAN(DataRow row)
        {
            this._tendangnhap = row["UserName"].ToString();
        }
        

        public int Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        public string TenDangNhap
        {
            get { return _tendangnhap; }
            set { _tendangnhap = value; }
        }
        public string MatKhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
    }
}
