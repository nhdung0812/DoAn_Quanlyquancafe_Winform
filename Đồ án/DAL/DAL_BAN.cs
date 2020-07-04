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
    public class DAL_BAN:DataPovier
    {
        public List<BEL_BAN> loadDsBan()
        {
            List<BEL_BAN> dsban = new List<BEL_BAN>();
            string query = "SELECT * FROM dbo.TableFood";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            //DataTable ds = new DataTable();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach (DataRow item in dt.Rows)
                {
                    BEL_BAN ban = new BEL_BAN(item);
                    dsban.Add(ban);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return dsban;
        }
        public List<BEL_BAN> Upate_Ban(int id)
        {
            List<BEL_BAN> dsban = new List<BEL_BAN>();
            string query = "SELECT* FROM dbo.TableFood Where id = " + id;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            //DataTable ds = new DataTable();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach (DataRow item in dt.Rows)
                {
                    BEL_BAN ban = new BEL_BAN(item);
                    dsban.Add(ban);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return dsban;
        }
    }
}
