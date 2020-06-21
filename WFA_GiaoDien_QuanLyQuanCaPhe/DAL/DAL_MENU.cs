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
    public class DAL_MENU:DataPovier
    {
        public List<BEL_MENU> GetMenu(int id)
        {
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "select f.name, bi.count,f.price, f.price*bi.count as totalPrice FROM dbo.BillInfo AS bi , dbo.Bill as b,dbo.Food as f Where bi.idBill = b.id And bi.idFood = f.id and b.idTable = " + id;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                List<BEL_MENU> list = new List<BEL_MENU>();
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach(DataRow item in dt.Rows)
                {
                    BEL_MENU menu = new BEL_MENU(item);
                    list.Add(menu);
                }    
                return list;
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
