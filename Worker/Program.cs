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