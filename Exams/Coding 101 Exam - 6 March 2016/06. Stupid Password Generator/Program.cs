using System;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int number1 = 1; number1 < n; number1++)
            {
                for (int number2 = 1; number2 < n; number2++)
                {
                    char firstLetter = 'a';
                    for (int flcounter = 1; flcounter <= l; flcounter++)
                    {
                        char secondLetter = 'a';
                        for (int slcounter = 1; slcounter <= l; slcounter++)
                        {
                            for (int number3 = number1 + 1; number3 <= n; number3++)
                            {
                                if (number3 > number1 && number3 > number2)
                                {
                                    Console.Write(number1.ToString() + number2 
                                        + firstLetter.ToString() 
                                        + secondLetter.ToString() + number3 + " ");
                                }
                            }
                            secondLetter++;
                        }
                        firstLetter++;
                    }
                }
            }
        }
    }
}
