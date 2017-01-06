using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { ',', ' ' };
            var demons = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();
            var demonsNstats = new Dictionary<string, string>();
            string patternNums = @"-?\d+(?:\.\d+)?";
            string patternW = @"[^\d+\-*\/ ,.]";
            Regex regexW = new Regex(patternW);
            Regex regexN = new Regex(patternNums);
            var nums = new List<decimal>();
            var letters = new List<string>();

            decimal dmg = 0;
            decimal hp = 0;
            foreach (var demonName in demons)
            {
                MatchCollection matchesN = Regex.Matches(demonName, patternNums);
                foreach (Match match in matchesN)
                {
                    string matchStr = match.ToString();
                    var n = Convert.ToDecimal(matchStr);
                    nums.Add(n);
                }
                dmg = CountDmg(demonName, nums);


                MatchCollection matchesW = Regex.Matches(demonName, patternW);
                foreach (Match match in matchesW)
                {
                    letters.Add(match.ToString());
                }
                hp = CountHP(demonName, letters);

                string strDMG = string.Format("{0:F2}", dmg);


                string stats = string.Concat(hp, " health, ", strDMG, " damage");
                string name = demonName;

                demonsNstats.Add(name, stats);


                nums.Clear();
                letters.Clear();
            }

            var sortedDemons = demonsNstats.OrderBy(x => x.Key);
            foreach (KeyValuePair<string, string> pair in sortedDemons)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

        }

        static decimal CountHP(string demonName, List<string> letters)
        {
            long hp = 0;
            char[] newLetters = string.Concat(letters).ToCharArray();
            foreach (char c in newLetters)
            {
                hp += c;
            }
            return hp;
        }

        static decimal CountDmg(string demonName, List<decimal> nums)
        {
            decimal baseDmg = 0;
            decimal totalDmg = 0;
            baseDmg = nums.Sum();
            decimal countMul = 0;
            decimal countDiv = 0;

            foreach (char c in demonName)
            {
                if (c == '*')
                {
                    countMul++;
                }
                if (c == '/')
                {
                    countDiv++;
                }
            }
            totalDmg = baseDmg;
            if (demonName.Contains('*'))
            {
                totalDmg *= 2 * countMul;
            }
            else if (demonName.Contains('/'))
            {
                totalDmg /= 2 * countDiv;
            }
            return totalDmg;

        }
    }
}
