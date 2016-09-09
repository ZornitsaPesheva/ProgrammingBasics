using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int oldSum = 0;
            int sum = 0;
            int diff = 0;
            for (int i = 1; i <= n * 2; i += 2)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;
                if (i > 1 && oldSum != sum)
                    diff = Math.Abs(sum - oldSum);
                oldSum = sum;
            }
            if (diff == 0)
                Console.WriteLine("Yes, value=" + sum);
            else
                Console.WriteLine("No, maxdiff=" + diff);
        }
    }
}
