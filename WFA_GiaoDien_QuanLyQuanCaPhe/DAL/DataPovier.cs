using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataPovier
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-SB4FNSQ\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
        public DataTable dt = new DataTable();
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
