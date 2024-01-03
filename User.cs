using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class User
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int Password { get; set; }
        public bool Role { get; set; }
        public List<Account> NewAccount { get; set; }
        public List<Car> ShoppingCart { get; set; }

        public void PrintData()
        {
            Console.WriteLine(Id +Name + Password +Role);
           
        }
        public int AddToCart()
        {
            int AddCar = 0;
            if(ShoppingCart.Count == 0)
            {
                Console.WriteLine("your shopping cart is empty");
            } 
            else
            {
                AddCar++;
            }
            return AddCar;
        }
       public void CreateAccount()
        {
            int AddAccount = 0;
            foreach(var c in NewAccount)
            {
                if (Role == false)
                {
                    AddAccount++;
                }
            }  
        }
        public void Login(string name, int password)
        {

        }
    }
}
