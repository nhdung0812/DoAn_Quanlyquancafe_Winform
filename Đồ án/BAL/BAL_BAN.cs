using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BEL;
using DAL;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace BAL
{
    public class BAL_BAN
    {
        public static int dai = 94;
        public static int Cao = 94;
        private ListView view;
        private TextBox tb;
        private FlowLayoutPanel flp;
        private int numTable;
        public void getDSban(FlowLayoutPanel flp1 , ListView lv, TextBox tx)
        {
            DAL_BAN ds = new DAL_BAN();
            List<BEL_BAN> getban = ds.loadDsBan();

            foreach (BEL_BAN item in getban)
            {
                
                Button btn = new Button() { Width = dai, Height = Cao };
                btn.Text = item.Tenban + "\n" + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flp1.Controls.Add(btn);
            }
            view = lv;
            tb = tx;
            flp = flp1;
        }
        public void showBill(int id)
        {
            view.Items.Clear();
            float totalPrice = 0;
            DAL_MENU menu = new DAL_MENU();
            List<BEL_MENU> list = menu.GetMenu(id);
            foreach (BEL_MENU item in list)
            {
                ListViewItem lsvItem = new ListViewItem(item.Foodname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                view.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("Vi-VN");
            tb.Text = totalPrice.ToString("c", culture);

        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BEL_BAN).Soban;
            view.Tag = (sender as Button).Tag;
            showBill(tableID);
            BEL_BAN table = view.Tag as BEL_BAN;
            update_ban(tableID ,flp);
        }
        public void get_lv(ListView lv, TextBox tx)
        {
            view = lv;
            tb = tx;
        }

        public void update_ban(int id, FlowLayoutPanel flp)
        {
            DAL_BAN ds = new DAL_BAN();
            List<BEL_BAN> getban = ds.Upate_Ban(id);

            foreach (BEL_BAN item in getban)
            {

                Button btn = new Button() { Width = dai, Height = Cao };
                btn.Text = item.Tenban + "\n" + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                /*flp.Controls.Add(btn);*/
            }
        }
    }
}
