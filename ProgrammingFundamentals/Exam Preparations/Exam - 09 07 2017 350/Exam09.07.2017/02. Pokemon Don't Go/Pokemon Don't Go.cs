using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            long sum = 0;
            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < sequence.Count)
                {
                    var elementToDelete = sequence[index];
                    sequence.RemoveAt(index);
                    sum += elementToDelete;
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= elementToDelete)
                        {
                            sequence[i] += elementToDelete;
                        }
                        else
                        {
                            sequence[i] -= elementToDelete;
                        }
                    }
                }

                else
                {
                    if (index < 0)
                    {
                        long elementToDelete = sequence.First();
                        sequence.RemoveAt(0);
                        sequence.Insert(0, sequence.Last());
                        sum += elementToDelete;
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            if (sequence[i] <= elementToDelete)
                            {
                                sequence[i] += elementToDelete;
                            }
                            else
                            {
                                sequence[i] -= elementToDelete;
                            }
                        }
                    }
                    else if (index >= sequence.Count)
                    {
                        long elementToDelete = sequence.Last();
                        sequence.RemoveAt(sequence.Count - 1);
                        sequence.Add(sequence.First());
                        sum += elementToDelete;
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            if (sequence[i] <= elementToDelete)
                            {
                                sequence[i] += elementToDelete;
                            }
                            else
                            {
                                sequence[i] -= elementToDelete;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
