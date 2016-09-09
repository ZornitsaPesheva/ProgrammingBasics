using System;

namespace _10.RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', 2 * n));
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
            }
            Console.WriteLine("%" + new string(' ', n - 2) + "**" +
                new string(' ', n - 2) + "%");
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
            }
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
