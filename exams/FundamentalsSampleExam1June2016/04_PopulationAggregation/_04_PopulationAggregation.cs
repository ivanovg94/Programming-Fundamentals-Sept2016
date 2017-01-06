using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PopulationAggregation
{
    class _04_PopulationAggregation
    {
        static void Main(string[] args)
        {
            string country = "";
            string city = "";
            var countries = new SortedDictionary<string, int>();
            var cities = new Dictionary<string, long>();

            string input = Console.ReadLine();
            while (input != "stop")
            {
                var command = input.Split('\\').ToList();
                if (char.IsUpper(command[0].First()))
                {
                    country = command[0];
                    city = command[1];
                }
                else if (char.IsLower(command[0].First()))
                {
                    country = command[1];
                    city = command[0];
                }
                country = RemovePh(country);
                city = RemovePh(city);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, 1);
                }
                else
                {
                    countries[country]++;
                }
                long population = long.Parse(command[2]);
                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, population);
                }
                else
                {
                    cities[city] = population;
                }
             
                input = Console.ReadLine();
            }
            var top3 = (from entry in cities
                        orderby entry.Value descending
                        select entry)
                         .Take(3)
                         .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<string, int> kvp in countries)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }

            foreach (KeyValuePair<string, long> kvp in top3)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);

            }
        }


        static string RemovePh(string value)
        {
            string temp = value;
            temp = temp.Replace("@", "");
            temp = temp.Replace("#", "");
            temp = temp.Replace("$", "");
            temp = temp.Replace("&", "");
            for (int i = 0; i <= 9; i++)
            {
                temp = temp.Replace(i.ToString(), "");
            }
            return temp;
        }
    }
}

