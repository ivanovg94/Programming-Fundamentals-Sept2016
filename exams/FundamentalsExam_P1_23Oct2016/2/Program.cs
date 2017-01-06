using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var field = new int[size];

            var possitions = Console.ReadLine().Split().Select(long.Parse).ToArray();

            foreach (long pos in possitions)
            {
                if (pos <= size - 1)
                {
                    field[pos] = 1;
                }
            }
           Console.WriteLine(string.Join(" ", field));

            string commandInput = Console.ReadLine();
            while (commandInput != "end")
            {
                var command = commandInput.Split().ToArray();

                var bugIndex = long.Parse(command[0]);
                var direction = command[1];
                var flyLenght = long.Parse(command[2]);

                if (field[bugIndex] == 1 && bugIndex <= size - 1)
                {
                    field[bugIndex] = 0;
                    if (flyLenght < 0)
                    {
                        switch (direction)
                        {
                            case "right": direction = "left"; break;
                            case "left": direction = "right"; break;
                        }
                        flyLenght = Math.Abs(flyLenght);
                    }
                    switch (direction)
                    {
                        case "right":
                            while (bugIndex + flyLenght <= size - 1 && field[bugIndex + flyLenght] == 1)
                            {
                                flyLenght +=Math.Abs(int.Parse(command[2]));
                                if (bugIndex + flyLenght >= size - 1)
                                {
                                    break;
                                }
                            }
                            if (bugIndex + flyLenght <= size - 1)
                            {
                                field[bugIndex + flyLenght] = 1;
                            }
                         Console.WriteLine(string.Join(" ", field));

                            break;

                        case "left":
                            while (bugIndex - flyLenght >= 0 && field[bugIndex - flyLenght] == 1)
                            {
                                flyLenght += Math.Abs(int.Parse(command[2]));
                                if (bugIndex - flyLenght <0)
                                {
                                    break;
                                }
                            }
                            if (bugIndex - flyLenght >=0)
                            {
                                field[bugIndex - flyLenght] = 1;
                            }
                            Console.WriteLine(string.Join(" ", field));

                            break;
                    }
                }
                commandInput = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));

        }
    }
}
