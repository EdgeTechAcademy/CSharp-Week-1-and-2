using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Week1
{
    class Junk
    {
        static void Main(string[] args)
        {
            string fileName = Utils.GetInput("Create File: ");
            WriteFile(fileName);

        }

        private static void WriteFile(string fileName)
        {
            // Read the file and display it line by line. 
            StreamWriter file = new StreamWriter(@"../../../" + fileName);

            while (true)
            {
                string line = Console.ReadLine();
                if (line.Length == 0)
                    break;
                file.WriteLine(line);
            }
            file.Close();
        }
        public static void MethodTest() { 
            string str = Utils.GetInput("Enter a line of text: ");
            int wordNumber = Utils.GetNumber("What word to you want? ");
            string word = GetWord(str, wordNumber);
            Console.WriteLine($"Word number {wordNumber} is the word: '{word}'");
        }

        private static string GetWord(string inputStr, int number)
        {
            string word;

            string[] words = inputStr.Split(" ");

            // word = (words.Length > number) ? words[number] : "not found";
            if ( words.Length > number )
            {
                word = words[number];
            }
            else
            {
                word = "word not found";
            }
            return word;
        }



        private static void LINQ1() 
        { 
            //  let's play with arrays of numbers using the LINQ statements
            double total;
            double biggest, average;
            double[] numbers = { 12, 3, 2, 743, 6, 2, 302, 2242, 2, 5, 3312, 3, 621, 2, 5, 4 };

            //  get the average number of all elements in the array
            //  do you want to do it like this
            total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            average = total / numbers.Length;

            //  or would you rather be very clever and do it with one line of code?
            average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            //  Get the largest number in the array
            biggest = numbers.Max();
            Console.WriteLine($"The largest # is: {biggest}");

            var rev = numbers.Reverse();
            var count = numbers.Count();
            var distinct = numbers.Distinct();

            //  Get all numbers WHERE they are even numbers
            IEnumerable<double> evens = numbers.Where(num => num % 2 == 0);

            //  Multiply all numbers together in our list
            total = numbers.Aggregate((num, tot) => tot *= num);
            Console.WriteLine($"the product of all numbers is {total}");

            //  Get the total of all of our numbers from our list
            total = numbers.Aggregate((num, tot) => tot += num * 0.5);
            Console.WriteLine($"The bonus pool this year is: {total}");

            //  getting the sum of an array
            total = numbers.Sum();
            Console.WriteLine($"the sum of all numbers is {total}");

            //  print the array
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

            while (true)
            {
                //  ask for a limit number
                double limit = Utils.GetFloat("Enter a number: ");
                if (limit == -1)
                    break;

                //  are all numbers in the list above the limit
                bool above = numbers.All(num => num > limit);
                Console.WriteLine("Are all of the numbers > " + limit + "? " + above);

                //  is there at least ONE number above the limit
                above = numbers.Any(num => num > limit);
                Console.WriteLine("Is ANY # > " + limit + "? " + above);
            }

            // Let's find all numbers greater 80 that are odd
            var bigOdd = from n in numbers
                         where n > 80
                         where (int)n % 2 == 1
                         select n;

            foreach (var odd in bigOdd)
            {
                Console.WriteLine(odd);
            }

            //  get the average number of all elements in the array
            //  do you want to do it like this
            total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            average = total / numbers.Length;

            //  or would you rather be very clever and do it with one line of code?
            average = numbers.Average();

            ///////////////////////////////////////////////////////////////////////////////////////
            LINQ_Exercises();
        }

        private static void LINQ_Exercises ()
        {
            //  Given this list of numbers, do the following problems and print the result for each.
            int[] smallNumbers = { 5, 3, 3, 6, 3, 4, 6, 3, 5, 7, 8, 5 };

            //(3 pts) What is the smallest number ?
            var small = smallNumbers.Min();
            Console.WriteLine($"Smallest number is {small}");

            //(3 pts) What is the largest number ?
            var big = smallNumbers.Max();
            Console.WriteLine($"Biggest number is {big}");

            //(3 pts) Count the numbers
            var count = smallNumbers.Count();
            Console.WriteLine($"The array has {count} numbers in it");

            //(3 pts) What is the last number in the list
            var last = smallNumbers.Last();
            Console.WriteLine($"The last number in the list is: {last}");

            //(3 pts) Are any numbers bigger than 7 ?
            var biggerThan7 = smallNumbers.Any(num => num > 7);
            Console.WriteLine($"Are there any numbers > 7 {biggerThan7}");

            //(3 pts) Create a list of the numbers greater than or equal to 7
            var list7 = smallNumbers.Where(num => num > 7);
            Console.WriteLine("Numbers bigger than 7 using the LINQ methods");
            PrintList(list7);

            Console.WriteLine("Numbers bigger than 7 using the Query language");
            list7 = from num in smallNumbers
                    where num > 7
                    select num;
            PrintList(list7);

            //(3 pts) Skip the first 5 numbers, take the next 5 numbers 
            var second5 = smallNumbers.Skip(5).Take(5);
            Console.WriteLine("The second group of 5 numbers");
            PrintList(second5);

            //(3 pts) What is the sum of all the numbers in the list?
            var sum = smallNumbers.Sum();
            Console.WriteLine($"Sum total of the array = {sum}");

            //(3 pts) Do this with Sum and do it with Aggregate
            sum = smallNumbers.Aggregate((num, tot) => tot += num);
            Console.WriteLine($"Sum total of the array = {sum}");

            //(3 pts) Create a list of the unique elements of the list
            var unique = smallNumbers.Distinct();
            Console.WriteLine("Unique numbers in the list");
            PrintList(unique);

            var sorted = from num in smallNumbers
                         orderby num
                         select num;
            Console.WriteLine("Sorted list of numbers");
            PrintList(sorted);
        }

        private static void PrintList(IEnumerable<int> list)
        {
            foreach(var x in list)
            {
                Console.Write(x + ", ");
            }
        }

        private static void InterviewQ1()
        {
            //  "This is a list of BIGwords"
            //      **********
            //      *This    *
            //      *is      *
            //      *a       *
            //      *list    *
            //      *of      *
            //      *BIGwords*
            //      **********
            string phrase = Utils.GetInput("Enter a sentence: ");
            string[] words = phrase.Split(" ");
            int bigWordLength = words[0].Length;
            //  find length of longest word
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > bigWordLength)
                {
                    bigWordLength = words[i].Length;
                }
            }
            //  print the first row of the box
            for (int i = 0; i < bigWordLength + 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            foreach (var word in words)
            {
                Console.Write("*");
                Console.Write(word.PadRight(bigWordLength, '.'));
                Console.WriteLine("*");
            }
            //  print the first row of the box
            for (int i = 0; i < bigWordLength + 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        private static void FunWithStrings()
        {
            string name = "Edge Tech Academy";
            Console.WriteLine("My name is '" + name + "' and it is " + name.Length + " characters long");

            bool hasTech = name.Contains("Tech");
            Console.WriteLine("Does my name contain Tech? " + (hasTech ? "Why yes is does!" : "No Tech :-("));

            bool isBoring = name.Contains("boring stuff");
            Console.WriteLine("Does my name contain 'boring stuff'? " + (isBoring ? "Not So!" : "All exciting stuff"));

            bool ending = name.EndsWith("h Academy");
            Console.WriteLine("Does my name end with 'h Academy'? " + (ending ? "yup" : "nope"));

            bool starting = name.StartsWith("Edge");
            Console.WriteLine("Does my name start with 'Edge'? " + (starting ? "yup" : "nope"));

            bool doTheyMatch = name.Equals("EDGE tech ACADemy");
            Console.WriteLine("Are they equal? " + (doTheyMatch ? "yup" : "nope"));

            bool ignoreCase = name.Equals("EDGE tech ACADemy", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Can I compare and ignore case? " + (ignoreCase ? "yup" : "nope"));
            int eIndex = name.IndexOf("e");
            while (eIndex >= 0)
            {
                Console.WriteLine("Found 'e' at: " + eIndex);
                eIndex = name.IndexOf("e", eIndex + 1);
            }
            string newString = name.Insert(8, ">HELLO!<");
            Console.WriteLine(newString);

            int dIndex = name.LastIndexOf('d');
            Console.WriteLine("Found last 'd' at: " + dIndex);

            string[] aNames = name.Split(" ");
            foreach (string str in aNames)
            {
                string padLeft = str.PadLeft(15, '.');
                string padRight = str.PadRight(15, '_');
                Console.WriteLine("Pad Left ->" + padLeft);
                Console.WriteLine("Pad Right ->" + padRight);

                Console.WriteLine("Unpad " + padLeft.Trim('.'));
                Console.WriteLine("Unpad " + padRight.Trim('_'));
            }

            string nickName = name.Remove(4);
            Console.WriteLine(nickName);

            Console.WriteLine("Chop characters out of the middle: " + name.Substring(7, 8));

            Console.WriteLine("Look Ma! No 'e's! " + name.Replace('e', '_'));

            Console.WriteLine("UPPER CASE: " + name.ToUpper());
            Console.WriteLine("lower case: " + name.ToLower());
        }
    }
}
