using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var Studio = 0.0;
            var Double = 0.0;
            var Suite = 0.0;

            if (month == "May" || month == "October")
            {

                Studio += 50 * nights;
                Double += 65 * nights;
                Suite += 75 * nights;
                if (nights > 7 )
                {
                    Studio *= 0.95;
                }
                
            }
            else if (month == "June" || month == "September")
            {
                Studio += 60 * nights;
                Double += 72 * nights;
                Suite += 82 * nights;
                if (nights > 14)
                {
                    Double *= 0.90;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                Studio += 68 * nights;
                Double += 77 * nights;
                Suite += 89 * nights;
                if (nights > 14)
                {
                    Suite *= 0.85;
                }
            }
            if (month == "September"  && nights > 7)
            {
                Studio -= 60;
            }
            else if (month == "October" && nights > 7)
            {
                Studio -= 50;
            }
            Console.WriteLine($"Studio: {Studio:f2} lv.");
            Console.WriteLine($"Double: {Double:f2} lv.");
            Console.WriteLine($"Suite: {Suite:f2} lv.");
        }
    }
}
