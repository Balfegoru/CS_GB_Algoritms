using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi1_2
{
    class Program
    {

        //Требуется реализовать
        //рекурсивную версию и версию без рекурсии (через цикл).


        //Класс для теста
        public class TestCase
        {
            public int number { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        //Проверка рекурсии
        static void TestFibRecurs(TestCase testCase)
        {
            try
            {
                var actual = RecursFib(testCase.number);
                

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

        //Проверка цикла
        static void TestFibCicle(TestCase testCase)
        {
            try
            {
                var actual = CicleFib(testCase.number);


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

        //Рекурсия
        static int RecursFib(int number)
        {
            if(number==1 )
            {
                return 0;
            }
            else if (number == 2) { return 1; }

            return RecursFib(number - 2) + RecursFib(number - 1);
        }

        //Цикл
        static int CicleFib(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else if (number == 2) { return 1; }

            int i = 2, first = 0, second = 1, result;

            do
            {
                result = first + second;
                first = second;
                second = result;
                i++;
            } while (i < number);

            return result;
        }

        static void Main(string[] args)
        {

            var testCase1 = new TestCase()
            {
                number = 1,
                Expected = 0,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                number = 2,
                Expected = 1,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                number = 11,
                Expected = 55,
                ExpectedException = null
            };


            TestFibRecurs(testCase1);
            TestFibRecurs(testCase2);
            TestFibRecurs(testCase3);

            TestFibCicle(testCase1);
            TestFibCicle(testCase2);
            TestFibCicle(testCase3);

        }
    }
}
