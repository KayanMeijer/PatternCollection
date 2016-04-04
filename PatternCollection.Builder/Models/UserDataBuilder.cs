using PatternCollection.Builder.Interfaces;

namespace PatternCollection.Builder.Models
{
    public class UserDataBuilder : IBuilder<UserData>
    {
        private string username;
        private string firstname;
        private string lastname;
        private string email;
        private int age;

        public UserDataBuilder()
        {
            
        }

        public UserDataBuilder(UserData model)
        {
            this.username = model.UserName;
            this.firstname = model.FirstName;
            this.lastname = model.LastName;
            this.email = model.Email;
            this.age = model.Age;
        }

        public UserDataBuilder UserName(string value)
        {
            this.username = value;
            return this;
        }

        public UserDataBuilder FirstName(string value)
        {
            this.firstname = value;
            return this;
        }

        public UserDataBuilder LastName(string value)
        {
            this.lastname = value;
            return this;
        }

        public UserDataBuilder Email(string value)
        {
            this.email = value;
            return this;
        }

        public UserDataBuilder Age(int value)
        {
            this.age = value;
            return this;
        }

        public UserData Build()
        {
            return new UserData()
            {
                UserName = username,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Age = age
            };
        }
    }
}
