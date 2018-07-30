using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Max_Sequence_of_Increasing_Elements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int currentStart = 0;
            int currentLen = 1;
            int maxStart = 0;
            int maxLen = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLen = 1;
                }
            }

            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}