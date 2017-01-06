using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UnicodeCharacters
{
    class _03_UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            foreach (var c in input)
            {
                string unic = "\\u" + ((int)c).ToString("X4").ToLower();
                builder.Append(unic);
            }

            Console.WriteLine(builder);
        }
    }
}
