using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoS_small
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total { get; set; }

        public Item(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
