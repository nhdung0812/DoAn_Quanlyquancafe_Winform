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

        public string Foodname
        {
            get
            {
                return foodname;
            }

            set
            {
                foodname = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public float TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public BEL_MENU(string foodName ,float price, int count, float totalprice = 0)
        {
            this.Foodname = foodName;
            this.Price = price;
            this.Count = count;
            this.TotalPrice = TotalPrice;

        }
        public BEL_MENU(DataRow row)
        {
            this.Foodname = row["name"].ToString();
            this.Count = (int)(row["count"]);
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            

        }
    }
}
