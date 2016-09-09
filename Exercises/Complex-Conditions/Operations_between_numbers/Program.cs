using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var op = Console.ReadLine();
            double result = 0.0;
            bool even;
            switch (op)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 != 0)
                        result = (double)n1 / n2;
                    break;
                case "%":
                    if (n2 != 0)
                        result = n1 % n2;
                    break;
            }
            even = ((result % 2) == 0);
            if (op == "+" || op == "-" || op == "*")
            {
                Console.Write("{0} {1} {2} = {3} - ", n1, op, n2, result);
                Console.WriteLine("{0}", even ? "even" : "odd");
            }
            else 
            if (n2 != 0)
            {
                if (op == "/")
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
                else if (op == "%")
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
            }
            else
                Console.WriteLine("Cannot divide {0} by zero", n1); 
        }
    }
}
