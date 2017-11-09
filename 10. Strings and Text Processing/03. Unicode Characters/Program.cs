using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> result = new List<string>();
            foreach (char c in input)
            {
                string x = Convert.ToString(c, 16).PadLeft(4, '0');
                result.Add("\\u" + x);
            }

            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
