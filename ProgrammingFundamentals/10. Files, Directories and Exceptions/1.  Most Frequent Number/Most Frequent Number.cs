using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Most_Frequent_Number
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("../../input.txt");
            int[] array = input
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
                    string result = array[i].ToString();
                    File.WriteAllText("../../output.txt", array[i].ToString());
                    return;
                }
            }
        }
    }
}