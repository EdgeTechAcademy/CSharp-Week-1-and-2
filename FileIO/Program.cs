using System;
using System.Data;
using System.IO;

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
                        ReadFile(fileName);
                        break;
                    case "write":
                        Console.WriteLine("File name to write: ");
                        fileName = Console.ReadLine();
                        WriteFile(fileName);
                        break;
                    case "exit":
                        return;
                }
            }
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

        static void ReadFile(string fileName)
        {
            //Instantiate a FileStream that will open a file named by the user 
            FileStream stream = new FileStream("C:/projects/csv/" + fileName, FileMode.Open,FileAccess.Read);
            StreamReader textFile = new StreamReader(stream);

            //  read loop
            string line;
            while ((line = textFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            textFile.Close();
        }       //end ReadFile()
    }
}