using System;

namespace _2_6_11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int seconInput = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int firsNum = firstInput; firsNum <= seconInput; firsNum++)
            {
                for (int secNum = firstInput; secNum <= seconInput; secNum++)
                {
                    for (int thirdNum = firstInput; thirdNum <= seconInput; thirdNum++)
                    {
                        for (int fourthNum = firstInput; fourthNum <= seconInput; fourthNum++)
                        {
                            for (int fifthNum = firstInput; fifthNum <= seconInput; fifthNum++)
                            {
                                bool condition = ((firstInput <= firsNum) && 
                                                  (firsNum < secNum) && 
                                                  (secNum < thirdNum) && 
                                                  (thirdNum < fourthNum) && 
                                                  (fourthNum < fifthNum) && 
                                                  (fifthNum <= seconInput));

                                if (condition == true)
                                {
                                    Console.WriteLine($"{firsNum} {secNum} {thirdNum} {fourthNum} {fifthNum}");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}