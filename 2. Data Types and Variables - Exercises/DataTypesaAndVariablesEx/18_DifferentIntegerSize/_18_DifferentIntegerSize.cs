using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_DifferentIntegerSize
{
    class _18_DifferentIntegerSize
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            long num;
            if (long.TryParse(input, out num))
            {
                Console.WriteLine("{0} can fit in: ", num);
                if (num >= -128 && num <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num >= 0 && num <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (num >= -32768 && num <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (num >= 0 && num <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (num >= -2147483648 && num <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (num >= 0 && num <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (num >= -9223372036854775808 && num <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
            }

            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }

        }
    }
}
