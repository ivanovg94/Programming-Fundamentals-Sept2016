using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloName
{
    class _01_HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            GreetName(name);

        }

         static void GreetName(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
