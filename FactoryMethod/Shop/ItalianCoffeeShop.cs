using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ItalianCoffeeShop: CoffeeShop
    {
        protected override Coffee CreateCoffee(CoffeType type)
        {
            Coffee coffee = null;

            switch (type)
            {
                case CoffeType.Americano:
                    coffee = new ItalianStyleAmericano();
                    break;
                case CoffeType.Espresso:
                    coffee = new ItalianStyleEspresso();
                    break;
                case CoffeType.Cappuccino:
                    coffee = new ItalianStyleCappuccino();
                    break;
                case CoffeType.CaffeLatte:
                    coffee = new ItalianStyleCaffeLatte();
                    break;
            }

            return coffee;
        }
    }
}
