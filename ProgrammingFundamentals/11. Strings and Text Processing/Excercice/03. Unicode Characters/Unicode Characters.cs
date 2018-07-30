using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            foreach (var ch in input)
            {
                Console.Write("\\u" + ((int)ch).ToString("x4"));
            }
        }
    }
}
