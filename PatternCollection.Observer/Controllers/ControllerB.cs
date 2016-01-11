using System;
using PatternCollection.Observer.Models;

namespace PatternCollection.Observer.Controllers
{
    public class ControllerB : IObserver<Repository>
    {
        public void OnNext(Repository value)
        {
            Console.WriteLine("Controller B - Counter:" + value.Counter);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Controller B - Error:" + error.Message);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Controller B - Completed");
        }
    }
}
