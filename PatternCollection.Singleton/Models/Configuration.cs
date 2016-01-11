namespace PatternCollection.Singleton.Models
{
    public class Configuration
    {
        private static Configuration currentInstance;

        public string BaseUrl { get; set; }
        public int DefaultPort { get; set; }

        public static Configuration Instance
        {
            get
            {
                if (currentInstance == null)
                    currentInstance = new Configuration();

                return currentInstance;
            }
        }
    }
}
