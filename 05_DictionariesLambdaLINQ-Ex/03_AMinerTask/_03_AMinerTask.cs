using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AMinerTask
{
    class _03_AMinerTask
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            string resourse = Console.ReadLine().ToLower();
            while (resourse != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(resourse))
                {
                    dict[resourse] += quantity;
                }
                else if (!dict.ContainsKey(resourse))
                {
                    dict.Add(resourse, quantity);
                }

                resourse = Console.ReadLine().ToLower();
                if (resourse == "stop")
                {
                    break;
                }
            }

            var gold = new List<int>();
            var silver = new List<int>();
            var copper = new List<int>();

            foreach (KeyValuePair<string, int> item in dict)
            {
                if (item.Key == "gold")
                {
                    gold.Add(item.Value);
                }
                else if (item.Key == "silver")
                {
                    silver.Add(item.Value);
                }
                else if (item.Key == "copper")
                {
                    copper.Add(item.Value);
                }
            }

            Console.WriteLine("gold -> {0}\nsilver -> {1}\ncopper -> {2}", gold.Sum(), silver.Sum(), copper.Sum());
        }
    }
}
