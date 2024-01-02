using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Manager
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectName { get; set; }

        public List<int> NewList { get; set; }

        public Manager(int id)
        {
            this.Id = id;
        }
    }
}
