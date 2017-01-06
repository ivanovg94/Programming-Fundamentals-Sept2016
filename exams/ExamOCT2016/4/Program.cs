using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var code = new Dictionary<string, Dictionary<string, SortedSet<string>>>();


            while (!input.Equals("Time for Code"))
            {
                var command = input
                  .Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

                string id = command[0];
                string eventName = command[1].TrimStart('#');

                var dublicatedNames = command.GetRange(2, command.Count - 2);
                SortedSet<string> names = new SortedSet<string>();
                foreach (var name in dublicatedNames)
                {
                    names.Add(name);
                }

                if (!code.ContainsKey(id))
                {
                    code.Add(id, new Dictionary<string, SortedSet<string>>());
                }
                if (code[id].Values.Count == 0)
                {
                    code[id].Add(eventName, names);
                }
                else if (code[id].Values.Count == 1 && code[id].ContainsKey(eventName))
                {
                    //  code[id][eventName].AddRange(names);
                    foreach (var name in names)
                    {
                        code[id][eventName].Add(name);
                    }
                }

                input = Console.ReadLine();
            }



            //    var sorted = code.OrderByDescending(a => a.Value.Values.Count);

            //var sorted = code.Values.OrderByDescending(a => a.Values.Count);

            //foreach (var r in code)
            //{

            //    foreach (var item in r.Value.OrderBy(x => x.Value.Count))
            //    {   
            //        Console.WriteLine(item.Key + " - " + item.Value.Count);
            //        foreach (var item1 in item.Value)
            //        {
            //            Console.WriteLine(item1);
            //        }
            //    }
            //}


            //foreach (var pair in code.OrderByDescending(a => a.Value.Values.Sum(p => p.Count)).ThenBy(a => a.Key))
            //{
            //    foreach (var innerpair in code[pair.Key])
            //    {
            //        Console.WriteLine($"{innerpair.Key} - {innerpair.Value.Count}");
            //        code[pair.Key][innerpair.Key].Sort();
            //        for (int i = 0; i < innerpair.Value.Count; i++)
            //        {
            //            Console.WriteLine("@" + code[pair.Key][innerpair.Key][i]);
            //        }
            //    }

            //}


            foreach (KeyValuePair<string, Dictionary<string, SortedSet<string>>> pair in code.OrderByDescending(a => a.Value.Values.Sum(p => p.Count)).ThenBy(a => a.Key))
            {
                foreach (KeyValuePair<string, SortedSet<string>> innerpair in code[pair.Key])
                {
                    Console.WriteLine($"{innerpair.Key} - {innerpair.Value.Count}");
                    foreach (string s in innerpair.Value)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

        }
    }
}