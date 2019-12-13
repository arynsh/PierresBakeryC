using System;
using System.Collections.Generic;

namespace Bakery
{
    class Bread
    {
        public int BreadQuantity { get; set; }
        public int Price { get; set; }
        public Bread(int breadQuantity, int price)
        {
           BreadQuantity = breadQuantity;
           Price = price;
        }
       public int CalculateCost()
        {
            int cost;

                cost = (10 * (BreadQuantity / 3)) + (5 * (BreadQuantity % 3));
            
            return cost;
        }
    }

    class Pastry
    {
        public int PastryQuantity { get; set; }
        public int Price { get; set; }

        public Pastry(int pastryQuantity, int price)
        {
            PastryQuantity = pastryQuantity;
            Price = price;
        }
        public int CalculateCost()
        {
            int cost;

            if (PastryQuantity <= 2)
            {
                cost = PastryQuantity * 2;
            }
            else
            {
                cost = (5 * (PastryQuantity / 3)) + (2 * (PastryQuantity % 3));   
            }
            
            return cost;
        }
    }
    
}
