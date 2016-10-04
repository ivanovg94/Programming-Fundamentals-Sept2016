using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PrimeChecker
{
    class _06_PrimeChecker
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));

        }

        static bool IsPrime(long num)
        {
            if (num == 0) { return false; }
            else if (num == 1) { return false; }
            else if (num == 2) { return true; }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(num)); ++i)
            {
                if (num % i == 0) return false;
            }

            return true;

        }
    }
}

