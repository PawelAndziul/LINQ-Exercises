using System;
using System.Collections.Generic;
using System.Linq;
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

            var querry =
                from value in inputArray
                where value > 0
                select value;


            return querry.ToArray();
        }

        public int[] Ex2(int[] inputArray, int maxValue)
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

            var querry =
                from value in inputArray
                where value > 0
                where value <= maxValue
                select value;


            return querry.ToArray();
        }

        public DoubleInteger[] Ex3(int[] inputArray)
        {
            // Write a program in C# Sharp to find the number of an array and the square of each number.

            var querry =
                from value in inputArray
                let squareValue = value * value
                select new { value, squareValue };

            DoubleInteger[] resultArray = new DoubleInteger[querry.Count()];

            int counter = 0;
            foreach (var querryResult in querry)
            {
                resultArray[counter] = new DoubleInteger(querryResult.value, querryResult.squareValue);
                counter++;
            }

            return resultArray;
        }

        public DoubleInteger[] Ex4(int[] inputArray)
        {
            //Write a program in C# Sharp to display the number and frequency of number from giving array.

            var querry =
                from value in inputArray
                group value by value into count
                select count;

            DoubleInteger[] resultArray = new DoubleInteger[querry.Count()];
            int counter = 0;

            foreach (var querryResult in querry)
            {
                resultArray[counter] = new DoubleInteger(querryResult.Key, querryResult.Count());
                counter++;
            }

            return resultArray;
        }

        public Dictionary<String, int> Ex5(string inputString)
        {
            // Write a program in C# Sharp to display the characters and frequency of character from giving string.

            var querry =
                from character in inputString
                group character by character into count
                select count;

            Dictionary<String, int> resultDictionary = new Dictionary<string, int>();
            foreach (var querryResult in querry)
            {
                resultDictionary.Add(querryResult.Key.ToString(), querryResult.Count());
            }

            return resultDictionary;
        }

        public String Ex6(int day)
        {
            //Write a program in C# Sharp to display the name of the days of a week.

            string[] daysNames = { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var querry =
                from dayName in daysNames
                select dayName;

            if (day < 0)
            {
                return querry.ToArray()[day % 7 + 7];
            }
            return querry.ToArray()[day % 7];
        }
    }
}
