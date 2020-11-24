using System;

namespace Patterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Messager messager = new Messager();
            messager.AddObserver(p1);
            messager.AddObserver(p2);
            messager.ServeSendMsg("Some text");
        }
    }
}
