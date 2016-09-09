using System;

namespace Recolta
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var litri = ((x * 40 / 100.00) * y) / 2.5;
            if (litri < z)
                Console.WriteLine("It will be a tough winter! "
                    + "More {0} liters wine needed.", Math.Truncate(z - litri));
            else
            {
                Console.WriteLine("Good harvest this year! "
    + "Total wine: {0} liters.", Math.Floor(litri));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(litri - z), Math.Ceiling((litri - z) / workers));
            }
               
        }
    }
}
