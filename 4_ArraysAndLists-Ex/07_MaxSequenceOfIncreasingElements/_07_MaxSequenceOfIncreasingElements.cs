using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MaxSequenceOfIncreasingElements
{
    class _07_MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;

            for (int pos = 1; pos < input.Count; pos++)
            {
                if (input[pos] > input[pos - 1]+1)
                {
                    len++;
                }
                if (input[pos] <= input[pos - 1])
                {
                    start = pos;
                    len = 1;
                }

                if (len > bestLen && len != 1)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }

            var result = input.GetRange(bestStart, bestLen);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
