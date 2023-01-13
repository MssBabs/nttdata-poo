using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PensionPlan.Services.PensionPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan.Services.PensionPlan.Tests
{
    [TestClass()]
    public class AndorraPensionPlanCalculateTests
    {
        InputParametersPensionPlan inputParametersPensionPlans = new InputParametersPensionPlan();

        [TestMethod()]
        public void calculePensionPlanTest()
        {
            Assert.Fail("The method is not yet implemented");
        }

        [DataRow(22000, 0.00f)]
        [DataRow(26000, 0.05f)]
        [DataRow(46000, 0.10f)]
        [DataTestMethod]
        public void GetIrpfPercentageTest(float num1, float result)
        {
            var taxBase = num1; 
            Assert.IsTrue(taxBase == result);
        }

        [TestMethod()]
        public void GetTaxReliefTest()
        {
            Assert.Fail("The method is not yet implemented");
        }
    }
}