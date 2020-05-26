using System;

namespace HW_2___Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string str;

            Console.WriteLine("Enter #1 ");
            str = Console.ReadLine();
            num1 = Int32.Parse(str);

            Console.WriteLine("Enter #2 ");
            str = Console.ReadLine();
            num2 = Int32.Parse(str);

            int gcd = GCD(num1, num2);
            Console.WriteLine($"The GCD pf {num1} and {num2} is {gcd}");
        }
        static int GCD(int num1, int num2)
        {
            int remainder;
            int larger = Math.Max(num1, num2);
            int smaller = Math.Min(num1, num2);
            while (true)
            {
                //Step 1:  Divide the larger by the smaller and save the remainder
                remainder = larger % smaller;
                //Step 2: If the remainder is 0, the smaller number is the gcd, 
                //          return it and you are done!
                if (remainder == 0)
                    return smaller;
                //Step 3:   Else assign the larger number the value of the smaller
                //          and assign the smaller the value of the remainder,
                larger = smaller;
                smaller = remainder;
                //Step 4:  Continue to Step 1.
            }
        }
    }
}
