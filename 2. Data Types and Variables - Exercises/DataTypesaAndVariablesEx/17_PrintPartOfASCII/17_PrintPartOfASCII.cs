using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrintPartOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            List<char> symbols = new List<char>();
            char c ;
            for (int i = startIndex; i <= endIndex; i++)
            {
                c = (char)i;
                symbols.Add(c);
            }
            Console.WriteLine(string.Join(" ",symbols));
        }
    }
}
