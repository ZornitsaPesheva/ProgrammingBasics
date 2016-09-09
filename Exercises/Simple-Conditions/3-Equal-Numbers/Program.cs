using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if (a == b && b == c)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
