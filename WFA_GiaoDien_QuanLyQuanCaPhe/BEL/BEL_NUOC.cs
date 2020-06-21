using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_NUOC
    {
        private int _manuoc;
        private string _tennuoc;
        private string _maloainuoc;
        private float _giatien;

        public BEL_NUOC(int manuoc, string tennuoc, string maloainuoc, float giaten)
        {
            this._manuoc = manuoc;
            this._tennuoc = tennuoc;
            this._maloainuoc = maloainuoc;
            this._giatien = giaten;
        }
        public BEL_NUOC(DataRow row)
        {
            //this._manuoc = (int)(row["Manuoc"]);
            this._tennuoc = row["Tennuoc"].ToString();
            //this._maloainuoc = row["Maloainuoc"].ToString();
            //this._giatien = (float)row["Giatien"];
        }
        public int Manuoc
        {
            get { return _manuoc; }
            set { _manuoc = value; }
        }
        public string Tennuoc
        {
            get { return _tennuoc; }
            set { _tennuoc = value; }
        }
        public string Maloainuoc
        {
            get { return _maloainuoc; }
            set { _maloainuoc = value; }
        }
        public float Giatien
        {
            get { return _giatien; }
            set { _giatien = value; }
        }
    }
}
