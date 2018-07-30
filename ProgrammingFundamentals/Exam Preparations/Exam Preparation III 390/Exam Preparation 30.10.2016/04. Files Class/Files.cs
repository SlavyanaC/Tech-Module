using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> allFiles = new List<string>();
            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            var filterTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var filterExt = "." + filterTokens[0];
            var filterRoot = filterTokens[2] + "\\";

            Dictionary<string, long> filesSize = new Dictionary<string, long>();
            foreach (var file in allFiles)
            {
                var fileAndSize = file.Split(';');
                var path = fileAndSize[0];
                var size = long.Parse(fileAndSize[1]);
                if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var pathTokens = path.Split('\\');
                    var fileName = pathTokens.Last();
                    filesSize[fileName] = size;
                }
            }
            if (filesSize.Count > 0)
            {
                foreach (var file in filesSize.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
            }
            else
                Console.WriteLine("No");
        }
    }
}
