using System;

namespace _07.SumsStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            for (int i = 1; i <= n; i++)
                {
                arr[i-1] = int.Parse(Console.ReadLine());
                if (i % 3 == 1)
                    sum1 = sum1 + arr[i-1];
                else if (i % 3 == 2)
                    sum2 = sum2 + arr[i-1];
                else
                    sum3 = sum3 + arr[i-1];
                }
            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
