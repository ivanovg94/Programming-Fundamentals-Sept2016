using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_SumReversedNumbers
{
    class _15_SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
             //   input[i] = Microsoft.VisualBasic.Strings.StrReverse(input[i]);
             //   input[i].Reverse();
              input[i] = input[i].ToCharArray().Reverse().ToString();

                sum += int.Parse(input[i]);
            }
            Console.WriteLine(sum);



        }
    }
}
