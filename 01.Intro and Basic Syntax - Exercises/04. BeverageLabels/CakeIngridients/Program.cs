using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngridients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            var ingedintsCnt = 0;

            while (ingredient != "Bake!")
            {
                ingedintsCnt++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingedintsCnt} ingredients.");
        }
    }
}
