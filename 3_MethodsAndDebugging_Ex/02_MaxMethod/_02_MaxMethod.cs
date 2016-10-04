using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaxMethod
{
    class _02_MaxMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(GetMaxFirstOrSecond(num1, num2), num3));
        }

        static int GetMaxFirstOrSecond(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
