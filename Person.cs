using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class Person
    {
        public string FirstName; // zwykle pola od 11 do 13 
        public string Surname;
        public int id;
        public Person() // Construct 
        {
            FirstName = "Not Define";
            Surname = "Not Define";
            id = 0;
        }
        public void CreatePerson(string firstName, string lastName)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.Surname = lastName;
        }
    }
}
