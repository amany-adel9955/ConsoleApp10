using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Account
    {
        public string Name { get; set; }
        public int Password { get; set; }
        public List<User> Users { get; set; }

        public Account()
        {
            Name = "No name";
            Password = 11111;
            List<User> Users = null;
        }

        public Account(string name, int password,List<User>Users)
        {
            this.Name = name;
            this.Password = password;
            this.Users = new List<User>();
           
        }
    }
}
