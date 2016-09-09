using System;

namespace _03.On_Time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examhour = int.Parse(Console.ReadLine());
            var examminutes = int.Parse(Console.ReadLine());
            var harrival = int.Parse(Console.ReadLine());
            var marrival = int.Parse(Console.ReadLine());
            bool late = false, ontime = false, early = false;
            early = ((examhour * 60 + examminutes) - (harrival * 60 + marrival) > 30);
            late = ((examhour * 60 + examminutes) < (harrival * 60 + marrival));
            ontime = ((examhour * 60 + examminutes) - (harrival * 60 + marrival)) >= 0 &&
                ((examhour * 60 + examminutes) - (harrival * 60 + marrival)) <= 30;
            var hearly = ((examhour * 60 + examminutes) - (harrival * 60 + marrival)) / 60;
            var mearly = ((examhour * 60 + examminutes) - (harrival * 60 + marrival)) % 60;
            if (late)
            {
                Console.WriteLine("Late");
                if (hearly == 0)
                {
                    Console.WriteLine("{0} minutes after the start", Math.Abs(mearly));
                }
                else
                {
                    Console.Write("{0}", Math.Abs(hearly));
                    if (mearly > -10)
                    {
                        Console.WriteLine(":0{0} hours after the start", Math.Abs(mearly));

                    }
                    else
                    {
                        Console.WriteLine(":{0} hours after the start", Math.Abs(mearly));
                    }
                }
            }
            else if (ontime)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", mearly);
            }
            else
            {
                Console.WriteLine("Early");
                if (hearly == 0)
                {
                    Console.WriteLine("{0} minutes before the start", mearly);
                }
                else
                {
                    Console.WriteLine("{0}", hearly);
                    if (mearly < 10)
                    {
                        Console.WriteLine(":0{0} hours before the start", mearly);
                    }
                    else
                    {
                        Console.WriteLine(":{0} hours before the start", mearly);
                    }
                }
            }
        }
    }
}
