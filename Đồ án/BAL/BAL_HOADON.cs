using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using BAL;
namespace BAL
{
    public class BAL_HOADON
    {
        public void Insert_bill(Button bt,ListView lv, ComboBox cb, NumericUpDown nb,TextBox tx)
        {
            DAL_HOADON hd = new DAL_HOADON();
            DAL_THONGTINHOADON tt = new DAL_THONGTINHOADON();
            BAL_BAN ban = new BAL_BAN();

            BEL_BAN tb = lv.Tag as BEL_BAN;

             hd.Insert_Bill(tb.Soban);

            int idBill = hd.GetBill(tb.Soban);
            int idFood = (cb.SelectedItem as BEL_NUOC).Manuoc;
            int count = (int)nb.Value;

            if(idBill == -1)
            {
                hd.Insert_Bill(idBill);
                tt.InsertBillInfo(hd.getMaxID(),idFood,count);
            }
            else
            {
                tt.InsertBillInfo(idBill, idFood, count);
            }

            ban.get_lv(lv,tx);
            ban.showBill(tb.Soban);
        }
        public int Check_out(ListView lv,TextBox tx)
        {
            BEL_BAN table = lv.Tag as BEL_BAN;
            DAL_HOADON bill = new DAL_HOADON();
            int idBill = bill.GetBill(table.Soban);

            return idBill;
        }
    }
}
