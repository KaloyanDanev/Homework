using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var startKey = @"^[a-zA-Z]+[<|\]";
            var endKey = @"[<|\][a-zA-Z]+$";
            var firstKey = Regex.Match(input,startKey);
            var secondKey = Regex.Match(input, endKey);
            var firstK = firstKey.Value.TrimStart('<', '|', '\\');
            var secondK = secondKey.Value.TrimEnd('<', '|', '\\');
            var pattern = $"{firstK}(.*?){secondK}";
            var text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1].Value);
            }
            Console.WriteLine(sb.Length > 1 ? sb.ToString() : "Empty result");
        }
    }
}
