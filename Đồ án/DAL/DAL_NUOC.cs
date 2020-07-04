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
    public class DAL_NUOC:DataPovier
    {
        public List<BEL_NUOC> Lay_nuoc(int id)
        {
            List<BEL_NUOC> list = new List<BEL_NUOC>();
            if (ConnectionState.Closed == Getcon().State)
            {
                Getcon().Open();
            }
            string query = "select * from Food where idCategory =" +id;
            SqlCommand cmd = new SqlCommand(query, Getcon());
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                foreach (DataRow item in dt.Rows)
                {
                    BEL_NUOC loai = new BEL_NUOC(item);
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
