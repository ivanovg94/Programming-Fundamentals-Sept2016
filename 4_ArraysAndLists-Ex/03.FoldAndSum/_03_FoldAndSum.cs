using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class _03_FoldAndSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listFirst = new List<int>();
            List<int> listMiddle = new List<int>();
            List<int> listSecond = new List<int>();

            int k = numbers.Count / 4;
            var elementsFirst = numbers.Take(k).Reverse().ToList();
            listFirst = elementsFirst.GetRange(0, k);

            numbers.RemoveRange(0, k);
            listMiddle = numbers.GetRange(0, k * 2);

            numbers.RemoveRange(0, k * 2);
            numbers.Reverse();

            var sumListFirst = listFirst.Concat(numbers).ToList();

            var sum = Enumerable.Zip(listMiddle, sumListFirst, (a, b) => a + b);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
