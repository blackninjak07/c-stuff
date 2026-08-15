using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] dice = new[] { 1, 2, 3, 4, 5, 6 };
            int[] dice1 = new[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(dice[rnd.Next(0, dice.Length)]);
            Console.WriteLine(dice1[rnd.Next(0, dice.Length)]);
        }
    }
}