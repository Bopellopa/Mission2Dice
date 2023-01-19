using System;

namespace Mission2Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rolls;
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?:");
            rolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n Each '*' represents 1 % of the total number of rolls. \n Total number of rolls = " + rolls);
            int[] dicecombo;
        }
    }
}
