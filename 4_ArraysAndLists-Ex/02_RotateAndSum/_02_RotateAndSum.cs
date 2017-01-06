using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RotateAndSum
{
    class _02_RotateAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            var temp = new int [input.Length];
            
           // var sum = new List<int>();

            
            for (int j = 0; j < input.Length; j++)
            {
                temp[(j + 1) % temp.Length] = input[j];
               // sum[j] += temp[j];
            }
            Console.WriteLine(string.Join(" ", temp));

            //Console.WriteLine(string.Join(" ",sum));
        }
        }
}
