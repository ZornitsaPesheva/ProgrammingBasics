using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n) +
                    new string('*', 3 * n) +
                    new string('.', n));
            for (int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine(new string('.', i) + "*" +
                    new string('.', 5 * n - 2 * i - 2) + "*" +
                    new string('.', i));
            }
            Console.WriteLine(new string('*', 5 * n));
            var downdots = 0;
            for (int i = 1; i < 2 * n + 1; i++)
            {
                Console.WriteLine(new string('.', i) +
                    "*" + new string('.', 5 * n - 2 * i - 2) +
                    "*" + new string('.', i));
                downdots = i;
            }
            Console.WriteLine(new string('.', downdots + 1) +
                new string('*', 5 * n - 2 * downdots - 2) +
                new string('.', downdots + 1));

        }
    }
}
