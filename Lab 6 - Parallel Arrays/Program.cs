using System;

namespace Lab_6___Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "817-555,1334", "817-555-3882", "972-555-8211", "469-555-1617", "817-555-2803" };
            string strSearch;

            strSearch = GetInput("Type a name to search for in the phone book: ");
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i].IndexOf(strSearch) >= 0)
                {
                    Console.WriteLine($"{Names[i]} = {Phone[i]}");
                }
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
