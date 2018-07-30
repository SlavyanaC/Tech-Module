using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var sizeField = long.Parse(Console.ReadLine());
            var initialIndexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            var command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            bool[] occupiedIndexes = new bool[sizeField];
            for (long i = 0; i < sizeField; i++)
            {
                if (initialIndexes.Contains(i))
                {
                    occupiedIndexes[i] = true;
                }
            }

            while (command[0] != "end")
            {
                if (command[1] == "right")
                {
                    var positionToTake = long.Parse(command[0]);
                    var positionsToMove = long.Parse(command[2]);

                    if (positionToTake < 0  ||positionToTake >= sizeField || occupiedIndexes[positionToTake] == false)
                    {
                        command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    else
                    {
                        occupiedIndexes[positionToTake] = false;
                        if (positionToTake + positionsToMove >= sizeField)
                        {
                            command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                            continue;
                        }

                        if (occupiedIndexes[positionToTake + positionsToMove] == false)
                        {
                            occupiedIndexes[positionToTake + positionsToMove] = true;
                        }
                        else
                        {
                            for (long i = positionToTake + positionsToMove; i < sizeField; i += positionsToMove)
                            {
                                if (occupiedIndexes[i] == false)
                                {
                                    occupiedIndexes[i] = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    var positionToTake = long.Parse(command[0]);
                    var positionsToMove = long.Parse(command[2]);

                    if (positionToTake < 0 || positionToTake >= sizeField || occupiedIndexes[positionToTake] == false)
                    {
                        command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    else
                    {

                        occupiedIndexes[positionToTake] = false;
                        if (positionToTake - positionsToMove < 0)
                        {
                            command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                            continue;
                        }

                        if (occupiedIndexes[positionToTake - positionsToMove] == false)
                        {
                            occupiedIndexes[positionToTake - positionsToMove] = true;
                        }
                        else
                        {
                            for (long i = positionToTake - positionsToMove; i >= 0; i -= positionsToMove)
                            {
                                if (occupiedIndexes[i] == false)
                                {
                                    occupiedIndexes[i] = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var position in occupiedIndexes)
            {
                if (position == false)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write("1 ");
                }
            }
            Console.WriteLine();
        }
    }
}