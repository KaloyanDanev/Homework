using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expressions__RegEx____Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match emailMatch in matches)
            {
                string email = emailMatch.ToString();
                if (!(email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_") 
                    || email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_")))
                {
                    Console.WriteLine(emailMatch);
                }
            }
        }
    }
}
