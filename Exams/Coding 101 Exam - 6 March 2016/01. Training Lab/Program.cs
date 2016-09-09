using System;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, w;
            h = double.Parse(Console.ReadLine());
            w = double.Parse(Console.ReadLine());
            int wplaces = (int)((w - 1) / 0.7);
            int hplaces = (int)(h / 1.2);
            int places = wplaces * hplaces - 3;
            Console.WriteLine(places);
            Console.ReadLine();
        }
    }
}
