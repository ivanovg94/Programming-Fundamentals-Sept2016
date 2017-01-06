using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayModifier
{
    class _02_ArrayModifier
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                var command = input.Split().ToArray();
                switch (command[0])
                {
                    case "swap": Swap(command, nums); break;
                    case "multiply": Multiply(command, nums); break;
                    case "decrease": Decrease(nums); break;
                }
                input = Console.ReadLine();

            }

            Console.Write(string.Join(", ", nums));

        }

        static void Decrease(long[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] -= 1;
            }
        }

        static void Multiply(string[] command, long[] nums)
        {
            nums[long.Parse(command[1])] *= nums[long.Parse(command[2])];
        }

        static void Swap(string[] command, long[] nums)
        {
            long temp = nums[long.Parse(command[1])];
            nums[long.Parse(command[1])] = nums[long.Parse(command[2])];
            nums[long.Parse(command[2])] = temp;
        }
    }
}
