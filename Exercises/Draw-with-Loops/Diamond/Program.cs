using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
            for (int i = 1; i <= (n - 1) / 2; i++)
            { // Draw the top part
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                var mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }
            
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                leftRight = (i - 1);
                var mid = n - 2 * leftRight - 2;
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
            }
        }
    }
}
