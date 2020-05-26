using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Lab3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
        public static void triangleQuestion()
        { 
            //Problem13();
            int side1, side2, side3;
            side1 = Utils.GetNumber("Side 1 ");
            side2 = Utils.GetNumber("Side 2 ");
            side3 = Utils.GetNumber("Side 3 ");

            if ( side1 == side2 && side1 == side3 )
                Console.WriteLine("Triangle IS Equilateral");

            if ( side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("Triangle IS Isosceles");

            if (side1 != side2 && side2 != side3 && side1 != side3)
                Console.WriteLine("Triangle IS Scalene");
            //  determine if each side is different


        }

        public static void Problem13()
        {
            //  Write a C# Sharp program to read temperature in centigrade 
            //  and display a suitable message according to temperature state below : 
            int temp = Utils.GetNumber("Enter today's temperature: ");
            if (temp < 0)               //  Temp< 0 then Freezing weather
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp < 10)         //  Temp 0 - 10 then Very Cold weather
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp < 20)         //  Temp 10 - 20 then Cold weather
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp < 30)        //  Temp 20 - 30 then Normal in Temp
            {
                Console.WriteLine("normal");
            }
            else if (temp < 40)         //  Temp 30 - 40 then Its Hot
            {
                Console.WriteLine("hot");
            }
            else                        //  Temp >= 40 then Its Very Hot
            {
                Console.WriteLine("Very hot");
            }
        }
        public static void OldCode()
        {
            int num1 = Utils.GetNumber("Enter #1 ");
            int num2 = Utils.GetNumber("Enter #2 ");
            int num3 = Utils.GetNumber("Enter #3 ");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the largest number");
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + " is the largest number");
            }
            else
            {
                Console.WriteLine(num3 + " is the largest number");
            }

            int max = Math.Max(Math.Max(num1, num2), num3);
            //      ??? i do know which varible is the biggest

        }
    }
}
