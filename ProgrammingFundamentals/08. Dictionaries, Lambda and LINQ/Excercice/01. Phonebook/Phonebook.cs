using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            bool canContinue = true;
            while (canContinue)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "A":
                        AddNumber(phonebook, command);
                        break;
                    case "S":
                        SearchNumber(phonebook, command);
                        break;
                    case "END":
                        canContinue = false;
                        break;
                }
            }
        }

        static void SearchNumber(Dictionary<string, string> phonebook, string[] command)
        {
            if (phonebook.ContainsKey(command[1]))
            {
                Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
            }
            else
            {
                Console.WriteLine($"Contact {command[1]} does not exist.");
            }
        }

        static void AddNumber(Dictionary<string, string> phonebook, string[] command)
        {
            if (phonebook.ContainsKey(command[1]))
            {
                phonebook[command[1]] = command[2];
            }
            else
            {
                phonebook.Add(command[1], command[2]);
            }
        }
    }
}

