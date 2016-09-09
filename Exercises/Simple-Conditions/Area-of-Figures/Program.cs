using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var x = double.Parse(Console.ReadLine());
                Console.WriteLine(x * x);
            }
            else if (figure == "rectangle")
            {
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                Console.WriteLine(x * y);
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            else if (figure == "triangle")
            {
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                Console.WriteLine(x * y / 2);
            }
        }
    }
}
