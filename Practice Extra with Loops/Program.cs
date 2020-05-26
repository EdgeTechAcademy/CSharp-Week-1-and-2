using System;

namespace Practice_Extra_with_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Find the Max and Min of an Array:

            //Write a program, that will take a number from user input. (Use the Utils.java Utils.GetNumber code)
            //Create a loop to go from 0 to this number.
            //In the body of the loop ask the user for a number and add it to the array
            //While you are looping check to see if this is the largest number or the smallest number.
            //After the loop your code will output the largest and smallest numbers
            //Program is going to take user input - Number of numbers he is going to write
            //Program is going to validate user input and make sure it's a number
            //Program is going to loop and have the user write a number up to the (size / number of numbers)
            //Program is gonna find the max number and the minimum number in the array.
            //Program will output this to the user.

            // hint #1
            //int min;
            //int max;

            //hint #2 -- DO NOT DO THIS IN THE LOOP
            // min and your max is going to start as the first value in your array. So array[0]

            //hint#3
            //min means array[position] < min
            //max means array[position] > max

            Console.Write("Please enter how many numbers you want in your array: ");
            int input;

            // Validating the size of the array
            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.Write("Not a number. Please enter a number: ");
            }

            // Setting the size of the array through the number the user input
            int[] userArray = new int[input];

            // Creating the array through user input
            for (int count = 0; count < userArray.Length; count++)
            {
                Console.Write("Please enter the value for number " + (count + 1) + ": ");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.Write("Not a number. Please enter a number: ");
                }
                userArray[count] = input;
            }

            int min = userArray[0];
            int max = userArray[0];


            for (int count = 0; count < userArray.Length; count++)
            {
                if (userArray[count] < min)
                    min = userArray[count];

                if (userArray[count] > max)
                    max = userArray[count];
            }

            Console.WriteLine("Your minimum number is: " + min);
            Console.WriteLine("Your maximum number is: " + max);

            //2 - Reverse an array:

            //Write a program, that will take a number from user input.
            //Loop that number of times.
            //Ask for a number each time through the loop
            //Add this number to your array
            //After the loop print out the contents of your array in reverse order
            // Write a program, that takes a user input n times;
            // Store it in an array
            // Loop through it, and display the array backwards

            Console.Write("Please enter how many numbers you want in your array: ");

            // Validating the size of the array
            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.Write("Not a number. Please enter a number: ");
            }

            // Setting the size of the array through the number the user input
            userArray = new int[input];

            // Creating the array through user input
            for (int count = 0; count < userArray.Length; count++)
            {
                Console.Write("Please enter the value for number " + (count + 1) + ": ");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.Write("Not a number. Please enter a number: ");
                }
                userArray[count] = input;
            }

            Console.WriteLine("Your array backwards is: ");
            Console.WriteLine("-------------------------");

            for (int count = userArray.Length - 1; count >= 0; count--)
            {
                if (count != 0)
                    Console.Write(userArray[count] + " , ");
                else
                    Console.Write(userArray[count]);
            }

            Console.Read();
            //3 - Palindrome Validater:

            //A Palindrome is a word, phrase, or sequence that reads the same backward as forward, e.g., racecar or madam.

            //Ask the user for a string
            //The program will loop through each letter
            //The program will check if last position letter is the same as current position letter
            //If the loop finishes, then you have a palindrome
            //If a letter is different, then it is not a palindrome.

            // Takes user input -- DONE
            // Loops through each letter -- DONE
            // Checks if backwards position letter is the same as current position letter
            // if loop finishes, then you have a palindrome
            // if a letter is different, then it is not a palindrome. HINT: USE A BOOL!!!!!


            while (true)
            {
                Console.Write("Please enter a word: ");
                string word = Console.ReadLine().ToLower();
                bool isPalindrome = true;

                for (int count = 0; count < word.Length; count++)
                {
                    if (word[count] != word[word.Length - 1 - count])
                        isPalindrome = false;
                }

                if (isPalindrome == false)
                    Console.WriteLine("This word is not a palindrome.");
                else
                    Console.WriteLine("This word is a palindrome.");
                Console.ReadLine();
            }
        }
    }
}
