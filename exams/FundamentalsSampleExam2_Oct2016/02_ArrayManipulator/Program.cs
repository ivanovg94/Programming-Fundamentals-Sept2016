using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            var command = new List<string>();
            while (input != "end")
            {
                command = input.ToLower().Split().ToList();
                switch (command[0])
                {
                    case "exchange":
                        Exchange(command, arr);
                        break;

                    case "max":
                        Max(command, arr);
                        break;

                    case "min":
                        Min(command, arr);
                        break;

                    case "first":
                        First(command, arr);
                        break;

                    case "last":
                        Last(command, arr);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        static void Last(List<string> command, List<int> arr)
        {
            var list = new List<int>();
            int n = int.Parse(command[1]);

            if (n > arr.Count || n<0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            switch (command[2])
            {
                case "even":
                    for (int i = arr.Count - 1; i >= 0; i--)
                    {
                        if (Math.Abs(arr[i]) % 2 == 0)
                        {
                            list.Add(arr[i]);
                        }
                    }
                    list.Reverse();

                    if (n > list.Count)
                    {
                        Console.WriteLine(string.Concat("[", string.Join(", ", list), "]"));
                    }
                    else
                    {
                        var res = list.GetRange(list.Count - int.Parse(command[1]), int.Parse(command[1]));
                        Console.WriteLine(string.Concat("[", string.Join(", ", res), "]"));
                    }

                    list.Clear();
                    break;

                case "odd":
                    for (int i = arr.Count - 1; i >= 0; i--)
                    {
                        if (Math.Abs(arr[i]) % 2 != 0)
                        {
                            list.Add(arr[i]);
                        }
                    }
                    list.Reverse();
                    if (n > list.Count)
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", list));
                    }
                    else
                    {
                        var res = list.GetRange(list.Count - int.Parse(command[1]), int.Parse(command[1]));
                        Console.WriteLine("[{0}]", string.Join(", ", list));
                        res.Clear();
                    }
                    list.Clear();
                    break;
            }
        }

        static void First(List<string> command, List<int> arr)
        {
            var list = new List<int>();
            int n = int.Parse(command[1]);

            if (n > arr.Count || n < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            switch (command[2])
            {
                case "even":
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            list.Add(arr[i]);
                        }
                    }
                    if (n >= list.Count)
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", list));
                    }
                    else if (n < list.Count)
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", list.GetRange(0, n)));
                    }

                    list.Clear();
                    break;

                case "odd":
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            list.Add(arr[i]);
                        }
                    }
                    if (n >= list.Count)
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", list));
                    }
                    else if (n < list.Count)
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", list.GetRange(0, n)));
                    }

                    list.Clear();
                    break;
            }
        }

        static void Min(List<string> command, List<int> arr)
        {
            int best = int.MaxValue;
            int index = int.MaxValue; ;
            switch (command[1])
            {
                case "even":
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (Math.Abs(arr[i]) % 2 == 0 && arr[i] <= best)
                        {
                            best = arr[i];
                            index = i;
                        }
                    }
                    break;

                case "odd":
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] % 2 != 0 && arr[i] <= best)
                        {
                            best = arr[i];
                            index = i;
                        }
                    }
                    break;
            }
            if (index == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void Max(List<string> command, List<int> arr)
        {
            int best = int.MinValue;
            int index = int.MinValue;
            switch (command[1])
            {
                case "even":
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (Math.Abs(arr[i]) % 2 == 0 && arr[i] >= best)
                        {
                            best = arr[i];
                            index = i;
                        }
                    }
                    break;

                case "odd":
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (Math.Abs(arr[i]) % 2 != 0 && arr[i] >= best)
                        {
                            best = arr[i];
                            index = i;
                        }
                    }
                    break;
            }
            if (index == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void Exchange(List<string> command, List<int> arr)
        {
            if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > arr.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            var index = int.Parse(command[1]) + 1;
            var count = arr.Count - index;
            var exchange = arr.GetRange(index, count);
            arr.RemoveRange(index, count);
            arr.InsertRange(0, exchange);
        }
    }
}