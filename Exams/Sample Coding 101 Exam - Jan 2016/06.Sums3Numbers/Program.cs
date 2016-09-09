using System;

namespace _06.Sums3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var min = Math.Min(Math.Min(a, b), c);
            var max = Math.Max(Math.Max(a, b), c);
            var aver = a + b + c - min - max;
            if (min + aver == max)
                Console.WriteLine("{0} + {1} = {2}", min, aver, max);
            else
                Console.WriteLine("No");
        }
    }
}
