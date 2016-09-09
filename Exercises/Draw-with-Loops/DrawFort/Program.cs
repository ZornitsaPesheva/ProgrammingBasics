using System;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");

            int k = 0;
            if ((n % 2) != 0) k = 1;
            if (n > 4)
                Console.Write(new string('_', 2 * n - n - 4 + k));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            for (int i = 1; i < n - 2 ; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }
            Console.Write("|");
            Console.Write(new string(' ', n / 2 + 1));
            if (n > 4)
                Console.Write(new string('_', 2 * n - n - 4 + k));
            Console.Write(new string(' ', n / 2 + 1));
            Console.WriteLine("|");

            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            if (n > 4)
                Console.Write(new string(' ', 2 * n - n - 4 + k));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
