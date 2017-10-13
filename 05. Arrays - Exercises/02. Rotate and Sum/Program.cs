using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[number.Length];

            for (int j = 0; j < rotations; j++)
            {

                int reminder = number[number.Length - 1];
                for (int i = number.Length - 1; i > 0; i--)
                {
                    number[i] = number[i - 1];
                    sum[i] += number[i];
                }
                number[0] = reminder;
                sum[0] += number[0];
            }
            Console.WriteLine($"{string.Join(" ",sum)}");
        }
    }
}
