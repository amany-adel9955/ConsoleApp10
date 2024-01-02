using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public Engine Engine { get; set; }
        public Car()
        {
            Model = "Volvo";
            Color = "Black";
            Doors = 4;
            Engine = null;
        }
        public Car(string model , string color, int doors,Engine engine)
        {
            this.Model = model;
            this.Color = color;
            this.Doors = doors;
            this.Engine = engine;

        }
        public void PrintData()
        {
            
            Console.WriteLine(Model + Color + Doors + Engine);
        }

    }
}
