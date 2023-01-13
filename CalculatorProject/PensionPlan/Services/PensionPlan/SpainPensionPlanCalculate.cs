using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan.Services.PensionPlan
{
    public class SpainPensionPlanCalculate : PensionPlanCalculate
    {
        public CalculatorProject.PensionPlan.PensionPlan calculePensionPlan(InputParametersPensionPlan inputParametersPensionPlans)
        {
            var irpfPercentage = GetIrpfPercentage(inputParametersPensionPlans.TaxBase);
            var taxRelief = GetTaxRelief(irpfPercentage, inputParametersPensionPlans.IndividualPensionPlan, inputParametersPensionPlans.CompanyPensionPlan);

            return new CalculatorProject.PensionPlan.PensionPlan(    inputParametersPensionPlans.TaxBase, inputParametersPensionPlans.IndividualPensionPlan,
                                        inputParametersPensionPlans.CompanyPensionPlan, inputParametersPensionPlans.CountryWhereDeclared, taxRelief);
        }


        public float GetIrpfPercentage(float taxBase) 
        { 
            if (taxBase <= 12450)
            {
                return 0.19f;
            }
            else if (taxBase <= 20200)
            {
                return 0.24f;
            }
            else if (taxBase <= 35200)
            {
                return 0.30f;
            }
            else if (taxBase <= 60000)
            {
                return 0.45f;
            }
            else if (taxBase <= 300000)
            {
                return 0.45f;
            }
            else
            {
                return 0.47f;
            }
        }

        public float GetTaxRelief(float irpfPercentage, float individualPensionPlan, float companyPensionPlan) 
        {
            var totalCashInvested = individualPensionPlan + companyPensionPlan;
            return totalCashInvested * irpfPercentage;
        }
    }
}
