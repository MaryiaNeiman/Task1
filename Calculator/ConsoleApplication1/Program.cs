using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools;
using System.Configuration;
using Mathematics;
using System.Resources;
using System.Globalization;
using System.Threading;

using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int firstNumber = 0;
            int secondNumber = 0;

            String flagForWork = ConfigurationManager.AppSettings["OptionsOfWork"];
            String flagForReading = ConfigurationManager.AppSettings["MethodOfReading"];



            switch (flagForReading)
            {
                case "1":
                    List<int> listOfParametrs = ReadFromConcole();
                    firstNumber = listOfParametrs[0];
                    secondNumber = listOfParametrs[1];
                    break;

                case "2":
                    List<int> listOfParametrs2 = ReadFromFile();
                    if (listOfParametrs2.Count != 2)
                    {
                        Console.WriteLine("Invalid data are in the file!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        firstNumber = listOfParametrs2[0];
                        secondNumber = listOfParametrs2[1];
                    }

                    break;
                default:
                    Console.WriteLine("Invalid data are in the configuration file!");
                    break;

            }


            switch (flagForWork)
            {
                case "1":

                    LibraryFunction(firstNumber, secondNumber);
                    break;

                case "2":
                     Sum(firstNumber, secondNumber);
                    Console.WriteLine("Sum:" + Sum(firstNumber, secondNumber));
                    break;

                default:
                    Console.WriteLine("Invalid data are in the configuration file!");
                    break;

            }

            Console.ReadLine();
        }

        private static long Sum(int firstNumber, int secondNumber)
        {
            return (long)firstNumber + (long)secondNumber;
        }

        private static void LibraryFunction(int firstNumber, int secondNumber)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Addition = " + calc.Addition(firstNumber, secondNumber));
            Console.WriteLine("Subtraction = " + calc.Subtraction(firstNumber, secondNumber));
            Console.WriteLine("Multiplication = " + calc.Multiplication(firstNumber, secondNumber));
            Console.WriteLine("Division = " + calc.Division(firstNumber, secondNumber));
        }

        public static List<int> ReadFromConcole()
        {
            List<int> list = new List<int>();
            int firstNumber;
            int secondNumber;
            do
            {
                Console.WriteLine("Еnter the first number:");

            } while (!Int32.TryParse(Console.ReadLine(), out firstNumber));
            do
            {
                Console.WriteLine("Еnter the second number:");

            } while (!Int32.TryParse(Console.ReadLine(), out secondNumber));

            list.Add(firstNumber);
            list.Add(secondNumber);
            return list;

        }
        public static List<int> ReadFromFile()
        {
            List<int> list = new List<int>();
            int firstNumber;
            int secondNumber;

            if (!Int32.TryParse(ResourceFile.FirstNumber, out firstNumber) ||
                 !Int32.TryParse(ResourceFile.SecondNumber, out secondNumber))
            {
                return list;
            }
            else
            {
                list.Add(firstNumber);
                list.Add(secondNumber);
            }
            return list;


        }
    }
}
