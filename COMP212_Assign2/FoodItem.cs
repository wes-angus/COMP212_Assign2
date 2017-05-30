using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalc
{
    class FoodItem
    {
        public string name { get; set; }
        public string category { get; set; }
        public float price { get; set; }

        public FoodItem(string name, string category, float price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
    }
}
