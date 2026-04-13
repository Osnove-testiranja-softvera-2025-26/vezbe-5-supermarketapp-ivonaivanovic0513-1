using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Models
{
    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //"\nItem: Computer; Price: 1200
        public override string ToString() {
            return "\nItem: " + this.Name + "; Price: "+this.Price;
        }
    }
}
