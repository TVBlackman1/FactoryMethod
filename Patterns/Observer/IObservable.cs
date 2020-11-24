using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
