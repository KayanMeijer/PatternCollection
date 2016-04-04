using System;
using System.Collections.Generic;

namespace PatternCollection.Observer.Models
{
    public class Repository : IObservable<Repository>
    {
        private readonly List<IObserver<Repository>> observers;

        public int Counter { get; private set; }

        public Repository()
        {
            observers = new List<IObserver<Repository>>();
        }

        public IDisposable Subscribe(IObserver<Repository> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return null;
        }

        public void Unsubscribe(IObserver<Repository> observer)
        {
            if(observers.Contains(observer))
                observers.Remove(observer);
        }

        public void NotifySubscribers()
        {
            foreach (var observer in observers)
            {
                observer.OnNext(this);
            }
        }

        public void UpdateCounter()
        {
            this.Counter++;
            NotifySubscribers();
        }
    }
}
