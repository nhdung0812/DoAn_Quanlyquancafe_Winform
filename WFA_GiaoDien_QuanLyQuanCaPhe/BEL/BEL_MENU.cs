using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_MENU
    {
        private string foodname;
        private float price;
        private int count ;
        private float totalPrice;
        public string FoodName { get => foodname; set => foodname = value; }
        public float Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
       

        public BEL_MENU(string foodName ,float price, int count, float totalprice = 0)
        {
            this.foodname = foodName;
            this.price = price;
            this.count = count;
            this.totalPrice = totalPrice;

        }
        public BEL_MENU(DataRow row)
        {
            this.foodname = row["name"].ToString();
            this.count = (int)(row["count"]);
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            

        }
    }
}
