using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    sum1 = sum1 + num;
                else
                    sum2 = sum2 + num;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (sum1));
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("Diff = " + Math.Abs(sum1 - sum2));
            }
        }
    }
}
