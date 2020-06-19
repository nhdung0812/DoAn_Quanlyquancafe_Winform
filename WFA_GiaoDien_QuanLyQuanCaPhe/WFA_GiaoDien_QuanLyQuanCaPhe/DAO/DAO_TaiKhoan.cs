using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WFA_GiaoDien_QuanLyQuanCaPhe.DAO
{
    public class DAO_TaiKhoan : DataProvider
    {
        public DataTable get_TaiKhoan()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Account", con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }

    }
}
