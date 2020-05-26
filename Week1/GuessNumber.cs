using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class GuessNumber
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                int secret = RandomNumber(1, 100);

                do
                {
                    int guess = Utils.GetNumber("Enter number between 1 and 100: ", 1024);
                    int highOrLow = PlayGame(secret, guess);
                    if (highOrLow == 0)     //  you guessed correctly
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too " + (highOrLow == 1 ? "High" : "Low"));
                    }
                } while (true);
                response = Utils.GetInput("Want a new game? ");
            } while (! response.Equals("N"));
        }

        static int PlayGame(int secret, int guess)
        {
            //  using the terenary operator to 
            //          if == return 0 and
            //                                   -1 if < and 1 if >
            return (secret == guess) ? 0 : (guess < secret) ? -1 : 1;
        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
