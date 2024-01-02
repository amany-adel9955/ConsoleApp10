using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Engine
    {
        public string Type { get; set; }
        public string Power { get; set; }
        public Engine()
        {
            Type = "no type";
            Power = "10 horses";
        }
        public Engine(string type, string power)
        {
            this.Type = type;
            this.Power = power;
        }
    }
}
