using System;

namespace _09.PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*" + new string(' ', n - i));
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = n - i - 1; j > 0 ; j--)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*" + new string(' ', i));
            }
        }
    }
}
