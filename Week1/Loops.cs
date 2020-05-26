using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Loops
    {
        static void Main(string[] args)
        {
            // get some max number to count ip to
            int maxCount = Utils.GetNumber("Enter a big number: ");

            // loop from o up to maxCount
            for (int i = 0; i < maxCount; i++)
            {
                if (i % 7 == 0 ||      //  remove divisible by  7
                    i % 10 == 7 ||      //  remove ends   with a 7
                    i / 10 == 7)        //  remove starts with a 7
                {
                    // print out the numbers without 7 as we go
                    Console.WriteLine($"The counter is: {i}");
                }
            }           //  end of for loop

            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = {"817-555,1334", "817-555-3882", "972-555-8211", "469-555-1617", "817-555-2803" };
            string strSearch;

            strSearch = Utils.GetInput("Type a name to search for in the phone book: ");
            for (int i = 0; i < Names.Length; i++)
            {
                if ( Names[i].IndexOf(strSearch) >= 0)
                {
                    Console.WriteLine($"{Names[i]} = {Phone[i]}");
                }
            }
        }
    }
}
