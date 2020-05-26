using System;

namespace HW_Day_2___Conditional_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string str;

            //Write a program that asks for two integers. 
            Console.Write("Enter #1: ");
            str = Console.ReadLine();
            num1 = Int32.Parse(str);

            Console.Write("Enter #2: ");
            str = Console.ReadLine();
            num2 = Int32.Parse(str);

            //Compare the two numbers, display the larger number
            //Use if statements do NOT use the Math.Max methods
            if ( num1 > num2 )
            {
                Console.WriteLine($"num1 {num1} is bigger than num2 {num2}");
            } else if ( num2 > num1)
            {
                Console.WriteLine($"num2 {num2} is bigger than num1 {num1}");
            } else
            {
                Console.WriteLine($"num1 {num1} must be equal num2 {num2}");
            }
            //Write a program that asks for three integers

            Console.Write("Enter #3: ");
            str = Console.ReadLine();
            num3 = Int32.Parse(str);
            //Compare them and display the largest number and the smallest number
            //Use if statements do NOT use the Math.Max methods
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"num1 {num1} is the biggest number");
            } else if ( num2 > num3) {
                Console.WriteLine($"num1 {num2} is the biggest number");
            } else
            {
                Console.WriteLine($"num1 {num3} is the biggest number");
            }
        }
    }
}
