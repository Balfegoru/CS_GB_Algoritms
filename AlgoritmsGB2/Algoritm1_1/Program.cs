using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm1_1
{
    class Program
    {
        //Напишите на C# функцию согласно блок-схеме
        
        

        //Класс для теста
        public class TestCase
        {
            public int number { get; set; }
            public string Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        //Метод теста
        static void TestSimpNot(TestCase testCase)
        {
            try
            {
                var actual = SimpleNot(testCase.number);

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

        //Метод определение простоты числа
        static string SimpleNot(int number)
        {
            int d = 0, i = 2;

            while (i < number)
            {
                if(number%i == 0)
                {
                    d++;
                }

                i++;
            }

            if (d == 0)
            {
                
                return "Простое";
            }
            else
            {
                return "Не простое";
            }

        }

        static void Main(string[] args)
        {
            //Ввод данных
            var testCase1 = new TestCase()
            {
                number = 5,
                Expected = "Простое",
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                number = 101,
                Expected = "Простое",
                ExpectedException = null
            };


            var testCase3 = new TestCase()
            {
                number = 3211,
                Expected = "Не простое",
                ExpectedException = null
            };

            //Проверка
            TestSimpNot(testCase1);
            TestSimpNot(testCase2);
            TestSimpNot(testCase3);
        }
    }
}
