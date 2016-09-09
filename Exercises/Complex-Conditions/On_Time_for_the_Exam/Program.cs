using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexam = int.Parse(Console.ReadLine());
            var mexam = int.Parse(Console.ReadLine());
            var harr = int.Parse(Console.ReadLine());
            var marr = int.Parse(Console.ReadLine());
            bool late = false, ontime = false, early = false;
            early = ((hexam * 60 + mexam) - (harr * 60 + marr) > 30);
            late = ((hexam * 60 + mexam) < (harr * 60 + marr));
            ontime = ((hexam * 60 + mexam) - (harr * 60 + marr)) >= 0 &&
                ((hexam * 60 + mexam) - (harr * 60 + marr)) <= 30;
            var hearly = ((hexam * 60 + mexam) - (harr * 60 + marr)) / 60;
            var mearly = ((hexam * 60 + mexam) - (harr * 60 + marr)) % 60;
            if (late)
            {
                Console.WriteLine("Late");
                if (hearly == 0)
                    Console.WriteLine("{0} minutes after the start", Math.Abs(mearly));
                else if (hearly < 0)
                {
                    Console.Write("{0}", Math.Abs(hearly));
                    if (mearly > -10)
                        Console.WriteLine(":0{0} hours after the start", Math.Abs(mearly));
                    else
                        Console.WriteLine(":{0} hours after the start", Math.Abs(mearly));
                }
            }
            else if (ontime)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", mearly);
            }
            else if (early)
            {
                Console.WriteLine("Early");
                if (hearly == 0)
                    Console.WriteLine("{0} minutes before the start", mearly);
                else if (hearly > 0)
                {
                    Console.WriteLine("{0}", hearly);
                    if (mearly < 10)
                        Console.WriteLine(":0{0} hours before the start", mearly);
                    else
                        Console.WriteLine(":{0} hours before the start", mearly);
                }
            }
        }
    }
}
