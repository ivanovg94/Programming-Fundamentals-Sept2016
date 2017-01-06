using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Phonebook
{
    class _01_Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var phonebook = new Dictionary<string, string>();
            string singleString = "";
            List<string> result = new List<string>();
            while (!input[0].Equals("END"))
            {
                switch (input[0])
                {
                    case "A":
                        if (!phonebook.Keys.Contains(input[1]))
                        {
                            phonebook.Add(input[1], input[2]);
                        }
                        else
                        {
                            phonebook[input[1]] = input[2];

                        }
                        break;
                    case "S":
                        if (!phonebook.ContainsKey(input[1]))
                        {
                            singleString= "Contact "+input[1] +" does not exist.";
                            result.Add(singleString);
                        }
                        else
                        {
                            singleString=input[1]+" -> "+ phonebook[input[1]];
                            result.Add(singleString);

                        }
                        break;
                }
                input.Clear();
                input = Console.ReadLine().Split().ToList();
                if (input[0].Equals("END"))
                {
                    break;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
