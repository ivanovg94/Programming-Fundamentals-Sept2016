using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04_SieveOfEratosthenes
{
    class _04_SieveOfEratosthenes
    {
        //Not exactly
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", FindPrimesInRange(end)));
        }


        public static bool IsPrime(BigInteger number)
        {
            if (number == 1 || number == 0)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }

            BigInteger half = number / 2;
            for (int i = 2; i <= half; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static List<int> FindPrimesInRange(int endNumber)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}
