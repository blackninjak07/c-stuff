using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace dice_game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int player1;
            int ai;

            int playerScore = 0;
            int aiScore = 0;

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("press any key to roll the dice");
                Console.ReadKey();

                player1 = rnd.Next(1, 6);
                Console.WriteLine("you rolled a " + player1);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);

                ai = rnd.Next(1, 6);
                Console.WriteLine("your oppenent rolled a " + ai);

                if (player1 > ai)
                {
                    playerScore++;
                    Console.WriteLine("player1 wins this round");
                }
                else if (player1 < ai)
                {
                    aiScore++;
                    Console.WriteLine("ai wins this round");
                }
                else
                {
                    Console.WriteLine("tie");
                }

                Console.WriteLine("The score is - player1: " +playerScore + " ai: " +aiScore + ""); 
                Console.WriteLine();
            }

            if (playerScore > aiScore)
            {
                Console.WriteLine("player1 won");   
            }
            else if (playerScore < aiScore)
            {
                Console.WriteLine("ai won");
            }
            else
            {
                    Console.WriteLine("tie");
            }
        }
    }
}