using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShoppingList
{
    public class Articles
    {
        public string NameOfThing;
        public int amount;
        public decimal price;

        public Articles()
        {
            NameOfThing = "Not Define";
            amount = 0;
            price = 0M;
        }

        public void SetArticleValues(string nameOfThing, int _amount,decimal _price)
        {
            NameOfThing = nameOfThing;
            amount = _amount;
            price = _price;
        }
    }
}