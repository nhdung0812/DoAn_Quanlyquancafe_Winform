using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_THONGTINHOADON
    {
        private int _masp;
        private int _Mahd;
        private int _manuoc;
        private int _soluong;

        public BEL_THONGTINHOADON()
        {

        }
        public BEL_THONGTINHOADON(int masp, int mahd, int manuoc, int soluong)
        {
            this._masp = masp;
            this._Mahd = mahd;
            this._manuoc = manuoc;
            this._soluong = soluong;
        }
        public BEL_THONGTINHOADON(DataRow row)
        {
            this._masp = (int)(row["id"]);           
            this._Mahd = (int)(row["idBill"]);
            this._manuoc = (int)(row["idFood"]);
            this._soluong = (int)(row["count"]);
        }
        public int Masp
        {
            get { return _masp; }
            set { _masp = value; }
        }
        public int Mahd
        {
            get { return _Mahd; }
            set { _masp = value; }
        }
        public int Manuoc
        {
            get { return _manuoc; }
            set { _manuoc = value; }
        }
        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
    }
}
