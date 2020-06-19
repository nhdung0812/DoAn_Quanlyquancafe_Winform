using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {
        protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-URLSKEQ;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
    }
}
