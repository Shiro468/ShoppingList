using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class ExampleList : Person
    {
        //pole  Person  person1 
        public int id;
        public string FirstName;
        public string LastName;
        public string NameOfThing;
        public  int amount;
        public  decimal price;

        public ExampleList() 
        {
            FirstName = "NOT DEFINE";
            LastName = "NOT DEFINE";
            NameOfThing = "NOT DEFINE";
            amount = 0;
            price = 0;
            id = 0;
        }
        /*
        public void CreateMyList(string nameOfThing, int amount,decimal price)
        {
            ExampleList exampleList = new ExampleList();
            exampleList.NameOfThing = nameOfThing;
            exampleList.amount = amount;
            exampleList.price = price;
        }
        */
    }
}
