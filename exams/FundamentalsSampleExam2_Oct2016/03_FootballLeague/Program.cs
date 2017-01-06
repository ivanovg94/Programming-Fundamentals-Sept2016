using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesNpoints = new Dictionary<string, int>();
            var gamesNGoals = new Dictionary<string, int>();

            var team = new List<string>();
            var firstPoints = 0;
            var secondPoint = 0;
            string keyEscaped = "";
            var keyInput = Console.ReadLine().ToCharArray();
            if (char.IsLetterOrDigit(keyInput[0]))
            {
                keyEscaped = string.Concat(keyInput);
            }
            else
            {
                keyEscaped = "\\" + string.Join("\\", keyInput);
            }
            string pattern = keyEscaped + "\\w+" + keyEscaped;
            string input = Console.ReadLine();
            while (input != "final")
            {
                var line = input.Split().ToList();
                var gameTeams = string.Concat(line[0], " ", line[1]);
                var goals = line[2].Split(':').Select(int.Parse).ToArray();


                Regex regex = new Regex(pattern);
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    var temp = match.Groups[0].ToString().Reverse().ToList();
                    temp.RemoveRange(0, keyInput.Length);
                    temp.RemoveRange((temp.Count - keyInput.Length), keyInput.Length);
                    string t = string.Concat(temp).ToUpper();
                    team.Add(t);
                }

                var firstGoals = goals[0];
                var secondGoals = goals[1];

                if (firstGoals > secondGoals)
                {
                    firstPoints += 3;
                    secondPoint += 0;
                }
                else if (firstGoals < secondGoals)
                {
                    firstPoints += 0;
                    secondPoint += 3;
                }
                else if (secondGoals == firstGoals)
                {
                    firstPoints += 1;
                    secondPoint += 1;
                }



                if (gamesNpoints.ContainsKey(team[0]))
                {
                    gamesNpoints[team[0]] += firstPoints;
                }
                else if (!gamesNpoints.ContainsKey(team[0]))
                {
                    gamesNpoints.Add(team[0], firstPoints);
                }

                if (gamesNpoints.ContainsKey(team[1]))
                {
                    gamesNpoints[team[1]] += secondPoint;
                }
                else if (!gamesNpoints.ContainsKey(team[1]))
                {
                    gamesNpoints.Add(team[1], secondPoint);
                }


                if (gamesNGoals.ContainsKey(team[0]))
                {
                    gamesNGoals[team[0]] += firstGoals;
                }
                else if (!gamesNGoals.ContainsKey(team[0]))
                {
                    gamesNGoals.Add(team[0], firstGoals);
                }

                if (gamesNGoals.ContainsKey(team[1]))
                {
                    gamesNGoals[team[1]] += secondGoals;
                }
                else if (!gamesNGoals.ContainsKey(team[1]))
                {
                    gamesNGoals.Add(team[1], secondGoals);
                }

                team.Clear();
                firstPoints = 0;
                secondPoint = 0;


                input = Console.ReadLine();

            }


            IOrderedEnumerable<KeyValuePair<string, int>> sortedCollection = gamesNpoints
                  .OrderByDescending(x => x.Value)
                  .ThenBy(x => x.Key);


           
            int count = 0;
            Console.WriteLine("League standings:");
            foreach (KeyValuePair<string, int> pair in sortedCollection)
            {
                count++;
                Console.WriteLine("{0}. {1} {2}", count, pair.Key, pair.Value);
            }


            var sortedCollection1 = gamesNGoals
                  .OrderByDescending(x => x.Value)
                  .ThenBy(x => x.Key)
                  .Take(3);

            Console.WriteLine("Top 3 scored goals:");
           // int count1 = 0;


           // var topThree = (from i in sortedCollection1 select i).Take(3);



            foreach (KeyValuePair<string, int> pair in sortedCollection1)
            {
                
                Console.WriteLine("- {0} -> {1}", pair.Key, pair.Value);
                //count1++;
                //if (count1 == 3)
                //{
                //    break;
                //}
            }



        }
    }
}
