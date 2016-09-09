using System;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            if (x % (m * w) == 0)
                Console.WriteLine(x / (m * w));
            else
                Console.WriteLine(x / (m * w) + 1);
        }
    }
}
