using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MinMaxSumAverage
{
    class _02_MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nAverage = {3}",nums.Sum(),nums.Min(),nums.Max(),nums.Average());

        }
    }
}
