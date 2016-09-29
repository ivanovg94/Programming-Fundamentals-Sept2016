using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DrawFilledSquare
{
    class _04_DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 2 * n));
            PrintSq(n);
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintSq(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
