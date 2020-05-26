using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class HWDay2
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("#1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("#2: ");

            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("#3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

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
        }

    }
}
