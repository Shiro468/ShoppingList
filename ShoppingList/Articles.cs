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
<<<<<<< Updated upstream
=======
        public List<Articles> article = new();
>>>>>>> Stashed changes
        public Articles() // Construct 
        {
            NameOfThing = "Not Define";
            amount = 0;
<<<<<<< Updated upstream
            price = 0;
        }
        public decimal Cena()
=======
            price =  price * amount;
        }
        public virtual void CreateANewArticle()
>>>>>>> Stashed changes
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
