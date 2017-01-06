using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LargestCommonEnd
{
    class _01_LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().ToList();
            var second = Console.ReadLine().Split().ToList();
            int nFirst = first.Count();
            int nSecond = second.Count();
            int equalsFromStart = 0;
            int equalsFromEnd = 0;

            if (first.Count>second.Count)
            {
                first.Reverse();
                second.Reverse();
            }



            for (int i = 0; i < Math.Min(nFirst, nSecond); i++)
            {
                if (first[i] == second[i])
                {
                    equalsFromStart++;
                }
                else
                {
                    break;
                }
            }
            for (int i = Math.Min(nFirst, nSecond) - 1; i >= 0; i--)
            {
                if (first[i] == second[i])
                {
                    equalsFromEnd++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(equalsFromEnd, equalsFromStart));
        }
    }
}