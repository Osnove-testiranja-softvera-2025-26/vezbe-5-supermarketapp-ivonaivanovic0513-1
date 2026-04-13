using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Models
{
    public class Keyboard : Item
    {
        public Keyboard()
        {
            this.Name = "Keyboard";
            this.Price = 50;
        }

        public Keyboard(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
