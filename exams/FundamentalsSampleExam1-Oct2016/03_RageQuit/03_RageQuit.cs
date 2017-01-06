using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();
            var rage = new List<char>();
            var mid = new List<char>();
            int digit = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    if (char.IsLetter(input[i]))
                    {
                        mid.Add(char.ToUpper(input[i]));
                    }
                    else if (!char.IsLetter(input[i]))
                    {
                        mid.Add(input[i]);
                    }
                }
                else if (char.IsDigit(input[i]) && i != 0)
                {
                    digit = int.Parse(input[i].ToString());
                    if (i != input.Count - 1)
                    {
                        if ((char.IsDigit(input[i + 1])))
                        {
                            digit = int.Parse(string.Concat(input[i], input[i + 1]));
                        }
                    }
                    for (int j = 0; j < digit; j++)
                    {
                        rage.AddRange(mid);
                    }
                    mid.Clear();

                }
            }

            var distinct = rage.Distinct().ToArray();
            Console.WriteLine("Unique symbols used: {0}", distinct.Count());
            Console.WriteLine(string.Concat(rage));
        }
    }
}
