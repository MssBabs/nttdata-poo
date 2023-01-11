using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops.Tests
{
    [TestClass()]
    public class PrintProductTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context) 
        {
            PrintProduct.CreateListProduct();
        }
        
        [TestMethod()]
        public void CreateListProductTest()
        {
            Assert.Fail("The method is not yet implemented");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithForTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithFor().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithFor()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithFor()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithForEachTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithForEach()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithWhileTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithWhile().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithWhile()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithWhile()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WithLinqTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithLinq().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithLinq()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30WithLinq()[1].Name == "Juego");
        }
    }
}