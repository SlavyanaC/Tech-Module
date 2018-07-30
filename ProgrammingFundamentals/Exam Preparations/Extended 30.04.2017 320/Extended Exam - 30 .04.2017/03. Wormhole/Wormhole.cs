using System;
using System.Linq;

namespace _03.Wormhole
{
    //100/100
    class Wormhole
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var steps = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == 0)
                {
                    steps++;
                }
                else
                {
                    steps++;
                    var value = sequence[i];
                    sequence[i] = 0;
                    i = value;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
