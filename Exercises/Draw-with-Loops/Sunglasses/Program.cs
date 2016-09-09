using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // Print the top part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            for (int i = 0; i < n - 2; i++)
            {
                // print *///////*
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                if (i == (n - 1) / 2 - 1)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));
                //print *///////*
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            // Print the bottom part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

        }
    }
}
