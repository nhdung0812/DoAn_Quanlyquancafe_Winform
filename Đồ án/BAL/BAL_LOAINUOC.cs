using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
namespace BAL
{
    public class BAL_LOAINUOC
    {
        public List<BEL_LOAINUOC> get_categoryFood()
        {
            DAL_LOAINUOC dt = new DAL_LOAINUOC();
            return dt.Lay_loai_nuoc();
        }
    }
}
