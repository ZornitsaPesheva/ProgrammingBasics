using System;

namespace _02.Transport_PriceConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string p = Console.ReadLine();
            double taxi = 0, bus, train;
            if (p == "day")
            {
                taxi = n * 0.79 + 0.70;
            }
            else
            {
                taxi = n * 0.90 + 0.70;
            }
            bus = n * 0.09;
            train = n * 0.06;
            if (n < 20)
            {
                Console.WriteLine(taxi);
            }
            else if (n >= 20 && n < 100)
            {
                if (taxi < bus)
                    Console.WriteLine(taxi);
                else
                    Console.WriteLine(bus);
            }
            else
            {
                var price = Math.Min(Math.Min(taxi, bus), train);
                Console.WriteLine(price);
            }
        }
    }
}
