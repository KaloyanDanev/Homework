using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var totalenergy = volume * energy / 100.0;
            var sugars = sugar * volume / 100.0;

            Console.WriteLine("{0}ml {1}:", volume, product);
            Console.WriteLine("{0}kcal, {1}g sugars", totalenergy, sugars);
        }
    }
}
