using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    class WeaponFeatureModifNAttack : WeaponFeature
    {
        protected int nModifAttack = 3;
        protected int i = 0;
        public WeaponFeatureModifNAttack(AbstractWeapon weapon) : base(weapon)
        { }
        public override void Attack()
        {
            if (++i == nModifAttack)
                Console.WriteLine("Fire mod attack!");
            base.Attack();
        }
    }

}
