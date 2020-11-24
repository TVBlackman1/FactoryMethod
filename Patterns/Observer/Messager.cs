using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    class Messager : IObservable
    {
        List<IObserver> persons;

        public Messager()
        {
            persons = new List<IObserver>();
        }

        public void ServeSendMsg(string someString)
        {
            // some code
            NotifyObservers();
        }
        public void AddObserver(IObserver o)
        {
            persons.Add(o);
        }

        public void NotifyObservers()
        {
            foreach(IObserver o in persons)
            {
                o.Update();
            }
        }

        public void RemoveObserver(IObserver o)
        {
            persons.Remove(o);
        }
    }
}
