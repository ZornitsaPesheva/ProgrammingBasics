using System;

namespace Peperuda
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n - 2) + "\\" + 
                ' ' + "/" + new string('*', n - 2));
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.WriteLine(new string('-', n - 2) + "\\" +
                ' ' + "/" + new string('-', n - 2));
                Console.WriteLine(new string('*', n - 2) + "\\" +
                ' ' + "/" + new string('*', n - 2));
            }

            Console.WriteLine(new string(' ', n - 1) + "@" +
                new string(' ', n - 1));

            Console.WriteLine(new string('*', n - 2) + "/" +
                ' ' + "\\" + new string('*', n - 2));
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.WriteLine(new string('-', n - 2) + "/" +
                ' ' + "\\" + new string('-', n - 2));
                Console.WriteLine(new string('*', n - 2) + "/" +
                ' ' + "\\" + new string('*', n - 2));
            }
        }
    }
}
