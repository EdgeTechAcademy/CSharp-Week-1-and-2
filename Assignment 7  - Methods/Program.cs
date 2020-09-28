using System;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // The user will enter
                // Y, M, or D to get the Year, Month or Day of the current date
                // h, m, or s to get the hour, minute, or second of the current time
                string part = Utils.GetInput("What part of the date are you interested in:\nY,M,D,h,m,s: ");

                // this method will take the part of the date requested and from the current date return the units for that date part or time part
                int timeUnit = GetDatePart(part);
                if (timeUnit == -1)
                    break;
                Console.WriteLine($"The time part represented by {part} is {timeUnit}");

            }
        }

        private static int GetDatePart(string dateTimePart)
        {
            int unit = -1;
            var now = DateTime.Now;
            switch (dateTimePart)
            {
                case "h": unit = now.Hour; break;
                case "m": unit = now.Minute; break;
                case "s": unit = now.Second; break;
                case "Y": unit = now.Year; break;
                case "M": unit = now.Month; break;
                case "D": unit = now.Day; break;
            }
            return unit;
        }
    }
}
