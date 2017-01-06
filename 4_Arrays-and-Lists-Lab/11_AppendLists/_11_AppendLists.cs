using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AppendLists
{
    class _11_AppendLists
    {
        static void Main(string[] args)
        {
            List <string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            Console.WriteLine(string.Join(" ",input));

        }
    }
}
