using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var prof = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            if (prof == "Athlete")
            {
                var total = quantity * 0.70;
                Console.WriteLine($"The Athlete has to pay {total:f2}.");
            }
            else if (prof == "Businessman")
            {
                var total = quantity * 1.00;
                Console.WriteLine($"The Businessman has to pay {total:f2}.");
            }
            else if (prof == "Businesswoman")
            {
                var total = quantity * 1.00;
                Console.WriteLine($"The Businesswoman has to pay {total:f2}.");
            }
            else if (prof == "SoftUni Student")
            {
                var total = quantity * 1.70;
                Console.WriteLine($"The SoftUni Student has to pay {total:f2}.");
            }
            else
            {
                var total = quantity * 1.20;
                Console.WriteLine($"The {prof} has to pay {total:f2}.");
            }
        
        }
    }
}
