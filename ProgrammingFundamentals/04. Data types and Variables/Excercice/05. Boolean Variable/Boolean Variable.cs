using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine().ToLower();

        if (a == "true")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}