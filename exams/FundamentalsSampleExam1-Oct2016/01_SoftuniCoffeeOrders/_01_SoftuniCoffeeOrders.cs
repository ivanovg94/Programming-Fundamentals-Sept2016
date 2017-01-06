using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01_SoftuniCoffeeOrders
{
    class _01_SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal capsulePrice = 0m;
            DateTime orderDate = new DateTime();
            ulong capsuleCount = 0;
            decimal orderPrice = 0m;
            int daysInMonth = 0;
            decimal total = 0m;
            for (int i = 0; i < n; i++)
            {
                capsulePrice = decimal.Parse(Console.ReadLine());
                orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capsuleCount = ulong.Parse(Console.ReadLine());
                daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                orderPrice = ((ulong)daysInMonth * capsuleCount) * capsulePrice;
                total += orderPrice;
                Console.WriteLine("The price for the coffee is: ${0:f2}",orderPrice);
            }
            Console.WriteLine("Total: ${0:f2}",total);
        }
    }
}
