using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //сигнал
    class Observable : IObservable
{
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            var copyObservers = new List<IObserver>(observers); // Создаем копию списка наблюдателей

            foreach (var observer in copyObservers)
            {
                observer.Update();
            }
        }
    }
}