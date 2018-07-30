using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Spy_Gram
{
    //30/100
    //100/100
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^TO:\s[A-Z]+;\sMESSAGE:\s.+;$";
            string privateKey = Console.ReadLine();

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                if (Regex.Match(inputLine, pattern).Success)
                {

                    var inputTokens = inputLine.Split(new string[] { ": ", "; " }, StringSplitOptions.RemoveEmptyEntries);
                    var sender = inputTokens[1];

                    var messageToEncrypt = inputLine.ToCharArray();
                    StringBuilder encryptedMessage = new StringBuilder();
                    if (inputLine.Length <= privateKey.Length)
                    {
                        for (int i = 0; i < messageToEncrypt.Length; i++)
                        {
                            encryptedMessage.Append((char)(messageToEncrypt[i] + (privateKey[i] - 48)));
                        }
                    }
                    else
                    {
                        StringBuilder newKey = new StringBuilder();
                        decimal multiplyKey = Math.Ceiling((decimal)inputLine.Length / (decimal)privateKey.Length);
                        for (int i = 0; i < multiplyKey; i++)
                        {
                            newKey.Append(privateKey);
                        }
                        for (int i = 0; i < Math.Min(newKey.Length, inputLine.Length); i++)
                        {

                            encryptedMessage.Append((char)(messageToEncrypt[i] + (newKey[i] - 48)));

                        }
                    }
                    if (!result.ContainsKey(sender))
                    {
                        result.Add(sender, new List<string>());
                    }
                    result[sender].Add(encryptedMessage.ToString());
                }
            }
            foreach (var sender in result.OrderBy(m => m.Key))
            {
                foreach (var message in sender.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
