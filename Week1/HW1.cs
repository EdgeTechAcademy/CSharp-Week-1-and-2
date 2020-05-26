using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class HW1
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double sum, diff, quot, prod;
            Console.Write("Give me #1 ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Give me #2 ");
            num2 = Convert.ToDouble(Console.ReadLine());

            sum  = num1 + num2;
            prod = num1 * num2;
            diff = num1 - num2;
            quot = (double)num1 / (double)num2;
            Console.WriteLine("sum " + sum);
            Console.WriteLine("prod " + prod);
            Console.WriteLine("diff " + diff);
            Console.WriteLine("quot " + quot);
            Console.WriteLine("mod " + num1 % num2);
            if (num1 > num2)
            {
                Console.WriteLine("num1 is bigger");
                Console.WriteLine("num2 must be smaller");
            }
        }
    }
}
