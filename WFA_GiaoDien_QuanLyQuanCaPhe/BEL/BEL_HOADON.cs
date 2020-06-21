using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_HOADON
    {
        private int _Mahd;
        private DateTime _ngayvao;
        private DateTime _ngayra;
        private int _soban;
        private int _trangthai;
        private int _soluong;

        public BEL_HOADON()
        {

        }
        public BEL_HOADON(int mahd, DateTime ngayvao, DateTime ngayra, int soban, int trangthai, int soluong)
        {
            this._Mahd = mahd;
            this._ngayvao = ngayvao;
            
            this._ngayra = ngayra;
            this._soban = soban;
            this._trangthai = trangthai;
            this._soluong = soluong;
        }
        public BEL_HOADON(DataRow row)
        {
            this._Mahd = (int)(row["id"]);
            this._ngayvao = (DateTime)(row["DateCheckIn"]);
            var temp = row["DateCheckOut"];
            if(temp.ToString() != "") 
                this._ngayra =(DateTime)temp;
            this._soban = (int)(row["idTable"]);
            this._trangthai = (int)(row["status"]);
        }
        public int MaHD
        {
            get { return _Mahd; }
            set { _Mahd = value; }
        }
        public DateTime NgayVao
        {
            get { return _ngayvao; }
            set { _ngayvao = value; }
        }
        public DateTime NgayRa
        {
            get { return _ngayra; }
            set { _ngayra = value; }
        }
        public int Soban
        {
            get { return _soban; }
            set { _soban = value; }
        }
        public int Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
        public int soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
    }
}
