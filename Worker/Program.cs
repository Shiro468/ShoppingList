using ShoppingList;
using System.Diagnostics;
using System.Threading.Channels;
using static System.Console;
bool start = true;
bool back = false;
//bool go;
WriteLine("Witaj czy chcesz utworzyć swoją listę zakupów ?");
WriteLine("Naciśnij Enter jeśli chcesz przejść dalej");

//while (ReadKey().Key != ConsoleKey.Escape)
if(ReadKey().Key == ConsoleKey.Enter)
{
<<<<<<< Updated upstream
    //start = true;
    WriteLine("Podaj imie i nazwisko Właściciela Listy Zakupów , jak i nazwę listy Zakupów");
    ExampleList myList = new(ReadLine(), ReadLine(), ReadLine(),DateTime.Now);
    WriteLine($"Utworzono Listę {myList.FirstName} {myList.LastName} o nazwie {myList.NameOfList} dnia {myList.LastDate}");
    if(back == false)
    {
        if (start == true)
        {
            WriteLine($"Podaj nazwę, ilość i cenę pierwszego artykułu");

            start = false;
=======
        WriteLine("Podaj imie i nazwisko Właściciela Listy Zakupów , jak i nazwę listy Zakupów");
        ExampleList myList = new(ReadLine(), ReadLine(), ReadLine(),DateTime.Now);
        WriteLine($"Utworzono Listę {myList.FirstName} {myList.LastName} o nazwie {myList.NameOfList} dnia {myList.LastDate}");

        if (start == true)
        {
            WriteLine($"Podaj nazwę, ilość i cenę pierwszego artykułu");
            Articles articles1 = new Articles()
            {
                //NameOfThing = ReadLine(),
                //amount = int.Parse(ReadLine()),
                //price = decimal.Parse(ReadLine()),
            };
            articles1.CreateANewArticle();    
            WriteLine($"Stworzyłeś {articles1.NameOfThing} w ilości {articles1.amount} o kwocie {articles1.price}");
            WriteLine($"Czy chcesz dodać więcej artykułów do swojej listy ?");
            WriteLine($"Naciśnij y jeśli się zgadzasz naciśnij n jeśli chcesz zakończyć");

            if(ReadKey().Key == ConsoleKey.Y)
            {
                start = true;
            }
            else if( ReadKey().Key == ConsoleKey.N)
            {
                start = false;
            }
>>>>>>> Stashed changes
        }
    }
  
}
else
{
    Environment.Exit(0);
}
//Person Identify1 = new Person();
//ExampleList FridayList = new();
//Write("Imie: ");
//Identify1.FirstName = ReadLine();
//Write("Nazwisko: ");
//Identify1.Surname = ReadLine();
//WriteLine($"Lista Zakupów {Identify1.FirstName} {Identify1.Surname}");
//Write($"Podaj nazwę artykułu:");
//FridayList.NameOfThing = ReadLine();