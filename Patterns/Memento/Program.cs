using System;

namespace Patterns.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameHistory gameHistory = new GameHistory();
            Hero hero = new Hero();
            hero.Attack();
            gameHistory.History.Push(hero.SaveState());
            hero.Attack();
            hero.RestoreState(gameHistory.History.Pop());
        }
    }
}
