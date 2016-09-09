using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var sum = x + y + z;
            var mins = sum / 60;
            var secs = sum % 60;
            if (secs < 10)
                Console.WriteLine(mins + ":0" + secs);
            else
                Console.WriteLine(mins + ":" + secs);
            Console.ReadLine();
        }
    }
}
