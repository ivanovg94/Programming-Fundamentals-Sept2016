using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MathPower
{
    class _06_MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power)); 

        }

         static double RaiseToPower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
