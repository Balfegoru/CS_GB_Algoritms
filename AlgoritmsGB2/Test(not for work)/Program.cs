using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    class Program
    {

        public class TestCase
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static int SumPositive(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("x and y must be positive");
            }

            return x + y;
        }

        static void TestSum(TestCase testCase)
        {
            try
            {
                var actual = SumPositive(testCase.X, testCase.Y);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }

            }
        }

        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 6,
                Y = 4,
                Expected = 10,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 1,
                Y = 4,
                Expected = 5,
                ExpectedException = null
            };

            TestSum(testCase1);
            TestSum(testCase2);
        }
    }
}