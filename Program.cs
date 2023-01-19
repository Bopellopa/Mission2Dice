using System;

namespace Mission2Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcare some variables
            int rolls;
            int die;
            int die2;
            int dieTot;
            //start program and prompt user to enter num of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?:");
            rolls = Convert.ToInt32(Console.ReadLine());
            
            int[] dicecombo = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Random rand = new Random();
            for(int i = 0; i < rolls; i++)
            {
                die = rand.Next(1, 7);
                die2 = rand.Next(1, 7);
                dieTot = die + die2;

                dicecombo[dieTot - 2] = dicecombo[dieTot - 2] + 1;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n Each '*' represents 1 % of the total number of rolls. \n Total number of rolls = " + rolls);



        }
    }
}
