using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class BAL_NUOC
    {
        public List<BEL_NUOC> lay_nuoc(int id)
        {
            DAL_NUOC nuoc = new DAL_NUOC();
            return nuoc.Lay_nuoc(id);
        }
    }
}
