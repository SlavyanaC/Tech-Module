using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderFooter(n);
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write("-");

            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
