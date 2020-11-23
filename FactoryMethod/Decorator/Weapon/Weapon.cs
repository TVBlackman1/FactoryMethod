using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    abstract class AbstractWeapon
    {
        protected uint ammoMagazine;
        public virtual uint AmmoMagazine
        {
            get
            {
                return ammoMagazine;
            }
            set
            {
                ammoMagazine = value;
            }
        }

        public abstract void Attack();

        public abstract void Reload();
    }

    class Weapon : AbstractWeapon
    {
        public Weapon(uint ammoMagazine)
        {
            AmmoMagazine = ammoMagazine;
        }
        public override void Attack() 
        {
            Console.WriteLine("Attack!");
        }

        public override void Reload()
        {
            Console.WriteLine("Reload!");
        }
    }

    class LaserRifle : Weapon
    {
        public LaserRifle(uint ammoMagazine) : base(ammoMagazine)
        { }
        public override void Attack()
        {
            base.Attack();
            HighLight();
        }
        public virtual void HighLight() 
        {
            Console.WriteLine("Highlight enemies!");
        }
    }
}
