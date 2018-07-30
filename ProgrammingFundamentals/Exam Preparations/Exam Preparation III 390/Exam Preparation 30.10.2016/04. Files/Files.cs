using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, double>> fileName = new Dictionary<string, Dictionary<string, double>>();

            for (int i = 0; i < n; i++)
            {
                var file = Console.ReadLine().Split(new char[] { ';' });

                var path = file[0].Split('\\').ToArray();
                var folder = path[0];
                var name = path.Last();
                var size = double.Parse(file[1]);

                fileName.Add(name, new Dictionary<string, double>());
                fileName[name].Add(folder, size);
            }


            var search = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var searchExtension = search[0];
            var searchFolder = search[2];
            foreach (var file in fileName)
            {
                if (file.Key.ToString().EndsWith(searchExtension) && file.Value.Keys.ToString() == searchFolder)
                {
                    Console.WriteLine(file.Key + " " + file.Value);
                }
            }

        }
    }
}
