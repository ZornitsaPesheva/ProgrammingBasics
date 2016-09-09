using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            float p1 = 0;
            float p2 = 0;
            float p3 = 0;
            float p4 = 0;
            float p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200) p1++;
                else if (num < 400) p2++;
                else if (num < 600) p3++;
                else if (num < 800) p4++;
                else p5++; 
            }
            Console.WriteLine(Math.Round((100.00 * p1 / n), 2) +"%");
            Console.WriteLine(Math.Round((100.00 * p2 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * p3 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * p4 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * p5 / n), 2) + "%");
        }
    }
}
