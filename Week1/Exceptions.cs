using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Week1
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            List<string> passengers = LoadRecords("titanic.csv");
            foreach (var person in passengers)
            {
                Console.WriteLine(person);
            }
        }
        public static List<string> LoadRecords(string fileName)
        {
            List<string> lines = new List<string>(); // list of all NBA players
            StreamReader textIn = null; // this is file read
            string line;
            try
            {
                fileName = "../../../Exceptions.cs"; // "C:/Projects/csv/" + fileName;
                textIn = new StreamReader(fileName);            // open the file for reading
                textIn.ReadLine(); // read and throw away the header line
                while ((line = textIn.ReadLine()) != null)      // read each line from the file
                {
                    lines.Add(line); // add player to the list of players
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Reading file: " + fileName);
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally       //  always executes. Gives us a chance to close the file 
            {
                if (textIn != null) textIn.Close();
            }
            return lines;
        }
    }
}
