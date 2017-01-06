using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums.Take(i).Sum() == nums.Skip(i + 1).Take(nums.Length - i).Sum())
                    index = i;


            if (index >0)
                Console.WriteLine(index);
            else
                Console.WriteLine("no");
        }
    }
}















//var input = Console.ReadLine().Split().ToList();

//var left = 0;
//var right = 0;

//input.Insert(input.Count, "0");
//input.Insert(0, "0");

//string nums = string.Concat(input);

//for (int i = 1; i <= nums.Length - 1; i++)
//{
//    left = (int)nums.Substring(0, i).ToString().Sum(s => char.GetNumericValue(s));

//    if (i == input.Count - 2)
//    {
//        right = 0;
//        break;
//    }
//    else {
//        right = (int)nums.Substring(i + 1, nums.Length - i - 2).ToString().Sum(s => char.GetNumericValue(s));
//    }

//    if (left == right)
//    {
//        Console.WriteLine(i - 1);
//        break;
//    }
//}



