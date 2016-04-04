using System;
using PatternCollection.Factory.Models;

namespace PatternCollection.Factory
{
    public class Factory
    {
        public static void Main(string[] args)
        {
            var person = PersonFactory.CreatePerson(PersonType.MANAGER);

            Console.WriteLine("Type: {0} Name: {1}", person.PersonType, person.Name);
            Console.ReadLine();
        }
    }
}
