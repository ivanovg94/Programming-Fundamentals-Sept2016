using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var maratonDays = long.Parse(Console.ReadLine());
            var nRuners = long.Parse(Console.ReadLine());
            var avrgNlapsPerRunner = long.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCap = long.Parse(Console.ReadLine());
            decimal moneyPerKM = decimal.Parse(Console.ReadLine());

            var runersCapALL = maratonDays * trackCap;

            var finalCountRuners = Math.Min(runersCapALL, nRuners);
            decimal totalMeters = finalCountRuners * avrgNlapsPerRunner * trackLenght;
            decimal totalKm = totalMeters / 1000;
            decimal moneyRaised = totalKm * moneyPerKM;
            Console.WriteLine("Money raised: {0:f2}",moneyRaised);


        }
    }
}
