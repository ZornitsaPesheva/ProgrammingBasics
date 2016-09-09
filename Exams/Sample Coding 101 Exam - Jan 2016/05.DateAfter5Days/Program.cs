using System;

namespace _05.DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            d = d + 5;
            if ((m == 1 || m == 3 || m == 5 || m == 7 ||
                m == 8 || m == 10) && (d > 31))
                {
                    d = d - 31;
                    m = m + 1;
                }
            else if ((m == 4 || m == 6 | m == 9 | m == 11) && (d > 30))
                    {
                        d = d - 30;
                        m = m + 1;
                    }
            else if ((m == 2) && (d > 28))
                        {
                            d = d - 28;
                            m = m + 1;
                        }
            else if ((m == 12) && (d > 31))
            {
                d = d - 31;
                m = 1;
            }
            if (m < 10)
                Console.WriteLine("{0}.0{1}", d, m);
            else
                Console.WriteLine("{0}.{1}", d, m);
        }
    }
}
