using System;
namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable judge = new Observable();
            Observer first = new Observer(1, judge);
            judge.NotifyObservers();
        }
    }
}