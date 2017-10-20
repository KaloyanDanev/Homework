using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(number));

        }
           static int Fibonacci(int number)
        {
            int a = 1;
            int b = 1;
           
            for (int i = 0; i < number - 1; i++)
            {
                int next = a + b;
                a = b;
                b = next;
            }
            return b;
        }
    }
}
