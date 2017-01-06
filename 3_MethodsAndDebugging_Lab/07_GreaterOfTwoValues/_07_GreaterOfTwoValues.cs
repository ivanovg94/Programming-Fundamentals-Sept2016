using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_GreaterOfTwoValues
{
    class _07_GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    Console.WriteLine(GetMax(firstStr, secondStr));
                    break;
            }
        }

        static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt.CompareTo(secondInt) > 0)
            {
                return firstInt;
            }
            return secondInt;
        }


        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar.CompareTo(secondChar) > 0)
            {
                return firstChar;
            }
            return secondChar;
        }


        static string GetMax(string firstStr, string secondStr)
        {
            if (firstStr.CompareTo(secondStr) > 0)
            {
                return firstStr;
            }
            return secondStr;
        }
    }
}
