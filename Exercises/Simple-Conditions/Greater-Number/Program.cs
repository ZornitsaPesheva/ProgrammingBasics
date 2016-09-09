using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if (x > y)
                Console.WriteLine("Greater number= " + x);
            else
                Console.WriteLine("Greater number= " + y);
        }
    }
}