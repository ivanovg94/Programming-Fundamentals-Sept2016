using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            Dictionary<string, string> result = new Dictionary<string, string>();
            while (input != "END")
            {
                while (input != "ListAll")
                {
                    string[] parts = input.Split(' ');
                    dictionary.Add(parts[1], parts[2]);
                    input = Console.ReadLine();
                }
                foreach (var key in dictionary)
                {
                    result.Add(key.Key, key.Value);
                }
                dictionary.Clear();
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            //var input = Console.ReadLine().Split().ToList();
            //var phonebook = new Dictionary<string, string>();
            //string singleString = "";
            //List<string> result = new List<string>();
            //List<string> resultALL = new List<string>();

            //while (!input[0].Equals("END"))
            //{
            //    switch (input[0])
            //    {
            //        case "A":
            //            if (!phonebook.Keys.Contains(input[1]))
            //            {
            //                phonebook.Add(input[1], input[2]);
            //            }
            //            else
            //            {
            //                phonebook[input[1]] = input[2];
            //            }
            //            singleString = input[1] + " -> " + phonebook[input[1]];
            //            resultALL.Add(singleString);
            //            break;
            //        case "S":
            //            if (!phonebook.ContainsKey(input[1]))
            //            {
            //                singleString = "Contact " + input[1] + " does not exist.";
            //                result.Add(singleString);
            //                resultALL.Add(singleString);

            //            }
            //            else
            //            {
            //                singleString = input[1] + " -> " + phonebook[input[1]];
            //                result.Add(singleString);
            //                resultALL.Add(singleString);
            //            }
            //            break;
            //    }
            //    input.Clear();
            //    input = Console.ReadLine().Split().ToList();

            //    if (input[0].Equals("ListAll"))
            //    {
            //        resultALL.Sort();
            //        foreach (var item in resultALL)
            //        {
            //            Console.WriteLine(item);
            //        }
            //        break;
            //    }
            //    if (input[0].Equals("END"))
            //    {
            //        break;
            //    }
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
