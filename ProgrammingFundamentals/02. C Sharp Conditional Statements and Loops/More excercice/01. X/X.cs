using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int a = 0; a < n / 2; a++)
        {
            Console.Write(new string(' ', a) + 'x');
            Console.WriteLine(new string(' ', n - 2 - a * 2) + 'x');
        }
        Console.WriteLine(new string(' ', n / 2) + 'x');

        for (int a = n / 2 - 1; a >= 0; a--)
        {
            Console.Write(new string(' ', a) + 'x');
            Console.WriteLine(new string(' ', n - 2 - a * 2) + 'x');
        }
    }
}