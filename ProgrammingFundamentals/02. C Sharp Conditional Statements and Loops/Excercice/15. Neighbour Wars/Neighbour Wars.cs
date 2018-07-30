using System;

namespace _15.Neighbour_Wars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int attackCounter = 0;

            bool areAlive = true;

            string attackName = string.Empty;
            string attacker = string.Empty;
            string defender = string.Empty;

            int defenderHealth = 0;

            while (areAlive)
            {
                attackCounter++;

                if (attackCounter % 2 == 0)
                {
                    peshosHealth -= goshosDamage;
                    attacker = "Gosho";
                    attackName = "Thunderous fist";
                    defender = "Pesho";
                    defenderHealth = peshosHealth;
                }

                else if (attackCounter % 2 == 1)
                {
                    goshosHealth -= peshosDamage;
                    attacker = "Pesho";
                    attackName = "Roundhouse kick";
                    defender = "Gosho";
                    defenderHealth = goshosHealth;
                }

                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    Console.WriteLine($"{attacker} won in {attackCounter}th round.");
                    areAlive = false;
                }

                else
                {
                    if (attackCounter % 3 == 0)
                    {
                        goshosHealth += 10;
                        peshosHealth += 10;
                    }
                    Console.WriteLine($"{attacker} used {attackName} and reduced {defender} to {defenderHealth} health.");
                }
            }
        }
    }
}