using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            ulong phoenixesCount = ulong.Parse(Console.ReadLine());
            for (ulong i = 0; i < phoenixesCount; i++)
            {
                ulong bodyLenght = ulong.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                ulong wingLenght = ulong.Parse(Console.ReadLine());
                decimal totalYears = (bodyLenght * bodyLenght) * (bodyWidth + 2m * wingLenght);
                Console.WriteLine(totalYears);
            }
        }
    }
}
