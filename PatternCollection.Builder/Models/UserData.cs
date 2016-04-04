using System;
using PatternCollection.Builder.Interfaces;

namespace PatternCollection.Builder.Models
{
    public class UserData : IModelBuilder<UserDataBuilder>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public UserDataBuilder ToBuilder()
        {
            return new UserDataBuilder(this);
        }

        public void Print()
        {
            Console.WriteLine("Username: " + UserName);
            Console.WriteLine("FirstName: " + FirstName);
            Console.WriteLine("LastName: " + LastName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Age: " + Age);
        }
    }
}
