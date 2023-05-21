using ShoppingList;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Console;
bool start = true;
bool back = false;
//WriteLine("Witaj czy chcesz utworzyć swoją listę zakupów ?");
//WriteLine("Naciśnij Enter jeśli chcesz przejść dalej");
WriteLine("Witaj w edytorze twojej Listy Zakupów");
if (back == false)
{
    WriteLine("Podaj imie i nazwisko Właściciela Listy Zakupów , jak i nazwę listy Zakupów");
    ExampleList myList = new(ReadLine(), ReadLine(), ReadLine(),DateTime.Now);
    WriteLine($"Utworzono Listę {myList.FirstName} {myList.LastName} o nazwie {myList.NameOfList} dnia {myList.LastDate}");
 
        if (start == true)
        {
            WriteLine($"Podaj nazwę, ilość i cenę pierwszego artykułu");
            Articles articles1 = new Articles()
            {
                NameOfThing = ReadLine(),
                amount = int.Parse(ReadLine()),
                price = int.Parse(ReadLine()),
            };
            WriteLine($"Stworzyłeś {articles1.NameOfThing} w ilości {articles1.amount} o kwocie {articles1.price}");
            WriteLine($"Czy chcesz dodać więcej artykułów do swojej listy ?");
            WriteLine($"Naciśnij y jeśli się zgadzasz naciśnij n jeśli chcesz zakończyć");
            if(ReadKey().Key == ConsoleKey.Y)
            {

            }
            else if( ReadKey().Key == ConsoleKey.N)
            {

            }
        }
}
else
{
    Environment.Exit(0);
}