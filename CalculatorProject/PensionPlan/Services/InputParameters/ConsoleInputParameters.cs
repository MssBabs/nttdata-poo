using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    public class ConsoleInputParameters
    {
        public static InputParametersPensionPlan GetInputParametersPensionPlan() 
        {
            Console.WriteLine("¿Cuál es la base imponible?");
            var taxBase = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de persona física?");
            var individualPensionPlan = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de empresa?");
            var companyPensionPlan = float.Parse(Console.ReadLine());

            Console.WriteLine("¿En que pais se declara la hacienda?");
            var countryWhereDeclared = Console.ReadLine().ToLower();

            return new InputParametersPensionPlan(taxBase, individualPensionPlan, companyPensionPlan, countryWhereDeclared);
        }
    }
}
