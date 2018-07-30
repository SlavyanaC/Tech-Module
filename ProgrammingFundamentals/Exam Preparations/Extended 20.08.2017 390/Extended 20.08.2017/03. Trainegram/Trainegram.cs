using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Trainegram
{
    //100/100
    public static void Main()
    {
        string pattern = @"^(<\[[^a-zA-Z0-9]*\]\.){1}(\.\[[a-zA-Z0-9]*\]\.)*$";
        List<string> matches = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Traincode!")
            {
                break;
            }
            var match = Regex.Match(input, pattern);
            if (Regex.Match(input, pattern).Success)
            {
                matches.Add(match.ToString());
            }
        }
        Console.WriteLine(string.Join("\r\n", matches));
      
    }
}
