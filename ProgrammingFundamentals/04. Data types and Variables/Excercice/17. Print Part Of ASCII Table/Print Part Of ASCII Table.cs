using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (char currentChar = (char)start; currentChar <= end; currentChar++)
            {
                Console.Write(currentChar + " ");
            }
        }
    }
}
