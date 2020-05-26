using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Decisions
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Utils.GetNumber("Enter a number 1: ");
            num2 = Utils.GetNumber("Enter a number 2: ");
            if (num1 > num2)        //  compare the two numbers...
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }
            else        //  num1 is not > num2 and num1 is not < num2 so num1 must be equal to num2
            {           //  at this point the only option left is that the two numbers are equal
                Console.WriteLine("{0} is equal to {1}", num2, num1);
            }

            string gender = Utils.GetInput("is the baby a 'B' or a 'G'? ");
            string msg = "Congrats its a ";
            msg += (gender.Equals("B", StringComparison.OrdinalIgnoreCase)) ? "boy" : "girl";

            int num = Utils.GetNumber("Enter a number ");

            Console.WriteLine("The number is " + (num % 2 == 0 ? "even" : "odd"));

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            Random rand = new Random();
            string strUserChoice;
            while(true)
            {
                strUserChoice = Utils.GetInput("Want anothe math problem? ");
                int ans;
                if (strUserChoice == "Y")
                {
                    num1 = rand.Next();
                    num2 = rand.Next();
                    ans = Utils.GetNumber("What is the sum of " + num1 + " + " + num2);
                }
                else
                {
                    break;
                }
                if (ans == num1 + num2)
                {
                    Console.WriteLine("Correct answer");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            }
        }
    }
}
