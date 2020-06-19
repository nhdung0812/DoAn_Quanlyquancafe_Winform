using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
namespace DAL
{
    public class DAL_TAIKHOAN:DataPovier
    {
        public DataTable DsNhapvien()
        {
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "SELECT * FROM dbo.Account";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                Getcon().Close();
            }
        }
        // Kiểm tra đăng nhập
        public bool login(string tendangnhap, string matkhau)
        {
            if (Getcon().State == ConnectionState.Closed)
            {
                Getcon().Open();
            }
            string query = "SELECT * FROM dbo.Account WHERE UserName = '" + tendangnhap + "' AND PassWord = '" + matkhau + "'";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                DataTable tk = new DataTable();
                SqlDataReader rd = cmd.ExecuteReader();
                tk.Load(rd);
                return tk.Rows.Count > 0;
            }
            catch
            {
                throw;
            }
        }
        public List<BEL_TAIKHOAN> load_User()
        {
            List<BEL_TAIKHOAN> list_user = new List<BEL_TAIKHOAN>();
            string query = "SELECT UserName FROM dbo.Account";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            //DataTable ds = new DataTable();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach (DataRow item in dt.Rows)
                {
                    BEL_TAIKHOAN user = new BEL_TAIKHOAN(item);
                    list_user.Add(user);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return list_user;
        }
    }
}
