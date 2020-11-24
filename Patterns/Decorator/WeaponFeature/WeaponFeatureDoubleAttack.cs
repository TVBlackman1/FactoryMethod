using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    class WeaponFeatureDoubleAttack : WeaponFeature
    {
        public WeaponFeatureDoubleAttack(AbstractWeapon weapon) : base(weapon)
        { }
        public override void Attack()
        {
            base.Attack();
            base.Attack();
        }
    }
}
