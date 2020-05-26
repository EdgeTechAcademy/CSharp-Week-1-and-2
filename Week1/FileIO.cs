using System;
using System.IO;

namespace Week1
{
    class FileIO
    {
        static void Main(string[] args)
        {
            WriteFile();
            string fileName = Utils.GetInput("File Name: ");

            ReadFile(fileName);
        }       //  end of Main

        private static void WriteFile()
        {
            // Read the file and display it line by line. 
            string line;
            StreamWriter file = null;
            string rootFolder = "C:\\Projects\\reports\\";
            do
            {
                string fileName = Utils.GetInput("File Name: ");
                try
                {
                    file = new StreamWriter(rootFolder + fileName);
                    do
                    {
                        line = Console.ReadLine();
                        file.WriteLine(line);
                    } while (line.Length > 0);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured {0}\n Reenter file name", e.Message );
                }
                finally
                {
                    if (file != null)
                    {
                        file.Close();
                    }
                    Console.WriteLine("Here I am! You can't get away from me");
                }
            } while (true);
        }           /// end of my WriteFile

        private static void ReadFile(string fileName)
        {
            // Read the file and display it line by line. 
            string rootFolder = "C:\\Projects\\reports\\";
            try
            {
                StreamReader file = new StreamReader(rootFolder + fileName);

                while (true)
                {
                    string line = file.ReadLine();
                    if (line == null)
                        break;
                    Console.WriteLine(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The following exception occurred: " + e.Message);
            }
        }           /// end of my WriteFile
    }
}
