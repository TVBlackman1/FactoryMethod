using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop ItalianCoffeeShop = new ItalianCoffeeShop();
            ItalianCoffeeShop.OrderCofee(CoffeType.Cappuccino);

            CoffeeShop AmericanCoffeeShop = new AmericanCoffeeShop();
            AmericanCoffeeShop.OrderCofee(CoffeType.Cappuccino);
        }
    }
}
