using System;

namespace _08.IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxLenght = 0;
            var lenght = 0;
            var oldnum = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > oldnum || i == 0)
                {
                    lenght++;
                }
                else
                    lenght = 1;
                oldnum = num;
                if (maxLenght < lenght)
                    maxLenght = lenght;
            }
            Console.WriteLine(maxLenght);
        }
    }
}
