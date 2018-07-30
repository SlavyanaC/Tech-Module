using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i-1])
                {
                    len++;
                    start = array[i];
                }
                else
                {
                    len = 1;
                    start = array[i];
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < bestLen; i++)
            {
                result.Add(bestStart);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
