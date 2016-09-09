using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftsum = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftsum = leftsum + num;
            }
            var rightsum = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightsum = rightsum + num;
            }
            if (leftsum == rightsum)
                Console.WriteLine("Yes, sum = " + leftsum);
            else
                Console.WriteLine("No, diff = " + Math.Abs(leftsum - rightsum));
        }
    }
}
