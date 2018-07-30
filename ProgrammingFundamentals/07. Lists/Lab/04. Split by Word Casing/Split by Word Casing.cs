using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (string word in text)
            {
                bool isAllLower = true;
                bool isAllUpper = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpper = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLower = false;
                    }
                    else
                    {
                        isAllLower = false;
                        isAllUpper = false;
                    }
                }

                if (isAllUpper)
                {
                    upperCase.Add(word);
                }
                else if (isAllLower)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}

