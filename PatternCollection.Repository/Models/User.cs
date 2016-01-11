using System;

namespace PatternCollection.Repository.Models
{
    public class User
    {
        public Guid UserId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public User(string firstName, string lastName, int age)
        {
            this.UserId = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
