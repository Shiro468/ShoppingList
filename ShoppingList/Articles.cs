using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class Articles
    {
        public string NameOfThing;
        public int amount;
        public decimal price;
        public Articles() // Construct 
        {
            NameOfThing = "Not Define";
            amount = 0;
            price = 0;
        }
        public decimal Cena()
        {
            decimal LastPrice;
            LastPrice = amount * price;
            return LastPrice;
        }
    }
}
