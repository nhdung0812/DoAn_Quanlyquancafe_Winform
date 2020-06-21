using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_LOAINUOC
    {
        private int _maloainuoc;
        private string _tenloainuoc;

        public BEL_LOAINUOC(int maloainuoc, string tenloainuoc)
        {
            this._maloainuoc = maloainuoc;
            this._tenloainuoc = tenloainuoc;
        }
        public BEL_LOAINUOC(DataRow row)
        {
            this._tenloainuoc = row["Tenloainuoc"].ToString();
        }
        public int Maloainuoc
        {
            get { return _maloainuoc; }
            set { _maloainuoc = value; }
        }
        public string Tenloainuoc
        {
            get { return _tenloainuoc; }
            set { _tenloainuoc = value; }
        }
    }
}
