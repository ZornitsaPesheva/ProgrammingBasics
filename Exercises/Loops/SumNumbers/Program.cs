using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var x = 0;
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                sum = sum + x;
            }
            Console.WriteLine(sum);
        }
    }
}
