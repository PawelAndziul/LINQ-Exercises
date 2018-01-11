using System;
using System.Collections.Generic;
using System.IO;
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

        [TestMethod()]
        public void Ex5Test()
        {
            string inputString = "apple";
            Dictionary<String, int> expectedResult = new Dictionary<string, int>
            {
                { "a", 1 },
                { "p", 2 },
                { "l", 1 },
                { "e", 1 }
            };

            ExercisesPart1 exercises = new ExercisesPart1();
            Dictionary<String, int> actualResult = exercises.Ex5(inputString);

            Assert.IsTrue(expectedResult.SequenceEqual(actualResult));
        }

        [TestMethod()]
        public void Ex6Test()
        {
            int dayOfTheWeek = 1;
            string expectedResult = "Thuesday";


            ExercisesPart1 exercises = new ExercisesPart1();
            string acutalResult = exercises.Ex6(dayOfTheWeek);

            Assert.AreEqual(acutalResult, expectedResult);

        }

        [TestMethod()]
        public void Ex6Test_OverSevenDays()
        {
            int dayOfTheWeek = 11;
            string expectedResult = "Friday";


            ExercisesPart1 exercises = new ExercisesPart1();
            string acutalResult = exercises.Ex6(dayOfTheWeek);

            Assert.AreEqual(acutalResult, expectedResult);

        }

        [TestMethod()]
        public void Ex6Test_LessThanADay()
        {
            int dayOfTheWeek = -1;
            string expectedResult = "Sunday";


            ExercisesPart1 exercises = new ExercisesPart1();
            string acutalResult = exercises.Ex6(dayOfTheWeek);

            Assert.AreEqual(acutalResult, expectedResult);

        }

        [TestMethod()]
        public void Ex7Test()
        {
            int[] inputArray = { 1, 2, 2 };

            TripleInteger[] expectedResult = new TripleInteger[2];
            expectedResult[0] = new TripleInteger(1, 1, 1);
            expectedResult[1] = new TripleInteger(2, 4, 2);

            ExercisesPart1 exercises = new ExercisesPart1();
            TripleInteger[] actualResult = exercises.Ex7(inputArray);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(actualResult[i].FirstValue, expectedResult[i].FirstValue);
                Assert.AreEqual(actualResult[i].SecondValue, expectedResult[i].SecondValue);
                Assert.AreEqual(actualResult[i].ThirdValue, expectedResult[i].ThirdValue);
            }
        }

        [TestMethod()]
        public void Ex8Test()
        {
            string startingChar = "P";
            string endingChar = "S";
            string[] expectedResult = { "Paris" };

            ExercisesPart1 exercises = new ExercisesPart1();
            string[] actualResult = exercises.Ex8(startingChar, endingChar);

            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }

        [TestMethod()]
        public void Ex8Test_MultipleResults()
        {
            string startingChar = "N";
            string endingChar = "i";
            string[] expectedResult = { "Nairobi", "New Delhi" };

            ExercisesPart1 exercises = new ExercisesPart1();
            string[] actualResult = exercises.Ex8(startingChar, endingChar);

            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }

        [TestMethod()]
        public void Ex9Test()
        {
            int[] inputArray = { 1, 2, 3, 80, 81, 82, -1 };
            int[] expectedResults = { 81, 82 };

            ExercisesPart1 exercises = new ExercisesPart1();
            int[] actualResults = exercises.Ex9(inputArray);

            Assert.IsTrue(actualResults.SequenceEqual(expectedResults));
        }

        [TestMethod()]
        public void Ex10Test()
        {
            List<int> inputList = new List<int>
            {
                10,
                20,
                30,
                40,
                50
            };

            int memberValue = 30;
            int[] expectedResult = { 40, 50 };

            ExercisesPart1 exercises = new ExercisesPart1();
            int[] actualResult = exercises.Ex10(inputList, memberValue);

            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));

        }

        [TestMethod()]
        public void Ex11Test()
        {
            int[] inputArray = { 9, 2, 3, 4, 5, 6, 7, 8, 1 };
            int topValuesCount = 3;
            int[] expectedResults = { 9, 8, 7 };

            ExercisesPart1 exercises = new ExercisesPart1();
            int[] actualResults = exercises.Ex11(inputArray, topValuesCount);

            Assert.IsTrue(actualResults.SequenceEqual(expectedResults));
        }

        [TestMethod()]
        public void Ex12Test()
        {
            string inputString = "This IS test STRING";
            string[] expectedResults = { "IS", "STRING" };

            ExercisesPart1 exercises = new ExercisesPart1();
            string[] actualResults = exercises.Ex12(inputString);

            Assert.IsTrue(actualResults.SequenceEqual(expectedResults));
        }

        [TestMethod()]
        public void Ex13Test()
        {
            string[] inputArray = { "It", "works" };
            string expectedResult = "It works";

            ExercisesPart1 exercises = new ExercisesPart1();
            string actualResult = exercises.Ex13(inputArray);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void Ex15Test()
        {
            string[] inputArray = {"aaa.frx",
                "bbb.TXT",
                "xyz.dbf",
                "abc.pdf",
                "aaaa.PDF",
                "xyz.frt",
                "abc.xml",
                "ccc.txt",
                "zzz.txt" };
            Dictionary<string, int> expectedResults = new Dictionary<string, int>();
            expectedResults.Add("frx", 1);
            expectedResults.Add("txt", 3);
            expectedResults.Add("dbf", 1);
            expectedResults.Add("pdf", 2);
            expectedResults.Add("frt", 1);
            expectedResults.Add("xml", 1);

            ExercisesPart1 exercises = new ExercisesPart1();
            Dictionary<string, int> actualResults = exercises.Ex14(inputArray);

            Assert.IsTrue(actualResults.SequenceEqual(expectedResults));

        }

        [TestMethod()]
        public void Ex16Test()
        {
            string inputString = "./Resources/Ex16File.txt";
            long expectedResult = new FileInfo(inputString).Length;

            ExercisesPart1 exercises = new ExercisesPart1();
            long actualResult = exercises.Ex16(inputString);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod()]
        public void Ex16Test_NoFileSpecified()
        {
            string inputString = "";
            long expectedResult = -1;

            ExercisesPart1 exercises = new ExercisesPart1();
            long actualResult = exercises.Ex16(inputString);

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}