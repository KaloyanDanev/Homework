using System;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string wordOne = input[0];
            string wordTwo = input[1];

            var arrayOne = wordOne.ToCharArray().Distinct().ToArray();
            var arrayTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length == arrayTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
