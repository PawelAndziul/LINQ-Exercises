using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using LINQ_exercises.Models;

namespace LINQ_exercises.Classes
{
    public class ExercisesPart1
    {
        public int[] Ex1(int[] inputArray)
        {
            // Write a program in C# Sharp to shows how the three parts of a query operation execute.
            // The numbers which produce the remainder 0 after divided by 2.

            var result =
                from value in inputArray
                where (value % 2 == 0)
                select value;

            return result.ToArray();
        }

        public int[] Ex2(int[] inputArray)
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

            var quert =
                from value in inputArray
                where value > 0
                select value;


            return quert.ToArray();
        }

        public int[] Ex2(int[] inputArray, int maxValue)
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

            var quert =
                from value in inputArray
                where value > 0
                where value <= maxValue
                select value;


            return quert.ToArray();
        }

        public DoubleInteger[] Ex3(int[] inputArray)
        {
            // Write a program in C# Sharp to find the number of an array and the square of each number.

            var quert =
                from value in inputArray
                let squareValue = value * value
                select new { value, squareValue };

            DoubleInteger[] resultArray = new DoubleInteger[quert.Count()];

            int counter = 0;
            foreach (var quertResult in quert)
            {
                resultArray[counter] = new DoubleInteger(quertResult.value, quertResult.squareValue);
                counter++;
            }

            return resultArray;
        }

        public DoubleInteger[] Ex4(int[] inputArray)
        {
            //Write a program in C# Sharp to display the number and frequency of number from giving array.

            var quert =
                from value in inputArray
                group value by value into count
                select count;

            DoubleInteger[] resultArray = new DoubleInteger[quert.Count()];
            int counter = 0;

            foreach (var quertResult in quert)
            {
                resultArray[counter] = new DoubleInteger(quertResult.Key, quertResult.Count());
                counter++;
            }

            return resultArray;
        }

        public Dictionary<String, int> Ex5(string inputString)
        {
            // Write a program in C# Sharp to display the characters and frequency of character from giving string.

            var quert =
                from character in inputString
                group character by character into count
                select count;

            Dictionary<String, int> resultDictionary = new Dictionary<string, int>();
            foreach (var quertResult in quert)
            {
                resultDictionary.Add(quertResult.Key.ToString(), quertResult.Count());
            }

            return resultDictionary;
        }

        public String Ex6(int day)
        {
            //Write a program in C# Sharp to display the name of the days of a week.

            string[] daysNames = { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var quert =
                from dayName in daysNames
                select dayName;

            if (day < 0)
            {
                return quert.ToArray()[day % 7 + 7];
            }
            return quert.ToArray()[day % 7];
        }

        public TripleInteger[] Ex7(int[] inputArray)
        {
            var quert =
                from value in inputArray
                group value by value into frequency
                select frequency;

            TripleInteger[] resultArray = new TripleInteger[quert.Count()];

            int counter = 0;
            foreach (var quertResult in quert)
            {
                resultArray[counter] = new TripleInteger(
                    quertResult.Key,
                    quertResult.Key * quertResult.Count(),
                    quertResult.Count()
                );
                counter++;
            }

            return resultArray;
        }

        public String[] Ex8(string startingChar, string endingChar)
        {
            //Write a program in C# Sharp to find the string which starts and ends with a specific character.
            string[] cities = { "Rome", "London", "Nairobi", "California", "Zurich", "New Delhi", "Amsterdam", "Abu Dhabi", "Paris" };

            var query =
                from city in cities
                where city.StartsWith(startingChar.ToUpper())
                where city.EndsWith(endingChar.ToLower())
                select city;

            return query.ToArray();
        }

        public int[] Ex9(int[] inputArray)
        {
            // Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80 as output.
            var query =
                from value in inputArray
                where value > 80
                select value;

            return query.ToArray();
        }

        public int[] Ex10(List<int> inputList, int memberValue)
        {
            // Write a program in C# Sharp to Accept the members of a list through the keyboard and display the members more than a specific value. 
            var query =
                from value in inputList
                where value > memberValue
                select value;

            return query.ToArray();
        }

        public int[] Ex11(int[] inputArray, int topValuesCount)
        {
            // Write a program in C# Sharp to display the top n-th records.

            if (topValuesCount < 1)
                return new int[] { };

            var query =
                (from value in inputArray
                 orderby value descending 
                 select value).Take(topValuesCount);

            return query.ToArray();
        }

        public string[] Ex12(string inputString)
        {
            // Write a program in C# Sharp to find the uppercase words in a string. 

            string[] inputWords = inputString.Split(' ');

            var query =
                from word in inputWords
                where word.Equals(word.ToUpper())
                select word;

            return query.ToArray();
        }

        public string Ex13(string[] inputArray)
        {
            // Write a program in C# Sharp to convert a string array to a string.
            var resultString = String.Join(" ", inputArray.Select(s => s.ToString()).ToArray());

            return resultString;
        }

        public Dictionary<string, int> Ex14(string[] inputArray)
        {
            //Write a program in C# Program to Count File Extensions and Group it using LINQ.
            var query =
                from file in inputArray
                let extension = Path.GetExtension(file)?.ToLower().TrimStart('.')
                group extension by extension into count
                select count;

            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            foreach (var queryResult in query)
            {
                resultDictionary.Add(queryResult.Key, queryResult.Count());
            }
            return resultDictionary;
        }
    }
}
