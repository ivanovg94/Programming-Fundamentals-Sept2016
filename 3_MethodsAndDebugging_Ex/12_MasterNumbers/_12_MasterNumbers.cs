using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MasterNumbers
{
    class _12_MasterNumbers
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int num = 0; num < range; num++)
            {
                if (IsSymetric(num) == true && IsSumDivisibleBy7(num) == true && HasEvenDigit(num) == true)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static bool HasEvenDigit(int num)
        {
            if (num >= 0 && num <= 9)
            {
                return true;
            }
            double center = Math.Truncate((double)num / 2)+1;
            string numToString = num.ToString();
            for (int i = 0; i < length; i++)
            {

            }
        }

        static bool IsSumDivisibleBy7(int num)
        {
            throw new NotImplementedException();
        }

        static bool IsSymetric(int num)
        {
            throw new NotImplementedException();
        }
    }
}
