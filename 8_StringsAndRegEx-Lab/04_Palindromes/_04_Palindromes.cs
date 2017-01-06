using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindromes
{
    class _04_Palindromes
    {
        static void Main(string[] args)
        {
            char[] symbols = { ' ', ',', '.', '!', '?' };
            var input = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var unique = new List<string>();
            foreach (var word in input)
            {
                var temp = word.ToCharArray();
                Array.Reverse(temp);
                var temp2 = string.Concat(temp);
                if (word == temp2)
                {
                    unique.Add(word);
                }
               
            }
            var newUnique = unique.Distinct().ToList();
            newUnique.Sort();
            Console.WriteLine(string.Join(", ", newUnique));



        }
    }
}
