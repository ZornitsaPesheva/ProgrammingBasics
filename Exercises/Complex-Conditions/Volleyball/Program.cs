using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            double igri = h;
            var weekendSofia = 48 - h;
            var igriSof = weekendSofia * 3.0 / 4;
            var igriHol = p * 2.0 / 3;
            igri = igri + igriSof + igriHol;
            if (year == "leap") igri = igri + igri * 15 / 100;
            Console.WriteLine(Math.Truncate(igri));
        }
    }
}
