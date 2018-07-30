using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WormIpsum
{
    //20/100
    //100/100
    public static void Main()
    {
        string sentencePattern = @"^[A-Z][^\.]*\.$";
        string wordsPattern = @"[^\s,\.]+";
        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine == "Worm Ipsum")
                break;

            if (Regex.Match(inputLine,sentencePattern).Success)
            {
                MatchCollection wordsMatches = Regex.Matches(inputLine, wordsPattern);
                foreach (Match match in wordsMatches)
                {
                    var currentWord = match.Value;
                    if (currentWord.Length != currentWord.Distinct().Count())
                    {
                        var symbol = currentWord.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        var newWord = new string(symbol, currentWord.Length);
                        inputLine = Regex.Replace(inputLine, currentWord, newWord);
                    }
                }
                Console.WriteLine(inputLine);
            }
        }
    }
}