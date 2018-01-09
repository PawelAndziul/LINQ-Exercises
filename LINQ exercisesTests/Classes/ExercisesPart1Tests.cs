using Microsoft.VisualStudio.TestTools.UnitTesting;
using LINQ_exercises.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_exercises.Classes.Tests
{
    [TestClass()]
    public class ExercisesPart1Tests
    {
        [TestMethod()]
        public void Ex1Test_Correct()
        {
            ExercisesPart1 exercises = new ExercisesPart1();

            int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expectedResult = { 0, 2, 4, 6, 8 };

            int[] actualResult = exercises.Ex1(inputArray);

            Assert.IsTrue(expectedResult.SequenceEqual(actualResult));
        }

        [TestMethod()]
        public void Ex1Test_Incorrect()
        {
            ExercisesPart1 exercises = new ExercisesPart1();

            int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expectedResult = { 1, 3, 5, 7, 9 };

            int[] actualResult = exercises.Ex1(inputArray);

            Assert.IsFalse(expectedResult.SequenceEqual(actualResult));
        }

        [TestMethod()]
        public void Ex2Test1()
        {
            ExercisesPart1 exercises = new ExercisesPart1();

            int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] actualResult = exercises.Ex2(inputArray);

            Assert.IsTrue(expectedResult.SequenceEqual(actualResult));
        }

        [TestMethod()]
        public void Ex2Test2()
        {
            ExercisesPart1 exercises = new ExercisesPart1();

            int[] inputArray = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            int[] expectedResult = {};

            int[] actualResult = exercises.Ex2(inputArray);

            Assert.IsTrue(expectedResult.SequenceEqual(actualResult));
        }

        [TestMethod()]
        public void Ex2MaxValueTest()
        {
            ExercisesPart1 exercises = new ExercisesPart1();

            int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            int[] actualResult = exercises.Ex2(inputArray, 5);

            Assert.IsTrue(expectedResult.SequenceEqual(actualResult));
        }
    }
}