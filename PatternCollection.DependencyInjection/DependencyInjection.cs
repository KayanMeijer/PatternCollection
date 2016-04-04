using PatternCollection.DependencyInjection.Models;
using Spring.Context.Support;

namespace PatternCollection.DependencyInjection
{
    public class DependencyInjection
    {
        public static void Main(string[] args)
        {
            var context = ContextRegistry.GetContext();
            var instance = context.GetObject<DependencyInjectionExample>("DependencyInjectionExample");

            instance.Run();
        }
    }
}
