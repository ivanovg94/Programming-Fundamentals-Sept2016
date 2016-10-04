using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_RoundingNumbers
{
    class _05_RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(a => double.Parse(a)).ToArray();
            foreach (var item in input)
            {
                Console.WriteLine("{0} ==> {1}", item,Math.Round(item, MidpointRounding.AwayFromZero));
            }
        }
    }
}
