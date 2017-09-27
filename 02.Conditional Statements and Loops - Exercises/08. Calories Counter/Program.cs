using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredints = int.Parse(Console.ReadLine());
            var calories = 0;

            for (int i = 0; i < ingredints; i++)
            {
                var ingr = Console.ReadLine().ToLower();
                if (ingr == "cheese")
                {
                    calories += 500;
                }
                else if (ingr == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingr == "salami")
                {
                    calories += 600;
                }
                else if (ingr == "pepper")
                {
                    calories += 50;
                }

            }
            Console.WriteLine($"Total calories: { calories}");
        }
    }
}
