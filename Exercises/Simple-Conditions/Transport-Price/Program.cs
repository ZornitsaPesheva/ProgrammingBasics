using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string p = Console.ReadLine();
            double t = 0, a, tr;
            if (p == "day")
                t = n * 0.79 + 0.70;
            else if (p == "night")
                t = n * 0.90 + 0.70;
            else
                Console.WriteLine("invalid time");
            a = n * 0.09;
            tr = n * 0.06;
            if (n < 20)
                Console.WriteLine(t);
            else if (n >= 20 && n < 100)
                if (t < a)
                    Console.WriteLine(t);
                else
                    Console.WriteLine(a);
            else if (n >= 100)
            {
                var price = Math.Min(Math.Min(t, a), tr);
                Console.WriteLine(price);
            }
        }
    }
}
