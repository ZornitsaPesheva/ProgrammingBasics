using System;

namespace bonus_score
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            double b = 0;
            if (x <= 100)
                b = 5;
            else if (x > 100 && x <= 1000)
                b = x * 20 / 100;
            else
                b = x * 10 / 100;
            if (x % 2 == 0)
                b++;
            else if (x % 10 == 5)
                b += 2;
            Console.WriteLine(b);
            Console.WriteLine(x + b);
            Console.ReadLine();
        }
    }
}
