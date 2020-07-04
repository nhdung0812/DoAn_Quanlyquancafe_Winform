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
        public void Insert_Bill(int id)
        {
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "exec USP_InsertBill "+ id;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                cmd.ExecuteNonQuery();
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
        public int getMaxID()
        {
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "SELECT MAX(id) FROM dbo.Bill";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch 
            {
                return 1;
            }
            finally
            {
                Getcon().Close();
            }
        }
        public void CheckOut(int id)
        {
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "UPDATE dbo.Bill SET status = 1 WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                cmd.ExecuteNonQuery();
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
