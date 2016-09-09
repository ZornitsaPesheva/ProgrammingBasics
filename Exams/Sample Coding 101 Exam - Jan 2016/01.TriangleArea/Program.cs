using System;

namespace _01.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = 0;
            do
            {
                y3 = int.Parse(Console.ReadLine());
            } while (y2 != y3);
            var a = Math.Abs(x2 - x3);
            var h = y2 - y1;
            Console.WriteLine("{0}", Math.Abs(a * h / 2.00));
        }   
    }
}
