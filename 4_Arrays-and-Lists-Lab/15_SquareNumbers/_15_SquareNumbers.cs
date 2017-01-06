using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_SquareNumbers
{
    class _15_SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();

            foreach (var item in input)
            {
                if (Math.Sqrt(item)==(int)(Math.Sqrt(item)))
                {
                    result.Add(item);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
