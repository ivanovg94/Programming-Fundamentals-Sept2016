using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_PrimeCheckerRefactor
{
    class _15_FastPrimeCheckerRefactor
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {IsPrime}");
            }

        }
    }
}
