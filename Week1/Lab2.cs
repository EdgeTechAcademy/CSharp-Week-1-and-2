using System;

namespace Week1
{
    class Program
    {
        /*
            Project:    Lab 2 Calculate Batting Average
            Date:        to/da/y
            Author:     You the big new programmer
            Notes:      This program reads in a baseball player's name,
                        number of hits and number of at bats.
                        The player's batting average is calculated and displayed
        */
        static void Main(string[] args)
        {
            // Variable declaration
            string strPlayerName;
            double nHits, nAtBats; // later we will see the need to change this to dboule dblHits, dblAtBats
            double dblBattingAverage;

            Console.WriteLine("This program calculates a baseball player's batter average");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter player's name: ");
            strPlayerName = Console.ReadLine();                 //  or we could use the Utils class strPlayerName = Utils.GetInput("Enter player's name");

            //  prompt for hits and at bats
           nHits = Utils.GetNumber("Enter the player's # of hits: ");       //  or we could use the Utils class Hits = Utils.GetNumber("Enter the player's # of hits: ");

            Console.Write("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine()); // or we could use the Utils class Hits = Utils.GetNumber("Enter the player's # of at bats: ");

            // calculation
            dblBattingAverage = nHits / nAtBats;

            Console.WriteLine($"{strPlayerName}'s batting averate is {dblBattingAverage}");
        }
    }
}
