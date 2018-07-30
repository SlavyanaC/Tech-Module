using System;

namespace _14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char finalLetter = char.Parse(Console.ReadLine());
            string skipLetter = Console.ReadLine();

            string result = string.Empty;

            for (char firstLetter = startLetter; firstLetter <= finalLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= finalLetter; secondLetter++)
                {
                    for (char thirdLetter = startLetter; thirdLetter <= finalLetter; thirdLetter++)
                    {
                        result = $"{firstLetter}{secondLetter}{thirdLetter}";

                        if (!result.Contains(skipLetter))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
        }
    }
}