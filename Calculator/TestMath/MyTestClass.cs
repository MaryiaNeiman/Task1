using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics;

namespace TestMath
{
    [TestClass]
    public class MyTestClass
    {
        Calculator calc;
        int a;
        int b;

       public MyTestClass()
        {
            calc = new Calculator();
            a = Int32.Parse(ResourceFile.FirstNumber);
            b = Int32.Parse(ResourceFile.SecondNumber);
       
        }

        [TestMethod]
        public void TestAdd()
        {
          
            Assert.AreEqual((long)a + (long)b, calc.Addition(a, b));
               
        }
        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual((long)a - (long)b, calc.Subtraction(a, b));
        }

        [TestMethod]
        public void TestMul()
        {
            Assert.AreEqual((long)a *(long)b, calc.Multiplication(a, b));
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual((long)a / (long)b, calc.Division(a, b));
        }

        [TestMethod]
        public void TestDivByXero()
        {
            b = 0;
            Assert.AreEqual(Double.PositiveInfinity, calc.Division(a, b));
        }


    }
}
