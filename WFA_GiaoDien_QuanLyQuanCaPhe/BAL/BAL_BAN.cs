using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BEL;
using DAL;
using System.Windows.Forms;

namespace BAL
{
    public class BAL_BAN
    {
        
        public void getDSban(int dai, int cao, FlowLayoutPanel flp)
        {
            DAL_BAN ds = new DAL_BAN();
            List<BEL_BAN> getban = ds.loadDsBan();

            foreach (BEL_BAN item in getban)
            {
                
                Button btn = new Button() { Width = dai, Height = cao };
                btn.Text = item.Tenban + "\n" + item.Trangthai;
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flp.Controls.Add(btn);
            }

        }
    }
}
