using System;

namespace Number_0_9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            if (x == 0)
                Console.WriteLine("zero");
            else if (x == 1)
                Console.WriteLine("one");
            else if (x == 2)
                Console.WriteLine("two");
            else if (x == 3)
                Console.WriteLine("three");
            else if (x == 4)
                Console.WriteLine("four");
            else if (x == 5)
                Console.WriteLine("five");
            else if (x == 6)
                Console.WriteLine("six");
            else if (x == 7)
                Console.WriteLine("seven");
            else if (x == 8)
                Console.WriteLine("eight");
            else if (x == 9)
                Console.WriteLine("nine");
            else
                Console.WriteLine("number too big");
        }
    }
}
