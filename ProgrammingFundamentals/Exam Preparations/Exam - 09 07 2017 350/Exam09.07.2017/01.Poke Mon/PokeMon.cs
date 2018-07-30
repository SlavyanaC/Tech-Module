using System;

namespace _01.Poke_Mon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            var initialPower = ulong.Parse(Console.ReadLine());
            var distBetwTargs = ulong.Parse(Console.ReadLine());
            var exhaustionFactor = ulong.Parse(Console.ReadLine());

            ulong count = 0;
            ulong currentPower = initialPower;
            while (currentPower >= distBetwTargs)
            {
                currentPower -= distBetwTargs;
                if (currentPower == (decimal)(initialPower / 2m) && exhaustionFactor != 0)
                {
                    currentPower /= exhaustionFactor;
                }

                count++;
            }
            Console.WriteLine(currentPower);
            Console.WriteLine(count);
        }
    }
}
