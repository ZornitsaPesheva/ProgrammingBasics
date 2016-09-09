using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            long sum = 0;
            var max = -10000000000000;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max) max = num;
                sum = sum + num;
            }
            if ((sum / 2.0) == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum / 2);
            }
            else
            {
                sum = sum - max;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max - sum));
            }
        }
    }
}
