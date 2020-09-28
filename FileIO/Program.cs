using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName, command;

            while (true)
            {
                Console.WriteLine("Read, Write, exit");
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "read":
                        Console.WriteLine("File name to read: ");
                        fileName = Console.ReadLine();
                        var lines = ReadFile(fileName);
                        lines.ForEach(l => Console.WriteLine(l));
                        break;
                    case "write":
                        Console.WriteLine("File name to write: ");
                        fileName = Console.ReadLine();
                        WriteFile(fileName);
                        break;
                    case "volcano":
                        var volcanoes = ReadFile("volcano.csv");
                        List<Volcano> lVolcanoes = new List<Volcano>();
                        foreach (var vText in volcanoes)
                        {
                            string[] attrib = vText.Split(",");
                            Volcano v = new Volcano(attrib[0], StrToInt(attrib[1]), StrToInt(attrib[2]), attrib[3], attrib[4], attrib[5], StrToInt(attrib[6]), StrToInt(attrib[7]));
                            lVolcanoes.Add(v);
                        }
                        var v1985 = lVolcanoes.Where(v => v.Year > 1985);
                        int deaths = v1985.Sum(v => v.Death);
                        v1985.ToList().ForEach(v => Console.WriteLine(v));
                        Console.WriteLine($"Deaths since 1985: {deaths}");
                        break;
                    case "exit":
                        return;
                }
            }
        }
        static int StrToInt(string strNum)
        {
            int number;
            bool isParsable = Int32.TryParse(strNum, out number);
            return isParsable ? number : 0;
        }
        static void WriteFile(string fileName)
        {
            //Instantiate a FileStream that will open a file named by the user 
            FileStream stream = new FileStream("C:/projects/csv/" + fileName, FileMode.Append, FileAccess.Write );
            StreamWriter textFile = new StreamWriter(stream);

            string userInput = Utils.GetInput("Enter Text:");

            //input loop
            while (userInput.Length != 0)
            {
                textFile.WriteLine(userInput);
                userInput = Console.ReadLine();
            }
            textFile.Close();
        }       //end WriteFile()

        static List<string> ReadFile(string fileName)
        {
            List<string> lines = new List<string>();

            //Instantiate a FileStream that will open a file named by the user 
            FileStream stream = new FileStream("C:/projects/csv/" + fileName, FileMode.Open,FileAccess.Read);
            StreamReader textFile = new StreamReader(stream);

            //  read loop
            string line;
            while ((line = textFile.ReadLine()) != null)
            {
                lines.Add(line);
            }
            textFile.Close();
            return lines;
        }       //end ReadFile()
    }
}