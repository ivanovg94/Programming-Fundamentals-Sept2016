using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SumAdjacentEqualNumbers
{
    class _12_SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(decimal.Parse).ToList();


            int pos = 0;
            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    nums.RemoveAt(pos);
                    nums[pos] = 2 * nums[pos];
                    pos--; // TODO: ensure the position is non-negative
                }
                else {
                    pos++;
                }

                if (pos < 0)
                {
                    pos = 0;
                }
            }
            Console.WriteLine(string.Join(" ", nums));









            //for (int i = 0; i <= input.Count; i++)
            //{

            //    if (i == input.Count - 1 && input[i] == input[i - 1])
            //    {

            //        input[i - 1] = 2 * input[i - 1];
            //        input.Remove(input[i]);

            //        break;
            //    }

            //    if (i != 0)
            //    {
            //        if (input[i] == input[i - 1])
            //        {
            //            i--;
            //        }
            //    }

            //    if (input[i] == input[i + 1])
            //    {
            //        input.Remove(input[i]);
            //        input[i] = 2 * input[i];
            //        i--;

            //    }

            //}


            //foreach (var item in input)
            //{
            //    Console.Write(item + " ");
            //}









            //for (int i = 1; i <= n - 1; i++)
            //{

            //    if (i == n && input[i] == input[i - 1])
            //    {

            //        input[i - 1] = 2 * input[i - 1];
            //        input.Remove(input[i]);
            //        break;
            //    }
            //    if (input[i] == input[i + 1])
            //    {
            //        input.Remove(input[i]);
            //        input[i + 1] = 2 * input[i + 1];
            //        n--;
            //    }
            //}
            //foreach (var item in input)
            //{
            //    Console.Write(item + " ");
            //}

        }
    }
}
