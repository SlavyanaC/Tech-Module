using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Anonymous_Vox
{
    //100/100
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder result = new StringBuilder(input);
            Regex regex = new Regex(@"([A-Za-z]+)(.+)(\1)");
            MatchCollection matches = regex.Matches(result.ToString());
            var placeholders = Console.ReadLine().Split(new string[] { "{", "}{", "}" }, StringSplitOptions.RemoveEmptyEntries);
            int indexPlaceholder = 0;
            foreach (Match match in matches)
            {
                var start = match.Groups[1].Value;
                var placeholder = match.Groups[2].Value;
                var end = match.Groups[3].Value;
                var indexPlaceH = input.IndexOf(placeholder);
                result.Remove(indexPlaceH, (placeholder.Length));
                result.Insert(indexPlaceH, placeholders[indexPlaceholder].ToString());
                input = result.ToString();
                indexPlaceholder++;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
