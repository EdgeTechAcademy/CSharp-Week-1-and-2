using System;
using System.Linq;

namespace Lab___LINQ_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given this list of numbers, do the following problems and print the result for each.
            int[] smallNumbers = { 5,3,3,6,3,4,6,3,5,7,8,5 };
            int smallest, largest, count, last, total;
            bool anyBiggerThan7;

            //(3 pts) What is the smallest number ?
            smallest = smallNumbers.Min();
            //(3 pts) What is the largest number ?
            largest = smallNumbers.Max();
            //(3 pts) Count the numbers
            count = smallNumbers.Count();
            //(3 pts) What is the last number in the list?
            last = smallNumbers.Last();
            //(3 pts) Skip the first 5 numbers, take the next 5 numbers
            var middle5 = smallNumbers.Skip(5).Take(5);
            //(3 pts) Are any numbers bigger than 7 ?
            anyBiggerThan7 = smallNumbers.Any(num => num > 7);
            //(3 pts) Create a list of the numbers greater than or equal to 7
            var biggerThan7 = smallNumbers.Where(num => num >= 7);
            //(3 pts) What is the sum of all the numbers in the list?
            var takeAfter4 = smallNumbers.SkipWhile(n => n != 4);
            //(3 pts) Do this with Sum and do it with Aggregate
            total = smallNumbers.Aggregate((total, num) => total += num);
            //(3 pts) Create a list of the unique elements of the list
            var distinct = smallNumbers.Distinct();
        }
    }
}
