namespace PatternCollection.DependencyInjection.Models
{
    public class DependencyInjectionExample
    {
        public ApiConfig ApiConfig { get; private set; }

        public void Run()
        {
            ApiConfig.Print();
        }
    }
}
