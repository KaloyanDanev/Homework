using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IntroandBasicSyntaxExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:0000} {1:0000} {2:0000} {3:0000}", num1, num2, num3, num4);
        }
    }
}
