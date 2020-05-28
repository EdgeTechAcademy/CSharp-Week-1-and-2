using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Week1
{
    class LinqExamples
    {
        static void Main(string[] args)
        {
            int[] scores = { 3, 3, 32, 5, 2, 2, 5, 24737, 23445, 234, 435, 562, 12, 5876, 69, 096, 567, 567, 768, 58, 4 };
            string[] classes = { "Java", "C#", "SQL", "HTML", "JavaScript", "Node.js", "Project1", "Agile" };

            var longest = classes.Max(c => c.Length);       //  what is the length of the longest word
            var longestWord = classes.OrderBy(c => c.Length).Last();

            //      return a single value
            var high = scores.Max();        //  .Max returns largest value
            var lastClass = classes.Max();  //  last class alphabetically
            var sum = scores.Sum();         //  just add up all of the numbers
            var ave = scores.Average();     //  add up the numbers and divide by Count. Result is a double
            var cnt = scores.Count();       //  just the number element in the array
            var total = scores.Aggregate((score, total) => total += score);
            var first = scores.First();     //  get the first number in the array
            var last = scores.Last();       //  get the last number in the array
            var elementX = scores.ElementAt(6);

            //  analysis methods -- return true or false
            var any = classes.Any(c => c.Length < 4);       //  are ANY elements less than 4 characters long
            var all = classes.All(c => c.Contains("e"));    //  do ALL elements of the array contain 'e'
            var contain = classes.Contains("Java");         //  true or false do any of the elements match Java
            var score234 = scores.Contains(234);

            //  creating a new collection
            var uniq = scores.Distinct();
            var mToZ = classes.Where(course => course.CompareTo("M") >= 0);
            var odds = scores.Where(nextScore => nextScore % 2 == 1);

            //  modify a collection
            var uniqueOdds = odds.Distinct();           //  get list of unique odds
            var sortedScores = scores.OrderBy(s => s);  //  new list in numerical order
            var reversOdds = odds.Reverse();            //  just reverse the list
            var first5 = scores.Take(5);                //  make list with the first 5 elements
            var last5 = scores.TakeLast(5);             //  make list with the last 5 elements
            var skipFirst5 = scores.Skip(5);            //  skip first 5 and copy the rest

            var second5 = scores.Skip(3).Take(5).Distinct().OrderBy(s => s).Reverse();

            var classList = classes.OrderBy(c => c);
            var highScores = scores.Where(score => score > 200)
                                   .OrderBy(score => score)
                                   .Reverse();
        }
    }
}
