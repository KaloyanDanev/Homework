using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mine = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else if (Mine.ContainsKey(input))
                {
                    Mine[input] += int.Parse(Console.ReadLine());
                }
                else
                {
                    Mine[input] = int.Parse(Console.ReadLine());
                }
            }
            foreach (var miner in Mine)
            {
                Console.WriteLine($"{miner.Key} -> {miner.Value}");
            }
        }
    }
}
