using System;
using PatternCollection.Observer.Models;

namespace PatternCollection.Observer.Controllers
{
    public class ControllerA : IObserver<Repository>
    {
        public void OnNext(Repository value)
        {
            Console.WriteLine("Controller A - Counter:" + value.Counter);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Controller A - Error:" + error.Message);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Controller A - Completed");
        }
    }
}
