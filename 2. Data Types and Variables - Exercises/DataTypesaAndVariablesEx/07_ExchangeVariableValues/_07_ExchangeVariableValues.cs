﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ExchangeVariableValues
{
    class _07_ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before: ");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After: ");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

        }
    }
}
