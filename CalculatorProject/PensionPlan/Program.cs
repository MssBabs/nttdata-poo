using CalculatorProject.PensionPlan.Services.OutputParameters;
using CalculatorProject.PensionPlan.Services.PensionPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    public class Program
    {
        static void Main(string[] args) 
        {
            ConsoleOutputParameters.ShowWelcomeText();

            InputParametersPensionPlan inputParametersPensionPlan = ConsoleInputParameters.GetInputParametersPensionPlan();

            PensionPlanCalculate pensionPlanCalculate = null;
            if (inputParametersPensionPlan.CountryWhereDeclared == "españa") 
            {
                pensionPlanCalculate = new SpainPensionPlanCalculate();
            }
            else 
            {
                pensionPlanCalculate = new AndorraPensionPlanCalculate();
            }
            PensionPlan pensionPlan = pensionPlanCalculate.calculePensionPlan(inputParametersPensionPlan);
            ConsoleOutputParameters.ShowOutputParameters(pensionPlan.TaxRelief);
        }
    }
}
