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
        ListView view;
        public void getDSban(int dai, int cao, FlowLayoutPanel flp , ListView lv)
        {
            DAL_BAN ds = new DAL_BAN();
            List<BEL_BAN> getban = ds.loadDsBan();

            foreach (BEL_BAN item in getban)
            {
                
                Button btn = new Button() { Width = dai, Height = cao };
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
                flp.Controls.Add(btn);
            }
            view = lv;
        }
        public void showBill(int id)
        {
            view.Items.Clear();
            DAL_MENU menu = new DAL_MENU();
            List<BEL_MENU> list = menu.GetMenu(id);
            foreach (BEL_MENU item in list)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                view.Items.Add(lsvItem);
            }


        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BEL_BAN).Soban;
            showBill(tableID);
            
        }
    }
}
