using System;

namespace Rectangle_of_NxN_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}