using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            var files = new Dictionary<string, Dictionary<string, string>>();
            for (int line = 1; line <= nLines; line++)
            {
                var initialInput = Console.ReadLine().Split(';').ToArray();
                var fileSize = initialInput.Last();
                var root = initialInput.First().Split('\\').First();
                var file = initialInput.First().Split('\\').Last();

                if (!files.ContainsKey(root))
                {
                    files.Add(root, new Dictionary<string, string>());
                }

                if (files[root].ContainsKey(file))
                {
                    files[root].Remove(file);
                }
                files[root].Add(file, fileSize);
            }

            var command = Console.ReadLine().Split().ToArray();
            string searchedExt = command.First();
            string searchedRoot = command.Last();
            int counter = 0;


            var sorted = files.Where(x => x.Key == searchedRoot).OrderByDescending(f => f.Value.Values);

            foreach (var r in sorted)
            {
                foreach (var item in r.Value.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
                {
                    if (item.Key.Split('.').Last() == searchedExt)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }



        }
    }
}
