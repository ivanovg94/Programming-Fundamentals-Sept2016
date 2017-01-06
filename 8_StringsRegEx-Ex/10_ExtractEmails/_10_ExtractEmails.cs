using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10_ExtractEmails
{
    class _10_ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = "(?:^|\\s)([a-z0-9]+[-._]?[a-z0-9]*@[a-z0-9-]+\\.[a-z-.]+)\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern.Trim());

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
