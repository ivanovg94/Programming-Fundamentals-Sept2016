using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumbersInReversedOrder
{
    class _04_NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(GetReverse(num)); 
        }
 
         static string GetReverse(string num)
        {
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
