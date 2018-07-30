using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var baseN = int.Parse(input[0]);
            var baseTen = BigInteger.Parse(input[1]);
            var result = ConvertToBaseN(baseTen, baseN);
            Console.WriteLine(result);
        }

        static string ConvertToBaseN(BigInteger baseTen, int baseN)
        {
            var result = string.Empty;
            while (baseTen > 0)
            {
                var reminder = baseTen % baseN;
                result = reminder + result;
                baseTen /= baseN;
            }
            return result;
        }
    }
}
