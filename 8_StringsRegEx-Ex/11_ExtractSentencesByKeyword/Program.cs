using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var text = Console.ReadLine().Split('.', '?', '!').ToList();
            foreach (var item in text)
            {
                if (item.Contains(" "+word+" "))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
