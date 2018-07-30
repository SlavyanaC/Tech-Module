using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            var words = input.Split(new char[] 
                                    { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' },
                                    StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();
            var result = words
                .Where(w => w != "")
                .Where(w => w.Length < 5)
                .OrderBy(w => w).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
