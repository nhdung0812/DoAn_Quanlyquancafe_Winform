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
        private int _maloainuoc;
        private float _giatien;

        public BEL_NUOC(int manuoc, string tennuoc, int maloainuoc, float giaten)
        {
            this._manuoc = manuoc;
            this._tennuoc = tennuoc;
            this._maloainuoc = maloainuoc;
            this._giatien = giaten;
        }
        public BEL_NUOC(DataRow row)
        {
            this._manuoc = (int)(row["id"]);
            this._tennuoc = row["name"].ToString();
            this._maloainuoc = (int)row["idCategory"];
            this._giatien = (float)Convert.ToDouble(row["price"]);
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
        public int Maloainuoc
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
