using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PensionPlan
{
    public class InputParametersPensionPlan
    {
        public float TaxBase { get; set; }
        public float IndividualPensionPlan { get; set; }
        public float CompanyPensionPlan { get; set; }
        public string CountryWhereDeclared { get; set; }

        public InputParametersPensionPlan() { }

        public InputParametersPensionPlan(float taxBase, float individualPensionPlan, float companyPensionPlan, string countryWhereDeclared)
        {
            TaxBase = taxBase;
            IndividualPensionPlan = individualPensionPlan;
            CompanyPensionPlan = companyPensionPlan;
            CountryWhereDeclared = countryWhereDeclared;
        }

        public override string ToString()
        {
            return "PensionPlansModel: TaxBase(" + TaxBase
                    + "), IndividualPensionPlan(" + IndividualPensionPlan
                    + "), CompanyPensionPlan(" + CompanyPensionPlan
                    + "), CountryWhereDeclared(" + CountryWhereDeclared + ").";
        }
    }
}
