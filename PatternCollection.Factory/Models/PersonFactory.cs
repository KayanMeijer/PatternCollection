using PatternCollection.Factory.Models.Persons;

namespace PatternCollection.Factory.Models
{
    public static class PersonFactory
    {
        public static Person CreatePerson(PersonType type)
        {
            switch (type)
            {
                case PersonType.ADMINISTRATOR:
                    return new Administrator();
                case PersonType.CHIEF:
                    return new Chief();
                case PersonType.CLERK:
                    return new Clerk();
                case PersonType.MANAGER:
                    return new Manager();
                case PersonType.PROGRAMMER:
                    return new Programmer();
                default:
                    return null;
            }
        }
    }
}
