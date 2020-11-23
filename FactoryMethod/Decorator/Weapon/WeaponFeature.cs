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

    class WeaponFeatureDoubleAttack: WeaponFeature
    {
        public WeaponFeatureDoubleAttack(AbstractWeapon weapon) : base(weapon)
        { }
        public override void Attack()
        {
            base.Attack();
            base.Attack();
        }
    }

    class WeaponFeatureDoubleAmmo : WeaponFeature
    {
        public override uint AmmoMagazine
        {
            get
            {
                return AmmoMagazine * 2;
            }
        }
        public WeaponFeatureDoubleAmmo(AbstractWeapon weapon) : base(weapon)
        { }
    }
}
