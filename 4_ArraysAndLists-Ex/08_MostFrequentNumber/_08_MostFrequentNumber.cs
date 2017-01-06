using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MostFrequentNumber
{
    class _08_MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            int count = 1;
            int maxCount = 1;
            string frequentN = input[0];
            for (int pos = 1; pos < input.Count; pos++)
            {
                
                if (input[pos]==input[pos-1])
                {
                    count++;
                    frequentN = input[pos];
                }
                else
                {
                    count = 1;                  
                }
                if (count>maxCount)
                {
                    maxCount = count;
                }

            }
        }
    }
}
