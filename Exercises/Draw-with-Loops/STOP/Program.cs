using System;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n + 1)
                + new string('_', n * 2 + 1) + new string('.', n + 1));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('.', n - i + 1)
                    + "//" + new string('_', 2 * n + 2 * i - 3)
                    + "\\\\" + new string('.', n - i + 1));
            }
            var max_ = 4 * n - 1;
            Console.WriteLine("//"
                + new string('_', (4 * n - 1) / 2 - 2)
                + "STOP!" + new string('_', (4 * n - 1) / 2 - 2)
                + "\\\\");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('.', i - 1)
                    + "\\\\" + new string('_', max_) + "//"
                    + new string('.', i - 1));
                max_ -= 2;
            }
        }
    }
}
