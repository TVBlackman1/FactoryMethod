using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Memento
{
    class Hero
    {
        private int patrons = 10;
        private int lives = 5;

        public void Attack()
        {
            if (patrons > 0) 
            {
                patrons--;
                Console.WriteLine("Attack!");
            }
            else
            {
                Console.WriteLine("I havent patrons!");
            }
        }

        public HeroMemento SaveState()
        {
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine("Restored player!");
        }
    }
}
