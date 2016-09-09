using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             var n = double.Parse(Console.ReadLine());
             var w = double.Parse(Console.ReadLine());
             var l = double.Parse(Console.ReadLine());
             var m = double.Parse(Console.ReadLine());
             var o = double.Parse(Console.ReadLine());

            var surface = n * n - m * o;
            var plate = w * l;
            var plates = surface / plate;
            Console.WriteLine(plates);
            var time = plates * 0.2;
            Console.WriteLine(time);
            Console.ReadLine();
        }
    }
}
