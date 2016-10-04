using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumArrays
{
    class _07_SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();

            int[] resultArr = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ",resultArr));
        }
    }
}
