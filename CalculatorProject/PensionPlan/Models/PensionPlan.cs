using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorProject.PensionPlan
{
    public class PensionPlan
    {
        public float TaxBase { get; set; }
        public float IndividualPensionPlan { get; set; }
        public float CompanyPensionPlan { get; set; }
        public string CountryWhereDeclared { get; set; }
        public float TaxRelief { get; set; }

        public PensionPlan(){}

        public PensionPlan(float taxBase, float individualPensionPlan, float companyPensionPlan, string countryWhereDeclared, float taxRelief)
        {
            TaxBase = taxBase;
            IndividualPensionPlan = individualPensionPlan;
            CompanyPensionPlan = companyPensionPlan;
            CountryWhereDeclared = countryWhereDeclared;
            TaxRelief = taxRelief;
        }

        public override string ToString()
        {
            return  "PensionPlansModel: TaxBase(" + TaxBase 
                    + "), IndividualPensionPlan(" + IndividualPensionPlan 
                    + "), CompanyPensionPlan(" + CompanyPensionPlan
                    + "), CountryWhereDeclared(" + CountryWhereDeclared
                    + "), TaxRelief(" + TaxRelief + ").";
        }
    }
}
