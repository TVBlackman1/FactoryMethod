using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Coffee
    {
        public void GrindCoffee() { }

        public void MakeCoffee() { }

        public void PourIntoCup() { }
    }

    class ItalianStyleAmericano : Coffee { }
    class ItalianStyleCappuccino : Coffee { }
    class ItalianStyleCaffeLatte : Coffee { }
    class ItalianStyleEspresso : Coffee { }

    class AmericanStyleAmericano : Coffee { }
    class AmericanStyleCappuccino : Coffee { }
    class AmericanStyleCaffeLatte : Coffee { }
    class AmericanStyleEspresso : Coffee { }

    enum CoffeType
    {
        Espresso,
        Americano,
        CaffeLatte,
        Cappuccino
    }


}
