using System;
using PatternCollection.Builder.Models;

namespace PatternCollection.Builder
{
    public class Builder
    {
        public static void Main(string[] args)
        {
            var data = new UserData();
            data.Print();

            Console.WriteLine("-------------------------------------------------------------------------");

            var completeData = data.ToBuilder()
                .UserName("ItWasntMe007")
                .FirstName("Kayan")
                .LastName("Meijer")
                .Email("k.meijer1@live.nl")
                .Age(22)
                .Build();

            completeData.Print();

            Console.ReadLine();
        }
    }
}
