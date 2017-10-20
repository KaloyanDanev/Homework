using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            double area = b1 * b2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
