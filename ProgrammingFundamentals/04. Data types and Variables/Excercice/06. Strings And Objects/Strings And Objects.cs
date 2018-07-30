using System;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object concatination = hello +' '+ world;
            string output = Convert.ToString(concatination);
            Console.WriteLine(output);
        }
    }
}
