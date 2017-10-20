using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long id = long.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());


            Console.WriteLine("First name: "+name);
            Console.WriteLine("Last name: "+name2);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+id);
            Console.WriteLine("Unique Employee number: "+number);
        }
    }
}
