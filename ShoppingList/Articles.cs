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
        public List<Articles> article = new();
        public Articles() // Construct 
        {
            NameOfThing = "Not Define";
            amount = 0;
            price =  price * amount;
        }
        public decimal Cena()
        {
            price =  price * amount;
        }
        public virtual void CreateANewArticle()
        {
            //Console.ReadLine() = NameOfThing;
            WriteLine("Nazwa artykułu : ");
            NameOfThing = ReadLine();
            WriteLine("Ilość : ");
            amount = int.Parse(ReadLine());
            WriteLine("Podana kwota :");
            price = decimal.Parse(ReadLine());
            WriteLine($"Ostateczna cena : {price * amount}");
            article.Add(this);
        }
    }
}
