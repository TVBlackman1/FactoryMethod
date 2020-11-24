
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
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
