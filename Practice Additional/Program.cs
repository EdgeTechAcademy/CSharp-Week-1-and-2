using System;

namespace Practice_Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            bool divisibleBy4, divisibleBy100, divisibleBy400;

            do
            {
                Console.WriteLine("Enter a year (0 to stop) ");
                string str = Console.ReadLine();
                year = Int32.Parse(str);
                divisibleBy4 = year % 4 == 0;
                divisibleBy100 = year % 100 == 0;
                divisibleBy400 = year % 400 == 0;
                if ( divisibleBy400)
                {
                    Console.WriteLine($"{year} is a leap year");
                } else if (divisibleBy4 && !divisibleBy100 && !divisibleBy400)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            } while (year != 0);
        }
    }
}
