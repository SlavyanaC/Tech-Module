using System;
using System.Linq;
using System.Numerics;


namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(new char[] { ' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            var result = 0.0m;
            foreach (var word in input)
            {
                char[] chars = word.ToCharArray();
                var numberAsStr = string.Empty;
                for (int i = 1; i < chars.Length - 1; i++)
                {
                    numberAsStr = numberAsStr + chars[i];
                }
                var number = decimal.Parse(numberAsStr);

                int positionFirstChar = 0;
                if (chars[0] >= 65 && chars[0] < 91)
                {
                    positionFirstChar = chars[0] - 64;
                    number = number / positionFirstChar;
                }
                else if (chars[0] >= 97 && chars[0] < 123)
                {
                    positionFirstChar = chars[0] - 96;
                    number = number * positionFirstChar;
                }

                int positionLastChar = 0;
                if (chars[chars.Length - 1] >= 65 && chars[chars.Length - 1] < 91)
                {
                    positionLastChar = chars.Last() - 64;
                    result += number - positionLastChar;
                }
                else if (chars[chars.Length - 1] >= 97 && chars[chars.Length - 1] < 123)
                {
                    positionLastChar = chars.Last() - 96;
                    result += number + positionLastChar;
                }
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
