using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // получатель уведомления
    class Observer : IObserver
    {
        int Id { get; set; }
        IObservable observer;

        public Observer(int id, IObservable obs)
        {
            observer = obs;
            this.Id = id;
            obs.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine($"Получил сигнал и перестал быть наблюдателем {this.Id}");
            observer.RemoveObserver(this);
        }
    }
}
