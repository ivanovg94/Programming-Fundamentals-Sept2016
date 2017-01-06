using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HandOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            var dic = new Dictionary<string, List<string>>();
            var values = new List<string>();
            var nameNcards = new List<string>();
            string keys = "";
            int points = 0;
            var allValues = new List<string>();
            var input = Console.ReadLine();
            while (input != "JOKER")
            {
                input = input.Replace(" ", "");
                nameNcards = input.Split(':').ToList();
                keys = nameNcards[0];
                values = nameNcards[1].Split(',').ToList();

                allValues.AddRange(values);
                allValues = allValues.Distinct().ToList();
                if (dic.ContainsKey(keys))
                {


                    dic[keys] = allValues;
                }
                else
                {
                    dic.Add(keys, allValues);
                }
                dic[allValues].Distinct();
                input = Console.ReadLine();
                //allValues.Clear();
                //values.Clear();

            }














            foreach (var item in values)
            {
                points += CalcPower(item) * CalcType(item);

            }


            //foreach (KeyValuePair<string, int> kvp in dic)
            //{
            //    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            //}
        }

        static int CalcType(string item)
        {
            int type = 0;
            switch (item.Last())
            {
                case 'C': type = 1; break;
                case 'D': type = 2; break;
                case 'H': type = 3; break;
                case 'S': type = 4; break;
            }
            return type;

        }

        static int CalcPower(string item)
        {
            int power = 0;
            if (item.Length == 2)
            {
                switch (item[0])
                {
                    case '2': power = 2; break;
                    case '3': power = 3; break;
                    case '4': power = 4; break;
                    case '5': power = 5; break;
                    case '6': power = 6; break;
                    case '7': power = 7; break;
                    case '8': power = 8; break;
                    case '9': power = 9; break;
                    case 'J': power = 11; break;
                    case 'Q': power = 12; break;
                    case 'K': power = 13; break;
                    case 'A': power = 14; break;
                }

            }
            else if (item.Length == 3)
            {
                power = 10;
            }
            return power;
        }
    }
}
