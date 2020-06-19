using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GiaoDien_QuanLyQuanCaPhe.DTO
{
    public class taiKhoan
    {
        private string _userName;
        private string _Name;
        private string _passWord;
        private int loai;
        public string UserName { get => _userName; set => _userName = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
        public int Loai { get => loai; set => loai = value; }
    }
}
