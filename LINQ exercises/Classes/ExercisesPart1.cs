using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_exercises.Classes
{
    public class ExercisesPart1
    {
        public int[] Ex1(int[] inputArray)
        {
            // Write a program in C# Sharp to shows how the three parts of a query operation execute.
            // The numbers which produce the remainder 0 after divided by 2.

            if (inputArray.Length == 0)
                throw new Exception("Input array is empty");

            var result =
                from value in inputArray
                where (value % 2 == 0)
                select value;

            return result.ToArray();
        }

        public int[] Ex2(int[] inputArray)
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
            if (inputArray.Length == 0)
                return null;

            var querry =
                from value in inputArray
                where value > 0
                select value;
                

            return querry.ToArray();
        }

        public int[] Ex2(int[] inputArray, int maxValue)
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
            if (inputArray.Length == 0)
                return null;

            var querry =
                from value in inputArray
                where value > 0
                where value <= maxValue
                select value;


            return querry.ToArray();
        }

    }
}
