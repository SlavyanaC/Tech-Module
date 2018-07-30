using System;
using System.Linq;
using System.Text;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            var mult = 0;
            var number = 0;
            var reminder = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                mult = (first[i] - 48) * (second[0] - 48) + reminder;
                number = mult % 10;
                sb.Append(number);
                reminder = mult / 10;
                if (i == 0 && reminder > 0)
                {
                    sb.Append(reminder);
                }
            }
            if (second == "0")
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
            }
        }
    }
}
