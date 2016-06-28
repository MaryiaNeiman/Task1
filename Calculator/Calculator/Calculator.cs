using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools;
using System.Configuration;

namespace Mathematics
{
    public class Calculator
    {
        public long Addition(int a, int b)
        {
            return (long)a + (long)b;
        }

        public long Subtraction(int a, int b)
        {
            return (long)a - (long)b;
        }
        
        public long Multiplication(int a, int b)
        {
            return (long)a * (long)b;
        }
        public double Division(int a, int b)
        {
            try
            {

                return a / b;
            }
            catch (ArithmeticException)
            {
                return Double.PositiveInfinity;
            }

        }


    }
}
