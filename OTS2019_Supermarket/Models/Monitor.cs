using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Models
{
    public class Monitor : Item
    {
        public Monitor ()
        {
            this.Name = "Monitor";
            this.Price = 100;
        }

        public Monitor (string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
