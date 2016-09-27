using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int number = 0;
            bool isSpecial = false;
            for (int current = 1; current <= range; current++)
            {
                int result = 0;
                number = current;
                while (current > 0)
                {
                    result += current % 10;
                    current = current / 10;
                }
                isSpecial = (result == 5) || (result == 7) || (result == 11);
                Console.WriteLine($"{number} -> {isSpecial}");
                result = 0;
                current = number;
            }

        }
    }
}
