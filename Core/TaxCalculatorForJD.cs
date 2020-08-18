using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorExample.Core
{
    class TaxCalculatorForJD : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 30 / 100;
        }
    }
}
