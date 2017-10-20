using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double parameter = 0;
          
            if (name == "face")
            {
                parameter = Math.Sqrt(2 * (n * n));
                Console.WriteLine($"{parameter:f2}");
            }
            else if (name == "space")
            {
                parameter = Math.Sqrt(3 * (n * n));
                Console.WriteLine($"{parameter:f2}");
            }
            else if (name == "volume")
            {
                parameter = (n*n*n);
                Console.WriteLine($"{parameter:f2}");
            }
            else if (name == "area")
            {
                parameter = (6 * (n * n));
                Console.WriteLine($"{parameter:f2}");
            }
        }
    }
}
