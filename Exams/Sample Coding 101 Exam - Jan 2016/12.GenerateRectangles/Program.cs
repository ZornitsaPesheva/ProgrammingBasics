using System;

namespace _12.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            if (4 * n * n >= m)
            {
                for (int x1 = -n; x1 <= n; x1++)
                {
                    for (int y1 = -n; y1 <= n; y1++)
                    {
                        for (int x2 = -n; x2 <= n; x2++)
                        {
                            for (int y2 = -n; y2 <= n; y2++)
                            {
                                if (x1 < x2 && y1 < y2)
                                {
                                    if ((x2 - x1) * (y2 - y1) >= m)
                                        Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
                                            x1, y1, x2, y2, (x2 - x1) * (y2 - y1));
                                }
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("No");
        }
    }
}
