using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingList
{
    public class ExampleList
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? NameOfList { get; init; }
        public DateTime? LastDate { get; init; }

        public ExampleList(string firstName, string lastName , string nameOfList , DateTime created) 
        {
            FirstName = firstName;
            LastName = lastName;
            NameOfList = nameOfList;
            LastDate = created;
        }
    }
}
