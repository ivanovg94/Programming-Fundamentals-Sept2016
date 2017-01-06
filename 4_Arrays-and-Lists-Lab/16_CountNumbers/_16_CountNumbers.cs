using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_CountNumbers
{
    class _16_CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();

            int count = 1;

            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (i == input.Count - 1)
                {
                    Console.WriteLine("{0} -> {1}", input[i], count);
                    break;
                }
                if (input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", input[i], count);
                    count = 1;
                }
            }

        }
    }
}
