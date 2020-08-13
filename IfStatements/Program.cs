using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace IfStatements
{
    class Program
    {
        static void Main()
        {
            //int playerHealth = 130;
            //int monsterDamage = 110;
            //playerHealth -= monsterDamage;

            //if (playerHealth < 0)
            //{
            //  playerHealth = 0;
            //}

            //Console.WriteLine("A monster attacked you and did " + monsterDamage + " damage.You have " + playerHealth + " health left.");

            //if (playerHealth <= 0)
            //{
            //Console.WriteLine("You you were. Game over.");
            //}
            //else if (monsterDamage > 100)
            //{
            //Console.WriteLine("The monster is terrifyingly strong.");
            //}
            //else if (playerHealth > 0)
            //{
            //Console.WriteLine("The monster prepares to attack you again!");
            //}

            //Console.ReadKey();
            int score = 0;
            int combo = 1;
            int pointValue = 100;
            bool gameStarted = false;
            if (score == 0)
            {
                gameStarted = true;
                if (gameStarted)
                {
                    score = combo * pointValue;
                    combo++;
                    Console.WriteLine("You got a combo! Your new score is: " + score);
                    Console.ReadKey();
                }
            }
        }

    }
    
}
