using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ReversedChars
{
    class _09_ReversedChars
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            string combined = string.Concat(first, second, third);

            string reversed = string.Concat(Enumerable.Reverse(combined));
            Console.WriteLine(reversed);


            //one line : Console.WriteLine(string.Concat(Enumerable.Reverse(string.Concat(first, second, third))));
        }
    }
}
