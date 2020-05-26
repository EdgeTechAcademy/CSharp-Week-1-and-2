using System;

namespace Practice_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1, num2, total;
            //1   Display the first 10 numbers
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //2   Read a number and find the sum of numbers from 0 to that number
            num = GetNumber("Enter Number: ");
            total = 0;
            for (int i = 0; i < num; i++)
            {
                total += i;
            }
            Console.WriteLine($"Total of the numbers from 0 to {num} is {total}");
            //4   Read 10 numbers from keyboard and find their sum and average
            total = 0;
            for (int i = 0; i < 10; i++)
            {
                num = GetNumber("Enter Number: ");
                total += num;
            }
            Console.WriteLine($"Total of the numbers is {total} and the average is {total/10}");
            //5   Display the cube of the number up to given an integer
            num = GetNumber("Enter Number: ");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"The cube of {num} is {num*num*num}");
            }
            //6   Display the multiplication table of a given integer
            //    0   1   2   3
            //0   0   0   0   0
            //1   0   1   2   3
            //2   0   2   4   6
            //3   0   3   6   9
            //8   Read a number and Display the odd numbers less than the number and their sum
            num = GetNumber("Enter Number: ");
            total = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 1)
                {
                    total += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum of the odd numbers < {num} is {total}");
            //9   Display the pattern like right angle triangle using an asterisk
            //*
            //**
            //***
            //****
            //10  Display the pattern like right angle triangle with a number
            //1
            //12
            //123
            //1234
            //11  Make a pattern like right angle triangle with a number which will repeat a number in a row
            //1
            //22
            //333
            //4444
            //12  Read a number and make a pattern like right angle triangle with number increased by 1
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //13  Read a number and make a pyramid with numbers increased by 1
            //   1
            //  2 3
            // 4 5 6
            //7 8 9 10
            //14  Read a number and make a pyramid with an asterisk
            //   *
            //  **
            // ***
            //****
            //15  Read a number and calculate the factorial of a given number
            //16  Read a number and Display the n terms of even number and their sum
            //17  Read a number a display a pattern like a pyramid with a number which will repeat the number in the same row
            //1
            //2 2
            //3 3 3
            //4 4 4 4
            //20  Display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks
            //*
            //***
            //*****
            //21  Read a number and Display the sum of the series[9 + 99 + 999 + 9999...]
            num = GetNumber("Enter Number: ");
            num1 = 0;
            total = 0;
            for (int i = 0; i < num; i++)
            {
                num1 = num1 * 10 + 9;
                total += num1;
            }
            Console.WriteLine($"Sum of the series [9,99,999,...] up to {num} 9s = {total}");
            //25  Display the n terms of square number and their sum
            //26  Read a number and find the sum of the series 1 + 11 + 111 + 1111 + ..n terms
            //31  Display the pattern like a diamond
            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *
            //32  Write a C# Sharp program to determine whether a given number is prime or not
            //33  Write a C# Sharp program to display by Pascal's triangle
            //1
            //11
            //121
            //1331
            //14641
            //34  Write a program in C# Sharp to find the prime numbers within a range of numbers
            //35  Display the first n terms of Fibonacci series
            //36  Display the such a pattern for n number of rows using a number which will start with the number 1 and the first and a last number of each row will be 1
            //1
            //121
            //12321
            //37  Display the number in reverse order
            //38  Write a program in C# Sharp to check whether a number is a palindrome or not
            //39  Write a program in C# Sharp to find the number and sum of all integer between 100 and 200 which are divisible by 9
            //40  Write a C# Sharp Program to display the following pattern using the alphabet
            //A
            //A B A
            //A B C B A
            //A B C D C B A
            //46  Convert a binary number into a decimal number using math function
            //50  Convert a decimal number into octal without using an array
            //51  Convert an octal number to decimal without using array
            //53  Convert a binary number to octal
            //54  Convert an octal number into binary
            //55  Convert a decimal number to hexadecimal. 
            //56  Write a program in C# Sharp to Check Whether a Number can be Express as Sum of Two Prime Numbers
            //57  Write a program in C# Sharp to print a string in reverse order
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static float GetFloat(string prompt)
        {
            float num;
            Console.Write(prompt);
            do
            {
                if (float.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }

        public static int GetNumber(string prompt)
        {
            int num;
            Console.Write(prompt);
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }

        public static int GetNumber(string prompt, int max)
        {
            int num;
            do
            {
                num = GetNumber(prompt);
                if (num > max)
                {
                    Console.WriteLine("Number too large");
                }
            } while (num > max);
            return num;
        }

    }
}
