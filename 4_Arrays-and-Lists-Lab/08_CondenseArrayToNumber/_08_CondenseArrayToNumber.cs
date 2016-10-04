using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CondenseArrayToNumber
{
    class _08_CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }
            int[] condensed = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
            }

            Console.WriteLine(condensed[0]);


        }
    }
}
