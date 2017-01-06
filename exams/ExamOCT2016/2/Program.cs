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

            for (int i = 0; i < possitions.Length; i++)
            {
                if (possitions[i] <= field.Length - 1)
                {
                    field[possitions[i]] = 1;
                }
            }

            string commandInput = Console.ReadLine();
            while (commandInput != "end")
            {
                var command = commandInput.Split().ToArray();

                var bugIndex = long.Parse(command[0]);
                var direction = command[1];
                var flyLenght = long.Parse(command[2]);


                if (bugIndex < field.Length && bugIndex >= 0)
                {
                    long flyTOindex = 0;
                    if (direction == "right")
                    {
                        if (flyLenght < 0)
                        {
                            flyTOindex = bugIndex - flyLenght;
                        }
                        else
                        {
                            flyTOindex = bugIndex + flyLenght;

                        }

                        if (field[bugIndex] == 1 && flyTOindex <= field.Length - 1)
                        {
                            field[bugIndex] = 0;

                            if (field[flyTOindex] == 0)
                            {
                                field[flyTOindex] = 1;
                            }
                            else if (flyTOindex <= field.Length - 1 && field[flyTOindex] == 1)
                            {
                                while (field[flyTOindex] == 1 && flyTOindex <= field.Length - 1)
                                {
                                    if (flyTOindex + flyLenght <= field.Length - 1)
                                    {
                                        flyTOindex += flyLenght;
                                        if (field[flyTOindex] == 0)
                                        {
                                            field[flyTOindex] = 1;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            field[bugIndex] = 0;
                        }
                    }

                    if (direction == "left")
                    {

                        if (flyLenght > 0)
                        {
                            flyTOindex = bugIndex + flyLenght;
                        }
                        else
                        {
                            flyTOindex = bugIndex - flyLenght;

                        }
                        flyTOindex = bugIndex - flyLenght;
                        if (flyTOindex >= 0)
                        {
                            //
                            if (field[bugIndex] == 1 && flyTOindex <= field.Length - 1 && flyTOindex >= 0)
                            {
                                field[bugIndex] = 0;

                                if (field[flyTOindex] == 0)
                                {
                                    field[flyTOindex] = 1;
                                }
                                else if (flyTOindex <= field.Length - 1 && field[flyTOindex] == 1)
                                {
                                    while (field[flyTOindex] == 1 && flyTOindex <= field.Length - 1)
                                    {
                                        if (flyTOindex + flyLenght <= field.Length - 1)
                                        {
                                            flyTOindex += flyLenght;
                                            if (field[flyTOindex] == 0)
                                            {
                                                field[flyTOindex] = 1;
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            field[bugIndex] = 0;
                        }
                    }
                }

                commandInput = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", field));


        }
    }
}