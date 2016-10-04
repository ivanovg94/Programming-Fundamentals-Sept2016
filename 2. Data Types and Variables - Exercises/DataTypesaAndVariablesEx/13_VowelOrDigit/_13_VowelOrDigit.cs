using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_VowelOrDigit
{
    class _13_VowelOrDigit
    {
        static void Main(string[] args)
        {
            char input= char.Parse(Console.ReadLine());
            if (input == 'a' || input == 'A' || input == 'e' || input == 'E' || input == 'i' || input == 'I' || input == 'o' || input == 'O' || input == 'u' || input == 'U')
            {
                Console.WriteLine("vowel");
            }
            else if (input >= '0' && input <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
