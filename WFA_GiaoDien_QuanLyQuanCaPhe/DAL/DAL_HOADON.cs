using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HOADON:DataPovier
    {
        public int GetBill(int id)
        {
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "select * from dbo.Bill where idTable = "+ id + " and status = 0";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                {
                    BEL_HOADON bill = new BEL_HOADON(dt.Rows[0]);
                    return bill.MaHD;
                }    
                return -1;
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
    }
}
