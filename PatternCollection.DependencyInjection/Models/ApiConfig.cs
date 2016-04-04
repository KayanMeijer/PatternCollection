using System;

namespace PatternCollection.DependencyInjection.Models
{
    public class ApiConfig
    {
        public string BaseUrl { get; set; }
        public int DefaultPort { get; set; }
        public int DefaultTimeout { get; set; }

        public void Print()
        {
            Console.WriteLine("BaseUrl: " + BaseUrl);
            Console.WriteLine("DefaultPort: " + DefaultPort);
            Console.WriteLine("DefaultTimeout: " + DefaultTimeout);
            Console.ReadLine();
        }
    }
}
