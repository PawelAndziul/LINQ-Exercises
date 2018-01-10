using System;
using System.Collections.Generic;
using System.Linq;
using LINQ_exercises.Classes;
using LINQ_exercises.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            int[] expectedResult = { };

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

        [TestMethod()]
        public void Ex3Test()
        {
            int[] inputArray = { -2, -1, 0, 1, 2 };
            DoubleInteger[] expectedResult = new DoubleInteger[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                int valueInArray = inputArray[i];
                expectedResult[i] = new DoubleInteger(valueInArray, valueInArray * valueInArray);
            }

            ExercisesPart1 exercises = new ExercisesPart1();

            DoubleInteger[] actualResult = exercises.Ex3(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                Assert.AreEqual(expectedResult[i].FirstValue, actualResult[i].FirstValue);
                Assert.AreEqual(expectedResult[i].SecondValue, actualResult[i].SecondValue);
            }
        }

        [TestMethod()]
        public void Ex4Test()
        {
            int[] inputArray = { 1, 1, 1, 2, 2, 3 };
            DoubleInteger[] expectedResult = new DoubleInteger[3];
            expectedResult[0] = new DoubleInteger(1, 3);
            expectedResult[1] = new DoubleInteger(2, 2);
            expectedResult[2] = new DoubleInteger(3, 1);

            ExercisesPart1 exercises = new ExercisesPart1();
            DoubleInteger[] actualResult = exercises.Ex4(inputArray);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i].FirstValue, actualResult[i].FirstValue);
                Assert.AreEqual(expectedResult[i].SecondValue, actualResult[i].SecondValue);
            }
        }
    }
}