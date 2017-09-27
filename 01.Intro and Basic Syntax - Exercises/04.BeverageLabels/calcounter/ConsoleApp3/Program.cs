using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool endY = word.EndsWith("y");
            bool end = word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") ||
                word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z");
            if (end)
            {
                word += "es";
            }
            else if (endY)
            {
                word = word.Remove(word.Length - 1) + "ies";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
