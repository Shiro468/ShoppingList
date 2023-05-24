using ShoppingList;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        bool start = true;

        WriteLine("Witaj w edytorze twojej Listy Zakupów");
        ExampleList myList = new();
        Helper Factorer = new();
        Factorer.CreateNewList(myList);
        WriteLine($"Utworzono Listę {myList.NameOfList} Pana/Pani {myList.FirstName} {myList.LastName} dnia {DateTime.Now}");

        while (start == true)
        {
            WriteLine();
            WriteLine($"Podaj nazwę, ilość i cenę artykułu");
            Articles article1 = new();
            Factorer.CreateANewArticle(article1);
            myList.SetMyArticle(article1);
            WriteLine($"Stworzyłeś {article1.NameOfThing} w ilości {article1.amount} o kwocie {article1.price}");
            WriteLine($"Czy chcesz dodać więcej artykułów do swojej listy ?");
            WriteLine($"Naciśnij y jeśli się zgadzasz naciśnij n jeśli chcesz zakończyć, Naciśnij t jeśli chcesz przejrzeć swoje artykuły");

            char letter = ReadKey().KeyChar;
            if (letter == 'y')
            {

            }
            else if (letter == 'n')
            {
                start = false;
            }
            else if (letter == 't')
            {
                myList.CheckMyArticles();
                WriteLine($"Czy chcesz wrócić do dodawania artykułów? Y/N");

                if (ReadKey().Key == ConsoleKey.Y)
                {
                    start = true;
                }
                else
                {
                    Environment.Exit(0);
                    /*
                     * Dowiedzieć się jak zapisać swoją listę zakupów 
                     */ 
                }
            }
        }
    }
}