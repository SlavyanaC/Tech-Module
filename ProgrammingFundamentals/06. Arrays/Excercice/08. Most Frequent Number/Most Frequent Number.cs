using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Most_Frequent_Number
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
            int[] count = new int[65535];
            foreach (int element in array)
            {
                count[element]++;
            }

            int maxCount = count.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxCount)
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
        }
    }
}