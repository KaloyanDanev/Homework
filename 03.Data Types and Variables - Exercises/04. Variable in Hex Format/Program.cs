using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex1 = Console.ReadLine();
            int dec1 = Convert.ToInt32(hex1, 16);
            Console.WriteLine(dec1);
        }
    }
}
