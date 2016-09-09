using System;

namespace SpleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            int dif = 30000 - ((365 - days) * 63 + days * 127);
            if (dif < 0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",
                    (-dif) / 60, (-dif) % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                    (dif) / 60, (dif) % 60);
            }
        }
    }
}
