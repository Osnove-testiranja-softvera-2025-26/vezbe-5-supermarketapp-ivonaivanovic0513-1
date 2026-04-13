using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Models
{
    public class Chair : Item
    {
        public Chair()
        {
            this.Name = "Computer chair";
            this.Price = 120;
        }

        public Chair(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
