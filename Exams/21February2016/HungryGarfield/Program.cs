using System;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var rate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal moneyneeded = pizzaQuantity * pizzaPrice + lasagnaQuantity * lasagnaPrice +
                sandwichQuantity * sandwichPrice;
            decimal diff = Math.Abs(money * rate - moneyneeded);
            if (money * rate >= moneyneeded)
                Console.WriteLine("Garfield is well fed, John is awesome. " +
                    "Money left: ${0:f2}.", diff / rate);
            else
                Console.WriteLine("Garfield is hungry. John is a badass. " +
                    "Money needed: ${0:f2}.", diff / rate);
        }
    }
}
