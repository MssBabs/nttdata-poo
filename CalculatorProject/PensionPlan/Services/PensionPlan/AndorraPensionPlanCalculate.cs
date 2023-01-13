using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan.Services.PensionPlan
{
    public class AndorraPensionPlanCalculate : PensionPlanCalculate
    {
        public CalculatorProject.PensionPlan.PensionPlan calculePensionPlan(InputParametersPensionPlan inputParametersPensionPlans)
        {
            var irpfPercentage = GetIrpfPercentage(inputParametersPensionPlans.TaxBase);
            var taxRelief = GetTaxRelief(irpfPercentage, inputParametersPensionPlans.IndividualPensionPlan, inputParametersPensionPlans.CompanyPensionPlan);

            return new CalculatorProject.PensionPlan.PensionPlan(inputParametersPensionPlans.TaxBase, inputParametersPensionPlans.IndividualPensionPlan,
                                        inputParametersPensionPlans.CompanyPensionPlan, inputParametersPensionPlans.CountryWhereDeclared, taxRelief);
        }


        public float GetIrpfPercentage(float taxBase)
        {
            if (taxBase <= 24000)
            {
                return 0.00f;
            }
            else if (taxBase <= 40000)
            {
                return 0.05f;
            }
            else
            {
                return 0.10f;
            }
        }

        public float GetTaxRelief(float irpfPercentage, float individualPensionPlan, float companyPensionPlan)
        {
            var totalCashInvested = individualPensionPlan + companyPensionPlan;
            return totalCashInvested * irpfPercentage;
        }
    }
}
