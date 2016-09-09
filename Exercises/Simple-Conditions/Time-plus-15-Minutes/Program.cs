using System;

namespace Time_plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            m = m + 15;
            if (m > 59)
            {
                h = h + 1;
                m = m - 60;
            }
            if (h > 23)
            {
                h = 0;
            }
            if (m < 10)
                Console.WriteLine(h + ":0" + m);
            else if (m >= 10)
                Console.WriteLine(h + ":" + m);
            Console.ReadLine();
        }
    }
}
