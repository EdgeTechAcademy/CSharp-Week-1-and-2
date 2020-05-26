using System;
using System.Linq;

namespace Week1
{
    class LinqExamples
    {
        static void Main(string[] args)
        {
            int[] scores = { 3, 3, 32, 5, 2, 2, 5, 24737, 23445, 234, 435, 562, 12, 5876, 69, 096, 567, 567, 768, 58, 4 };
            string[] classes = { "Java", "C#", "SQL", "HTML", "JavaScript", "Node.js", "Project1", "Agile" };

            //      return a single value
            var high = scores.Max();        //  .Max returns largest value
            var lastClass = classes.Max();  //  last class alphabetically
            var sum = scores.Sum();
            var ave = scores.Average();
            var cnt = scores.Count();
            var total = scores.Aggregate((score, total) => total += score);
            var first = scores.First();
            var last = scores.Last();
            var elementX = scores.ElementAt(6);

            //  analysis methods
            var any = classes.Any(c => c.Length < 4);               //  are ANY elements less than 4 characters long
            var all = classes.All(c => c.Contains("e"));            //  do ALL elements of the array contain 'e'
            var contain = classes.Contains("Java");                 //  true or false do any of the elements match Java
            var score234 = scores.Contains(234);

            //  creating a new collection
            var uniq = scores.Distinct();
            var mToZ = classes.Where(course => course.CompareTo("M") >= 0);
            var odds = scores.Where(nextScore => nextScore % 2 == 1);

            //  modify a collection
            var uniqueOdds = odds.Distinct();
            var sortedScores = scores.OrderBy(s => s);
            var reversOdds = odds.Reverse();
            var first5 = scores.Take(5);
            var last5 = scores.TakeLast(5);
            var skipFirst5 = scores.Skip(5);

            var second5 = scores.Skip(3).Take(5).Distinct().OrderBy(s => s).Reverse();


            var classList = classes.OrderBy(c => c);
            var highScores = scores.Where(score => score > 200)
                                   .OrderBy(score => score)
                                   .Reverse();

            int[] bigNums = { 34521, 51454, 12341, 35673562, 134341, 76858, 1341, 5151 };
            string[] littleWords = { "to", "in", "at", "by", "of", "on", "it" };

            // what is the biggest number
            var biggest = bigNums.Max();
            // what is the average of all numbers
            var avg = bigNums.Average();
            // create a list of words that start with "o"
            var startsWithO = littleWords.Where(word => word.StartsWith("o"));
            // how many words are in the array
            int count = littleWords.Count();
            // what is the 'smallest' word?
            string early = littleWords.Min();
            early = littleWords.OrderBy(w => w).First();
            string lastWord = littleWords.Max();
        }
    }
}
