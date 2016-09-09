using System;

namespace _11.Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b - a >= 3)
            {
                for (int i1 = a; i1 <= b; i1++)
                {
                    for (int i2 = a; i2 <= b; i2++)
                    {
                        for (int i3 = a; i3 <= b; i3++)
                        {
                            for (int i4 = a; i4 <= b; i4++)
                            {
                                if (a <= i1 && i1 < i2 && i2 < i3 && i3 < i4 && i4 <= b)
                                    Console.WriteLine("{0} {1} {2} {3}", i1, i2, i3, i4);
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("No");
        }
    }
}
