using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var nums = new int[num];

            for (int currentNum = 0; currentNum < num; currentNum++)
            {
                nums[currentNum] = int.Parse(Console.ReadLine());
            }
            for (int currentNum = nums.Length - 1; currentNum >= 0; currentNum--)
            {
                Console.Write(nums[currentNum]);
                Console.Write(" ");
            }
        }
    }
}
