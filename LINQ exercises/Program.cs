using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_exercises.Classes;

namespace LINQ_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercisesPart1 exercises = new ExercisesPart1();
            var results = exercises.Ex1(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            foreach (int result in results)
            {
                Console.Write($"{result} ");
            }

            Console.ReadKey();
        }
    }
}
