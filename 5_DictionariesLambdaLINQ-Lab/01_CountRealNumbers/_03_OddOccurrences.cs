using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CountRealNumbers
{
    class _03_OddOccurrences
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> dic = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsKey(numbers[i]))
                {
                    dic[numbers[i]] +=1;

                }
                else
                {
                    dic[numbers[i]] = 1;
                }
            }

            foreach (KeyValuePair<double,int> num in dic)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            } 
        }
    }
}
