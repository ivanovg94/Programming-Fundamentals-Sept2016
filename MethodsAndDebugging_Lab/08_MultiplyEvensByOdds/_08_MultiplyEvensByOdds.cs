using System;

namespace _08_MultiplyEvensByOdds
{
    class _08_MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            GetMultipleOfEvensAndOdds(num);

            Console.WriteLine(GetMultipleOfEvensAndOdds(num));
        }
        static int GetMultipleOfEvensAndOdds(int num)
        {
            int sumOdd = GetOddSum(num);
            int sumEven = GetEvenSum(num);
            return sumOdd * sumEven;
        }
        static int GetOddSum(int num)
        {
            int oddSum = 0;
            while (num > 0)
            {

                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                num /= 10;
            }
            return oddSum;
        }
        static int GetEvenSum(int num)
        {
            int evenSum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                num /= 10;
            }
            return evenSum;
        }
    }
}
