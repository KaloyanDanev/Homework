using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = number.Length / 4;

            int[] leftArr = number.Take(k).ToArray();
            int[] midArr = number.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = number.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = midArr[i] + leftArr[i];
                result[i + k] = midArr[i + k] + rightArr[i];
            }

            Console.WriteLine($"{string.Join(" ",result)}");
        }
    }
}
