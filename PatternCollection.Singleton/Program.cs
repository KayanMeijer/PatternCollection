using System;
using PatternCollection.Singleton.Models;

namespace PatternCollection.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = Configuration.Instance;

            config.BaseUrl = "api.itwasntme007.nl";
            config.DefaultPort = 80;

            Console.WriteLine("BaseUrl: " + config.BaseUrl);
            Console.WriteLine("DefaultPort: " + config.DefaultPort);
            Console.ReadLine();
        }
    }
}
