using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_RemoveNegativesAndReverse
{
    class _10_RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            input.Reverse();
            foreach (var item in input)
            {
                if (item>=0)
                {
                    result.Add(item);
                }
            }
            if (result.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
