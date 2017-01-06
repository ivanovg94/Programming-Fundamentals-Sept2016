using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PriceChangeAlert
{
    class _10_PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int nPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < nPrices - 1; i++)
            {
                double prices = double.Parse(Console.ReadLine());
                double difference = FindDiff(last, prices);
                bool isSignificantDifference = IsThereDiff(difference, threshold);



                string message = Get(prices, last, difference, isSignificantDifference);
                Console.WriteLine(message);

                last = prices;
            }
        }

         static string Get(double price, double last, double difference, bool etherTrueOrFalse)
        {
            string result = "";
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", price);
            }
            else if (!etherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, difference);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, difference);
            }
            else if (etherTrueOrFalse && (difference < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, difference);
            return result;
        }
        static bool IsThereDiff(double threshold, double isDiff)
        {
            if (Math.Abs(threshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        static double FindDiff(double last, double price)
        {
            double diff = (price - last) / last;
            return diff;
        }
    }
}