using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan.Services.OutputParameters
{
    public class ConsoleOutputParameters
    {
        public static void ShowWelcomeText()
        {
            Console.WriteLine("Bienvenido a Babs_Tax_Calculator");
        }

        public static void ShowOutputParameters(float taxRelief) 
        {
            Console.WriteLine("La desgravación final es de " + taxRelief);
        }
    }
}
