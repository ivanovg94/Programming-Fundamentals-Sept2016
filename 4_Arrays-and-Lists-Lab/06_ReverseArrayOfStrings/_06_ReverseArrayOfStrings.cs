using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ReverseArrayOfStrings
{
    class _06_ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Array.Reverse(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }
    }
}
