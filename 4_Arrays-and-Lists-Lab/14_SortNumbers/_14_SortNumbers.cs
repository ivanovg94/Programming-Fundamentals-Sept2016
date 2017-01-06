using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_SortNumbers
{
    class _14_SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ",input));

        }
    }
}
