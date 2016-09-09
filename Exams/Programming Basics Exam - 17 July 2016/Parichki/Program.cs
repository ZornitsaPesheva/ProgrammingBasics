using System;

namespace Parichki
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yuans = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            var bitcoinsInLeva = bitcoins * 1168;
            var yuansInLeva = yuans * 0.15 * 1.76;
            var leva = bitcoinsInLeva + yuansInLeva;
            var euro = leva / 1.95;
            var comInEuro = euro * comission / 100.00;
            Console.WriteLine(euro - comInEuro);
        }
    }
}
