﻿using System;

namespace _03_EnglishNameOfLastDigit
{
    class _03_EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long num = Math.Abs(long.Parse(Console.ReadLine()));
            GetNameOfLastDigit(num);
        }

        static void GetNameOfLastDigit(long num)
        {
            long lastDigit = num % 10;
            switch (lastDigit)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
            } 
        }
    }
}
