namespace PatternCollection.Factory.Models.Persons
{
    public class Manager : Person
    {
        public Manager()
        {
            this.Name = "Manager";
            this.PersonType = PersonType.MANAGER;
        }
    }
}
