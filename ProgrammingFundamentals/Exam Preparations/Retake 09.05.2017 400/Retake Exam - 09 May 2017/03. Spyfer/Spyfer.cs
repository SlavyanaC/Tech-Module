using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Spyfer
{
    //90/100
    class Spyfer
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < sequence.Count; i++)
            {
                for (int j = 0; j < sequence.Count - 1; j++)
                {
                    if (j == 0)
                    {
                        if (sequence[j] == sequence[j + 1])
                        {
                            sequence.RemoveAt(j + 1);
                            i = 0;
                            break; ;
                        }
                    }
                    else
                    {
                        if (sequence[j] == sequence[j - 1] + sequence[j + 1])
                        {
                            sequence.RemoveAt(j + 1);
                            sequence.RemoveAt(j - 1);
                            i = 0;
                            break;
                        }
                        else if (j == sequence.Count - 2)
                        {
                            if (sequence[j] == sequence[j + 1])
                            {
                                sequence.RemoveAt(j + 1);
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}