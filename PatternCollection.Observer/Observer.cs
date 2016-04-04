using System;
using PatternCollection.Observer.Controllers;
using PatternCollection.Observer.Models;

namespace PatternCollection.Observer
{
    public class Observer
    {
        public static void Main(string[] args)
        {
            var repo = new Repository();

            var ctrlA = new ControllerA();
            var ctrlB = new ControllerB();

            repo.Subscribe(ctrlA);
            repo.Subscribe(ctrlB);

            for (var i = 0; i < 10; i++)
            {
                repo.UpdateCounter();
            }

            Console.ReadLine();
        }
    }
}
