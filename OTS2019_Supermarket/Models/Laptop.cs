using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Models
{
    public class Laptop : Item
    {  
        public Laptop()
        {
            this.Name = "Laptop";
            this.Price = 800;
        }

        public Laptop(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
