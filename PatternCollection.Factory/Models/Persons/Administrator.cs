namespace PatternCollection.Factory.Models.Persons
{
    public class Administrator : Person
    {
        public Administrator()
        {
            this.Name = "Administrator";
            this.PersonType = PersonType.ADMINISTRATOR;
        }
    }
}
