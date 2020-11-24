using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Memento
{
    class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
