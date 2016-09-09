using System;

namespace Point__n_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            bool insideR1, insideR2;
            insideR1 = (x > h && x < (2 * h) && y >= h && y < (4 * h));
            insideR2 = (x > 0 && x < (3 * h) && y > 0 && y < h);
            if (insideR1 || insideR2) Console.WriteLine("inside");
            else if (((x == 0 || x == (3 * h)) && y >= 0 && y <= h) ||
                ((x == h || x == (h * 2)) && y >= h && y <= (4 * h)) ||
                (x > 0 && x < (3 * h) && ((y == 0 || y == h))) ||
                (x > h && x < (2 * h) && (y == (h * 4))))
                Console.WriteLine("border");
            else Console.WriteLine("outside");
        }
    }
}
