using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseString
{
    class _01_ReverseString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            Console.WriteLine(new string (text));
        }
    }
}
