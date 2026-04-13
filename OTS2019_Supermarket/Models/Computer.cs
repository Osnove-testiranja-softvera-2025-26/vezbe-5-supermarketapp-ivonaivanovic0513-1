using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Models
{
    public class Computer : Item
    {
        public Computer()
        {
            this.Name = "Computer";
            this.Price = 1200;
        }

        public Computer(string name, double price )
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
