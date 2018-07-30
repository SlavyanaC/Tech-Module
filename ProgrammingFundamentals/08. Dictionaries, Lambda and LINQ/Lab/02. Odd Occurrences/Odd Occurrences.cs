using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input  = Console.ReadLine();
            var words = input.ToLower().Split(' ');
            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
            
            List<string> result = new List<string>();
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
