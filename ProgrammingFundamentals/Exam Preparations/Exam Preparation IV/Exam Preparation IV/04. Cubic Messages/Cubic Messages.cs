using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Over!")
                {
                    break;
                }
                var m = int.Parse(Console.ReadLine());

                var messagePattern = "(^[0-9]+)([a-zA-z]{" + m + "})([^a-zA-Z]*)$";
                if (Regex.Match(inputLine, messagePattern).Success)
                {
                    Match match = Regex.Match(inputLine, messagePattern);
                    var message = match.Groups[2].Value;
                    var digitsBefore = match.Groups[1].Value;
                    var digitsAfter = match.Groups[3].Value;

                    var digits = new List<int>();
                    StringBuilder decriptedMessage = new StringBuilder();
                    foreach (var digit in digitsBefore + digitsAfter)
                    {
                        if (char.IsDigit(digit))
                        {
                            int index = int.Parse(Convert.ToString(digit));

                            if (index < 0 || index >= message.Length)
                            {
                                decriptedMessage.Append(" ");
                            }
                            else
                            {
                                decriptedMessage.Append(message[index]);
                            }
                        }
                    }
                    Console.WriteLine($"{message} == {decriptedMessage.ToString()}");
                }
            }
        }
    }
}
