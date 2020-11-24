using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    class Person : IObserver
    {
        public void Update()
        {
            Console.WriteLine("I got message!");
        }
    }
}
