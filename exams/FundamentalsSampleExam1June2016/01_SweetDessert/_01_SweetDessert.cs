using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SweetDessert
{
    class _01_SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            ulong guest = ulong.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            int numOfPortions = (int)Math.Ceiling(guest / 6m);
            //   int nDeserts = (int)(numOfPortions)*6;
            decimal portionPrice = 2 * priceBananas + 4 * priceEggs + 0.2m * priceBerries;
            if (portionPrice*numOfPortions<=cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.",portionPrice*numOfPortions);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",(portionPrice*numOfPortions)-cash);
            }
        }
    }
}
