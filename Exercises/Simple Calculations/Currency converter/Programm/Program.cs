using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();
            double result = 0;
            switch (from)
            {
                case "BGN":
                    switch (to)
                    {
                        case "USD":
                            result = sum / 1.79549;
                            break;
                        case "EUR":
                            result = sum / 1.95583;
                            break;
                        case "GBP":
                            result = sum / 2.53405;
                            break;
                    }
                    break;
                case "USD":
                    switch (to)
                    {
                        case "BGN":
                            result = sum * 1.79549;
                            break;
                        case "EUR":
                            result = sum * 1.79549 / 1.95583;
                            break;
                        case "GPB":
                            result = sum * 1.79549 / 1.53495;
                            break;
                    }
                    break;
                case "EUR":
                    switch (to)
                    {
                        case "BGN":
                            result = sum * 1.95583;
                            break;
                        case "USD":
                            result = sum * 1.95583 / 1.79549;
                            break;
                        case "GBP":
                            result = sum * 1.95583 / 2.53405;
                            break;
                    }
                    break;
                case "GPB":
                    switch (to)
                    {
                        case "BGN":
                            result = sum * 2.53405;
                            break;
                        case "USD":
                            result = sum * 2.53405 / 1.79549;
                            break;
                        case "EUR":
                            result = sum * 1.95583 / 1.95583;
                            break;
                    }
                    break;
            }
            Console.WriteLine(Math.Round(result, 2));
            Console.ReadLine();
        }
    }
}