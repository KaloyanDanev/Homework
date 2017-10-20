using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> authorRevenue = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[1];
                double price = Convert.ToDouble(input[5]);
                if (!authorRevenue.ContainsKey(name))
                {
                    authorRevenue[name] = price;
                }
                else
                {
                    authorRevenue[name] += price;
                }
            }
            foreach (var kvp in authorRevenue.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
