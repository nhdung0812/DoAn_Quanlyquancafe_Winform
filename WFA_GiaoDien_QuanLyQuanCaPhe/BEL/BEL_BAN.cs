using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_BAN
    {
        private int _soban;
        private string _tenban;
        private string _trangthai;

        public BEL_BAN(int soban, string tenban, string trangthai)
        {
            this._soban = soban;
            this._tenban = tenban;
            this._trangthai = trangthai;
        }
        public BEL_BAN(DataRow row)
        {
            this._soban = (int)row["id"];
            this._tenban = row["name"].ToString();
            this._trangthai = row["status"].ToString();

        }
        public int Soban
        {
            get { return _soban; }
            set { _soban = value; }
        }
        public string Tenban
        {
            get { return _tenban; }
            set { _tenban = value; }
        }
        public string Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}
