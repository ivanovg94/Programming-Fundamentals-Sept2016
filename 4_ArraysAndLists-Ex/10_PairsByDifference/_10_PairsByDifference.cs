using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PairsByDifference
{
    class _10_PairsByDifference
    {
        static void Main(string[] args) 
        {

            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i; j < input.Count; j++)
                {
                    if (Math.Abs(input[i]-input[j])== diff)
                    {
                        count++;
                    } 
                }
            }
            Console.WriteLine(count);

        }
    }
}
