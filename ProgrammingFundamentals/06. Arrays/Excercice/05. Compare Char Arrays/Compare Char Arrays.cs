﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            if (firstArray.Length == secondArray.Length)
            {
                if (firstArray[0] < secondArray[0])
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
            else
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
        }
    }
}