using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = 10000000000000.0;
            double oddMax = -10000000000000.0;
            double evenSum = 0;
            double evenMin = 10000000000000.0;
            double evenMax = -10000000000000.0;
            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    if (num < oddMin) oddMin = num;
                    if (num > oddMax) oddMax = num;
                    oddSum = oddSum + num;
                }
                else
                {
                    if (num < evenMin) evenMin = num;
                    if (num > evenMax) evenMax = num;
                    evenSum = evenSum + num;
                }
            }
            Console.WriteLine("OddSum=" + oddSum);

            Console.Write("OddMin=");
            if (oddMin == 10000000000000.0)
                Console.WriteLine("No");
            else
                Console.WriteLine(oddMin);

            Console.Write("OddMax=");
            if (oddMax == -10000000000000.0)
                Console.WriteLine("No");
            else
                Console.WriteLine(oddMax);

            Console.WriteLine("EvenSum=" + evenSum);

            Console.Write("EvenMin=");
            if (evenMin == 10000000000000.0)
                Console.WriteLine("No");
            else
                Console.WriteLine(evenMin);

            Console.Write("EvenMax=");
            if (evenMax == -10000000000000.0)
                Console.WriteLine("No");
            else
                Console.WriteLine(evenMax);
        }
    }
}
