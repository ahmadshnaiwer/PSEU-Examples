using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorExample.Core
{
    public class TaxCalculator
    {
        public decimal Calculat(ICountryTaxCalculator obj)
        {
            decimal taxAmount = obj.CalculateTaxAmount();

            return taxAmount;
        }
    }
}
