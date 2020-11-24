using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class AmericanCoffeeShop : CoffeeShop
    {
        protected override Coffee CreateCoffee(CoffeType type)
        {
            Coffee coffee = null;

            switch (type)
            {
                case CoffeType.Americano:
                    coffee = new AmericanStyleAmericano();
                    break;
                case CoffeType.Espresso:
                    coffee = new AmericanStyleEspresso();
                    break;
                case CoffeType.Cappuccino:
                    coffee = new AmericanStyleCappuccino();
                    break;
                case CoffeType.CaffeLatte:
                    coffee = new AmericanStyleCaffeLatte();
                    break;
            }

            return coffee;
        }
    }
}
