using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorExample.Models
{
    public class TaxParams
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public string Country { get; set; }
    }
}
