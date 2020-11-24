using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
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
