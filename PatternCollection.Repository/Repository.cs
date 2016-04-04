using PatternCollection.Repository.Database;
using PatternCollection.Repository.Models;

namespace PatternCollection.Repository
{
    public class Repository
    {
        public static void Main(string[] args)
        {
            var context = new PatternCollectionEntities();
            var repo = new UserRepository(context);
        }
    }
}
