using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _07_PrimesInGivenRange
{
    class _07_PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", FindPrimesInRange(start, end)));
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

        private static List<int> FindPrimesInRange(int startNumber, int endNumber)
        {
            List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
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
