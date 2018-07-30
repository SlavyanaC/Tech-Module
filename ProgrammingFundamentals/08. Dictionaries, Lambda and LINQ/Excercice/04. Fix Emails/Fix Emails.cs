using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailBook = new Dictionary<string, string>();
            bool continueRead = true;
            while (continueRead)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    foreach (var email in emailBook)
                    {
                        Console.WriteLine($"{email.Key} -> {email.Value}");
                    }
                    break;
                }
                else
                {
                    string emailAdress = Console.ReadLine();
                    if (!emailAdress.EndsWith(".us") && !emailAdress.EndsWith(".uk"))
                    {
                        emailBook.Add(name, emailAdress);
                    }
                }
            }
        }
    }
}