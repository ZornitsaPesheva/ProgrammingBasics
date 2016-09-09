using System;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string y = "", z = "";
            x = int.Parse(Console.ReadLine());
            if (x < 0 || x > 100)
                Console.WriteLine("invalid number");
            else
            {
                if (x == 0)
                    Console.WriteLine("zero");
                else if (x == 100)
                    Console.WriteLine("one hundred");
                else if (x == 10)
                    Console.WriteLine("ten");
                else if (x == 11)
                    Console.WriteLine("eleven");
                else if (x == 12)
                    Console.WriteLine("twelve");
                else if (x == 13)
                    Console.WriteLine("thirteen");
                else if (x == 14)
                    Console.WriteLine("forteen");
                else if (x == 15)
                    Console.WriteLine("fifteen");
                else if (x == 16)
                    Console.WriteLine("sixteen");
                else if (x == 17)
                    Console.WriteLine("seventeen");
                else if (x == 18)
                    Console.WriteLine("eighteen");
                else if (x == 19)
                    Console.WriteLine("nineteen");

                if (x >= 20)
                {
                    if ((x / 10) == 2)
                        y = "twenty";
                    else if ((x / 10) == 3)
                        y = "thirty";
                    else if ((x / 10) == 4)
                        y = "fourty";
                    else if ((x / 10) == 5)
                        y = "fifty";
                    else if ((x / 10) == 6)
                        y = "sixty";
                    else if ((x / 10) == 7)
                        y = "seventy";
                    else if ((x / 10) == 8)
                        y = "eighty";
                    else if ((x / 10) == 9)
                        y = "ninety";
                }
                if (x < 10 || x > 20)
                {
                    if ((x % 10) == 1)
                        z = "one";
                    else if ((x % 10) == 2)
                        z = "two";
                    else if ((x % 10) == 3)
                        z = "three";
                    else if ((x % 10) == 4)
                        z = "four";
                    else if ((x % 10) == 5)
                        z = "five";
                    else if ((x % 10) == 6)
                        z = "six";
                    else if ((x % 10) == 7)
                        z = "seven";
                    else if ((x % 10) == 8)
                        z = "eight";
                    else if ((x % 10) == 9)
                        z = "nine";
                }
                if (z == "" && y != "")
                    Console.WriteLine(y);
                else if (y == "" && z != "")
                    Console.WriteLine(z);
                else if (y != "" && z != "")
                    Console.WriteLine(y + " " + z);
                Console.ReadLine();
            }
        }
    }
}
