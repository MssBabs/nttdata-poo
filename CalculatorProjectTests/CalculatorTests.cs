using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        /*
         *  [TestMethod()]
         *  public void AddTest()
         *  {
         *      var calculator = new Calculator();
         *      Assert.IsTrue(calculator.Add(2,2) == 4);
         *      Assert.IsFalse(calculator.Add(2, 2) != 4);
         *      Assert.Fail("The method is not yet implemented");
         *  }
         */

        [DataRow(3,3,6)]
        [DataRow(5,6,11)]
        [DataTestMethod]
        public void AddTest(int num1,int num2,int result)
        {
            Assert.IsTrue(calculator.Add(num1,num2) == result);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
            Assert.IsFalse(calculator.Substract(2, 2) != 0);
            //Assert.Fail("The method is not yet implemented");
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(2, 2) == 4);
            Assert.IsFalse(calculator.Multiply(2, 2) != 4);
            //Assert.Fail("The method is not yet implemented");
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(calculator.Divide(8, 2) == 4);
            Assert.IsFalse(calculator.Divide(8, 2) != 4);
            //Assert.Fail("The method is not yet implemented");
        }
    }
}