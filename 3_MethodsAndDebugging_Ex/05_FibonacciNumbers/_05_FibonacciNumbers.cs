using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FibonacciNumbers
{
    class _05_FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GetFib(n);

        }

         static void GetFib(int n)
        {
            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
    }
}
