using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Week1
    {
        static void Main(string[] args)
        {
            int year;
            do
            {
                year = Utils.GetNumber("Enter Year: ");

                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))  //  if it is divisble by 400 it IS a leap year
                {
                    Console.WriteLine($"This year {year} is a leap year");
                }
                else            //  the year is NOT divisible by 4
                {
                    Console.WriteLine($"This year {year} is NOT a leap year");
                }
            } while (year != 0);


            while (true)
            {
                bool isVowel;
                string vowels = "aeiou";

                string str = Utils.GetInput("Enter one letter: ");
                isVowel = vowels.Contains(str);
                if (isVowel)
                {
                    Console.WriteLine("the letter entered " + str + " is a vowel");
                }
                else
                {
                    Console.WriteLine(str + " is not a vowel");
                }
                if (str.Length == 0)
                {
                    Console.WriteLine("thanks for playing our game");
                    break;
                }
            }
        }
    }
}
