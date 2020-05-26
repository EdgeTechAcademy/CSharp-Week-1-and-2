using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Problem_I
    {
        static void Main(string[] args)
        {
            int num = Utils.GetNumber("Enter a # to convert to Hex: "); ;
            Console.WriteLine("{0} = {0:X}", num);
            //  InterviewProblem_I();
        }
        //---------------------------------------------------
        private static void InterviewProblem_I()
        {
            //  "This is a list of BIGwords"
            //      **********
            //      *This    *
            //      *is      *
            //      *a       *
            //      *list    *
            //      *of      *
            //      *BIGwords*
            //      **********

            string phrase = Utils.GetInput("Enter a sentence: ");    // ask user for a phrase
            string[] words = phrase.Split(" ");                      // split into an array of words
            int bigWordLength = words[0].Length;                     // find the longest word in the array
            //  find length of longest word
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > bigWordLength)
                {
                    bigWordLength = words[i].Length;
                }
            }
            //  print the first row of the box
            for (int i = 0; i < bigWordLength + 4; i++)             //  we have to add 2 to include the border of the box
            {
                Console.Write("*");
            }
            Console.WriteLine();
            foreach (var word in words)                           //    loop through each word and pad to fit the size of our box
            {
                Console.Write("* ");
                Console.Write(word.PadRight(bigWordLength, '.'));
                Console.WriteLine(" *");
            }
            //  print the first row of the box
            for (int i = 0; i < bigWordLength + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
