using System;

namespace _01_VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m; // цени на зеленчуци и плодове
            int v, f; // килограми зеленчуци и плодове
            n = double.Parse(Console.ReadLine());
            m = double.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            var result = n * v + m * f;
            Console.WriteLine(result / 1.94);
            Console.ReadLine();
        }
    }
}
