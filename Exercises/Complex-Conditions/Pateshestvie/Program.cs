using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pateshestvie
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            string somewhere = "";
            if (budget <= 100) somewhere = "Bulgaria";
            else if (budget <= 1000) somewhere = "Balkans";
            else somewhere = "Europe";
            switch (somewhere)
            {
                case "Bulgaria":
                    Console.WriteLine("Somewhere in Bulgaria");
                    if (season == "summer")
                        Console.WriteLine("Camp - {0:f2}", budget * 30 / 100);
                    else
                        Console.WriteLine("Hotel - {0:f2}", budget * 70 / 100);
                    break;
                case "Balkans":
                    Console.WriteLine("Somewhere in Balkans");
                    if (season == "summer")
                        Console.WriteLine("Camp - {0:f2}", budget * 40 / 100);
                    else
                        Console.WriteLine("Hotel - {0:f2}", budget * 80 / 100);
                    break;
                case "Europe":
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", budget * 90 / 100);
                    break;
            }
        }
    }
}
