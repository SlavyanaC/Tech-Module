using System;
using System.Linq;

namespace p02Icarus
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var startingPosition = int.Parse(Console.ReadLine());
            var damage = 1;


            while (true)
            {
                var command = Console.ReadLine().Split(' ');
                if (command[0] == "Supernova")
                {
                    break;
                }
                var direction = command[0];
                var steps = int.Parse(command[1]);
                if (direction == "left")
                {
                    if (startingPosition - steps >= 0)
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            inputLine[startingPosition - 1] -= damage;
                            startingPosition--;
                        }
                    }
                    else
                    {
                        while (steps > 0)
                        {
                            startingPosition--;
                            if (startingPosition < 0)
                            {
                                startingPosition = inputLine.Length - 1;
                                damage++;
                            }
                            inputLine[startingPosition] -= damage;
                            steps--;
                        }
                    }
                }
                else if (direction == "right")
                {
                    if (startingPosition + steps <= inputLine.Length - 1)
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            inputLine[startingPosition + 1] -= damage;
                            startingPosition++;
                        }
                    }
                    else
                    {
                        while (steps > 0)
                        {
                            startingPosition++;
                            if (startingPosition > inputLine.Length - 1)
                            {
                                startingPosition = 0;
                                damage++;
                            }
                            inputLine[startingPosition] -= damage;
                            steps--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}