using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShoppingList
{
    public class Helper
    {
        public void CreateANewArticle(Articles _article)
        {
            WriteLine("Podaj nazwę artykułu: ");
            Write("-Nazwa artykułu : ");
            string NameOfThing = ReadLine();
            WriteLine("Podaj ilość artykułu:");
            Write("-Ilość : ");
            var amountAsString = Console.ReadLine();
            int amount;
            bool IntParseSucces = int.TryParse(amountAsString, out amount);
            while (!IntParseSucces)
            {
                Console.WriteLine("Podana ilość jest błędna! Spróbuj ponownie");
                Write("Ilość : ");
                amountAsString = Console.ReadLine();
                IntParseSucces = int.TryParse(amountAsString, out amount);
            }
            WriteLine("Podaj Cenę artykułu :");
            Write("Podana kwota : ");
            var priceAsString = Console.ReadLine();
            decimal price = 0M;
            bool DecimalParseSucces = decimal.TryParse(priceAsString, out price);
            while (!DecimalParseSucces)
            {
                Console.WriteLine("Podana wartość jest błędna spróbuj ponownie");
                WriteLine("Podaj Cenę artykułu :");
                Write("Podana kwota : ");
                priceAsString = Console.ReadLine();
                DecimalParseSucces = decimal.TryParse(priceAsString, out price);
            }
            price = price * amount;
            _article.SetArticleValues(NameOfThing, amount, price);
        }

        public void CreateNewList(ExampleList _myList)
        {
            WriteLine("Nazwij swoją listę zakupów :");
            Write("- Nazwa listy zakupów : ");
            string NameOfList = ReadLine();
            WriteLine($"Podaj imię i nazwisko właściciela listy {NameOfList} : ");
            Write("- Imię : ");
            string FirstName = ReadLine();
            Write("- Nazwisko : ");
            string LastName = ReadLine();
            _myList.SetListValues(FirstName, LastName, NameOfList);
        }
    }
}
