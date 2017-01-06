using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConvertFromBase_10Tobase_N
{
    class _01_ConvertFromBase_10Tobase_N
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            int baseN = int.Parse(input[0]);
            int num = int.Parse(input[1]);

            string binary = Convert.ToString(num, baseN); // convert 5 to its binary representation
            Console.WriteLine(binary);
        }
    }
}
