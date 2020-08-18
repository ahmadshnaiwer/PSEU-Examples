using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorExample.Core
{
    public class TaxCalculatorForPS : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 20 / 100;
        }
    }
}
