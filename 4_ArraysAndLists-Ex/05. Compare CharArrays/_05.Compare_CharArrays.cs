using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_CharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> text1 = Console.ReadLine().Split().Select(char.Parse).ToList();
            List<char> text2 = Console.ReadLine().Split().Select(char.Parse).ToList();

            if (text1.Equals(text2))
            {
                Console.WriteLine(string.Concat(text1));
                Console.WriteLine(string.Concat(text1));
            }

            if (text1.Count == text2.Count)
            {
                for (int i = 0; i < text1.Count; i++)
                {
                    if (text1[i] > text2[i])
                    {
                        Console.WriteLine(string.Concat(text2));
                        Console.WriteLine(string.Concat(text1));
                        break;
                    }
                    else if (text1[i] < text2[i])
                    {
                        Console.WriteLine(string.Concat(text1));
                        Console.WriteLine(string.Concat(text2));
                        break;
                    }
                }
            }
            if (text1.Count != text2.Count)
            {
                if (text1.Count < text2.Count && text1.Equals(text2.Take(text1.Count)))
                {
                    Console.WriteLine(string.Concat(text1));
                }
                else if (text1.Count > text2.Count && text2.Equals(text1.Take(text2.Count)))
                {
                    Console.WriteLine(string.Concat(text2));

                }
            }
        }
    }
}
