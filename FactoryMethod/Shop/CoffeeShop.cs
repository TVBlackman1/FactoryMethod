using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class CoffeeShop
    {
        protected abstract Coffee CreateCoffee(CoffeType type);

        public Coffee OrderCofee(CoffeType type)
        {
            Coffee coffee = CreateCoffee(type);
            coffee.GrindCoffee();
            coffee.MakeCoffee();
            coffee.PourIntoCup();

            Console.WriteLine("Your coffee, you are welcome!");
            return coffee;
        }

    }
}
