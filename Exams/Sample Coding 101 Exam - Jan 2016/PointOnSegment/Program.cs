using System;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var m = 0;
            if (first > second)
            {
                m = second;
                second = first;
                first = m;
            }
               
            if ((point >= first && point <= second))
                Console.WriteLine("in");
            else
                Console.WriteLine("out");
            if (point - first < second - point)
                Console.WriteLine(Math.Abs(point - first));
            else
                Console.WriteLine(Math.Abs(second - point));
        }
    }
}
