using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    class WeaponFeature : AbstractWeapon
    {
        protected AbstractWeapon weapon;
        public override uint AmmoMagazine
        {
            get
            {
                return weapon.AmmoMagazine;
            }
            set
            {
                weapon.AmmoMagazine = value;
            }
        }
        public WeaponFeature(AbstractWeapon weapon)
        {
            this.weapon = weapon;
        }
        public override void Attack()
        {
            weapon.Attack();
        }

        public override void Reload()
        {
            weapon.Reload();
        }
    }
}
