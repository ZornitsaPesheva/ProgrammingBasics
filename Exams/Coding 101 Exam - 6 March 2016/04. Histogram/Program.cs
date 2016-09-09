using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            float percent1 = 0;
            float percent2 = 0;
            float percent3 = 0;
            float percent4 = 0;
            float percent5 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    percent1++;
                }
                else if (num < 400)
                {
                    percent2++;
                }
                else if (num < 600)
                {
                    percent3++;
                }
                else if (num < 800)
                {
                    percent4++;
                }
                else
                {
                    percent5++;
                }
            }
            Console.WriteLine(Math.Round((100.00 * percent1 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * percent2 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * percent3 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * percent4 / n), 2) + "%");
            Console.WriteLine(Math.Round((100.00 * percent5 / n), 2) + "%");
        }
    }
}
