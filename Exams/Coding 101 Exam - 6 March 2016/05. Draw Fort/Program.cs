using System;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int k = (((n % 2) != 0) ? 1 : 0);
            // first row
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            if (n > 4)
            {
                Console.Write(new string('_', 2 * n - n - 4 + k));
            }
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");
            //body
            for (int i = 1; i < n - 2; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }
            //before last row
            Console.Write("|");
            Console.Write(new string(' ', n / 2 + 1));
            if (n > 4)
            {
                Console.Write(new string('_', 2 * n - n - 4 + k));
            }
            Console.Write(new string(' ', n / 2 + 1));
            Console.WriteLine("|");
            // last row
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            if (n > 4)
            {
                Console.Write(new string(' ', 2 * n - n - 4 + k));
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
