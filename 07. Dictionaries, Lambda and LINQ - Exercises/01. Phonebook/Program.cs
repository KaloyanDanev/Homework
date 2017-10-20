using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[    ] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] phoneParameters = input.Split(new[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string command = phoneParameters[0];

                if (command == "A")
                {
                    string key = phoneParameters[1];
                    string value = phoneParameters[2];

                    phoneBook[key] = value;
                }
                else
                {
                    string key = phoneParameters[1];

                    if (phoneBook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phoneBook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
