using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projtype = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            double result = 0;
            if (projtype == "premiere") result = 12 * r * c;
            else if (projtype == "normal") result = 7.5 * r * c;
            else result = 5 * r * c;
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
