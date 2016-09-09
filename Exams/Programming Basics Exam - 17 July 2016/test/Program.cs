using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EqualPairs
{
    class _18_EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MaxDiff = int.MinValue;
            int sumPair = 0;
            for (int i = 1; i <= n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                if (i != 1)
                {
                    if (sumPair - number1 - number2 != 0 && MaxDiff < Math.Abs(sumPair - number1 - number2))
                    {
                        MaxDiff = Math.Abs(sumPair - number1 - number2);
                    }
                }
                sumPair = number1 + number2;
            }
            if (MaxDiff == int.MinValue)
            {
                Console.WriteLine("Yes, value={0}", sumPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", MaxDiff);
            }


        }
    }
}