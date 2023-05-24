using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ShoppingList
{
    public class ExampleList
    {
        public string FirstName;
        public string LastName;
        public string NameOfList;
        public DateTime LastDate;
        private List<Articles> list = new List<Articles>();

        public ExampleList() 
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            NameOfList = string.Empty;
            LastDate = DateTime.Now;
        }

        public void SetListValues(string _FirstName, string _LastName, string _NameOfList)
        {
            FirstName = _FirstName; 
            LastName = _LastName;
            NameOfList = _NameOfList;
        }

        public void SetMyArticle(Articles _article)
        {
            list.Add(_article);
        }
        
        public void CheckMyArticles()
        {
            decimal priceForAll = 0M;
            foreach (Articles item in list)
            {
                WriteLine(" ");
                WriteLine($"Nazwa artykułu : {item.NameOfThing}");
                WriteLine($"Ilość : {item.amount}");
                WriteLine($"Cena : {item.price}");
                priceForAll += item.price;
                WriteLine(" ");
            }
            WriteLine($"Całkowita cena twoich produktów : {priceForAll}");
            WriteLine(" ");
        }
    }
}
