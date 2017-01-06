using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbols = new char[] { ' ' };
            var command = new List<string>();

            var text = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                command = input.Split().ToList();
                switch (command[0])
                {
                    case "reverse": ReverseOrSort(command, text); break;
                    case "sort": ReverseOrSort(command, text); break;
                    case "rollLeft": RollLeft(command, text); break;
                    case "rollRight": RollRight(command, text); break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Concat("[", string.Join(", ", text), "]"));
        }


        static void RollRight(List<string> command, List<string> text)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count % text.Count; i++)
            {
                text.Insert(0, text[text.Count - 1]);
                text.RemoveAt(text.Count - 1);
            }


            //string lastIndexValue = "";
            //for (int i = 0; i < count; i++)
            //{
            //    lastIndexValue = text[text.Count - 1];
            //    text.RemoveAt(text.Count - 1);
            //    text.Insert(0, lastIndexValue);
            //}
            //var start = (text.Count) - int.Parse(command[1]);
            //var inputRight = text.GetRange(start, count);
            //text.RemoveRange(start, count);
            //text.InsertRange(0, inputRight);
        }

        static void RollLeft(List<string> command, List<string> text)
        {
            var count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            for (int i = 0; i < count % text.Count; i++)
            {
                text.Add(text[0]);
                text.RemoveAt(0);
            }

        }
        static void ReverseOrSort(List<string> command, List<string> text)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);

            if (start < 0 || count < 0 || start + count > text.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            var portionList = text.GetRange(start, count);
            if (command[0] == "reverse")
            {
                portionList.Reverse();
            }
            else if (command[0] == "sort")
            {
                portionList.Sort();
            }
            text.RemoveRange(start, count);
            text.InsertRange(start, portionList);
        }
    }
}
