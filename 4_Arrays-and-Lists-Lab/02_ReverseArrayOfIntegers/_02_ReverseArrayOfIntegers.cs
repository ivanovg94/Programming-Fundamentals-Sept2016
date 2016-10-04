using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReverseArrayOfIntegers
{
    class _02_ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
