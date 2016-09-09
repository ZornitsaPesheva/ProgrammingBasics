using System;

namespace _04.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int p1 = 0;            int p2 = 0;
            int p3 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:f2}%", (100.00 * p1 / n));
            Console.WriteLine("{0:f2}%", (100.00 * p2 / n));
            Console.WriteLine("{0:f2}%", (100.00 * p3 / n));
        }
    }
}
