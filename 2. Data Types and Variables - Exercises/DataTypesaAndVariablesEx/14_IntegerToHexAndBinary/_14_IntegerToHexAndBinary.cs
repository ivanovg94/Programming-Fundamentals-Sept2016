using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_IntegerToHexAndBinary
{
    class _14_IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string conv8 =  Convert.ToString(num, 16);
            string conv2 = Convert.ToString(num, 2);
            Console.WriteLine(conv8.ToUpper());
            Console.WriteLine(conv2.ToUpper());


        }
    }
}
