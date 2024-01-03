using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }
        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()  // calc the total price of cars in shopping list
        {
            decimal TotalCost = 0;

            foreach(var c in ShoppingList)
            {
                TotalCost += c.Price;
            }
            ShoppingList.Clear();
            return TotalCost;
        }

            
    }
}
