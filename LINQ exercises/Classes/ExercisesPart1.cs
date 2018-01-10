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
                select new {value, squareValue};

            DoubleInteger[] resultArray = new DoubleInteger[querry.Count()];

            int counter = 0;
            foreach (var querryResult in querry)
            {
                resultArray[counter] = new DoubleInteger(querryResult.value, querryResult.squareValue);
                counter++;
            }

            return resultArray;
        }
    }
}
