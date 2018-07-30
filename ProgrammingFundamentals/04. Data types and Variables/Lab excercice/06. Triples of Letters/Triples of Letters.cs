using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter < 'a' + num; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter < 'a' + num; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < 'a' + num; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}