using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringsAndObjects
{
    class _06_StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";

            String together = string.Join(" ", firstWord, secondWord);
            Console.WriteLine(together);
        }
    }
}
