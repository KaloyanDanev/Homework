using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int getMax = Getmax(a, b, c);
            Console.WriteLine(getMax);
        }
        static int Getmax(int a, int b , int c)
        {
            int maxInt1 = Math.Max(a, b);
            int maxInt2 = Math.Max(maxInt1, c);
            return maxInt2;
        }
    }
}
