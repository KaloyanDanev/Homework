using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CalculateFactoriel(number);
        }

         static void CalculateFactoriel(int number)
        {
            BigInteger result = number;
            for (int i = 1; i < number; i++)
            {
                result = result * i;
            }
            CauntZeroesInResult(result);
        }

        static void CauntZeroesInResult(BigInteger result)
        {
            string resultStr = result.ToString();
            int countZeros = 0;
            int stringlenght = resultStr.Length;
            for (int i = 0; i < stringlenght; i++)
            {
                if (resultStr.EndsWith("0"))
                {
                    countZeros++;
                    resultStr = resultStr.Remove(resultStr.Length - 1);
                }
                else
                {
                    Console.WriteLine(countZeros);
                    return;
                }
            }
        }
    }
}