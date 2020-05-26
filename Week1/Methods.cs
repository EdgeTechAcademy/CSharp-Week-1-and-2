using System;

namespace Week1
{
    class Methods
    {
        static void Main(string[] args)
        {
            DateTime thisDate = DateTime.Now;
            string day = GetDayOfWeek(thisDate);
            Console.WriteLine("{0} is a {1}", thisDate.ToString(), day);

            float days = Utils.GetFloat("# of days in future: ");
            DateTime future = AddDays(days);
            Console.WriteLine(future);
        }

        static DateTime AddDays(float number)
        {
            DateTime newTime = DateTime.Now;
            newTime = newTime.AddDays(number);
            return newTime;
        }

        static string GetDayOfWeek(DateTime dateTime)
        {
            string dayOfTheWeek;
            dayOfTheWeek = dateTime.DayOfWeek.ToString();
            return dayOfTheWeek;
        }

        static string WelcomeMessage (string course, string name)
        {
            string msg;
            msg = "Welcome "+ name+" to "+course+" at Edge Tech Academy";
            return msg;
        }
    }
}