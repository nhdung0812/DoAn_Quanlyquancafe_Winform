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
    public class DAL_LOAINUOC:DataPovier
    {
        public List<BEL_LOAINUOC> Lay_loai_nuoc()
        {
            List<BEL_LOAINUOC> list = new List<BEL_LOAINUOC>();
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "select * from FoodCategory";
            SqlCommand cmd = new SqlCommand(query, Getcon());
            
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach (DataRow item in dt.Rows)
                {
                    BEL_LOAINUOC loai = new BEL_LOAINUOC(item);
                    list.Add(loai);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return list;
        }
    }
}
