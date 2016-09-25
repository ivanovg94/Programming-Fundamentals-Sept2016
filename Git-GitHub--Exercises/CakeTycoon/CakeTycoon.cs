using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            uint cakesDemand = uint.Parse(Console.ReadLine());
            double flPerCake = double.Parse(Console.ReadLine());
            uint flAvail = uint.Parse(Console.ReadLine());
            uint trAvail = uint.Parse(Console.ReadLine());
            decimal oneTrPrice = decimal.Parse(Console.ReadLine());
            decimal trCost = trAvail * oneTrPrice;
            uint producedCakes = (uint)(flAvail / flPerCake);


            decimal cakePrice = trCost / cakesDemand;
            decimal overcharge = 0.25M * cakePrice;
            cakePrice = cakePrice + overcharge;


            if (producedCakes >= cakesDemand)
            {

                Console.WriteLine("All products available, price of a cake: {0:f2}", cakePrice);
            }
            else
            {
                uint cakeNotProduced = cakesDemand - producedCakes;
                double flReq = (cakesDemand * flPerCake) - flAvail;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", producedCakes, flReq);
            }



        }
    }
}
