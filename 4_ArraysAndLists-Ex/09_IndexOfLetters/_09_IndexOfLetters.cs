using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IndexOfLetters
{
    class _09_IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                Console.WriteLine("{0} -> {1}",item,item-97);
            }
        }
    }
}
