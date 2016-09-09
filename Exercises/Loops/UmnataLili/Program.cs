using System;

namespace UmnataLili
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            int money = 0;
            int toys = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    money = money + ((i / 2) * 10) - 1;
                else
                    toys++;
            }
            money = money + toys * p;
            if (money >= x)
                Console.WriteLine("Yes! {0:f2}", money - x);
            else
                Console.WriteLine("No! {0:f2}", Math.Abs(money - x));
        }
    }
}
