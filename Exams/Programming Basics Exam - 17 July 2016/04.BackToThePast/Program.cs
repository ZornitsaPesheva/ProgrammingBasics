using System;

namespace _04.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var yearMax = int.Parse(Console.ReadLine());
            var age = 18;
            for (int i = 1800; i <= yearMax; i++)
            {
                
                if (i % 2 == 0)
                    x = x - 12000;
                else
                    x = x - 12000 - 50 * age;
                age++;
            }
            if (x >= 0)
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",
                    x);
            else
                Console.WriteLine("He will need {0:f2} dollars to survive.",
                    Math.Abs(x));
        }
    }
}
