using System;
using TaxCalculatorExample.Core;
using TaxCalculatorExample.Models;

namespace TaxCalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculatorForUS t1 = new TaxCalculatorForUS();
            TaxCalculatorForPS t2 = new TaxCalculatorForPS();
            TaxCalculatorForJD t3 = new TaxCalculatorForJD();

            TaxParams t = new TaxParams();
            t.TotalIncome = 5000;
            t.TotalDeduction = 500;
            t.Country = "US";
            TestTaxCalculator(t);

            //ShowDetail(t1);
            //ShowDetail(t2);
            //ShowDetail(t3);
        }

        public static void TestTaxCalculator(TaxParams obj)
        {
            decimal taxAmount = 0;
            TaxCalculator taxCalculator = new TaxCalculator();
            ICountryTaxCalculator cT = null;

            switch (obj.Country)
            {
                case "PS":
                    cT = new TaxCalculatorForPS();
                    break;
                case "JD":
                    cT = new TaxCalculatorForJD();
                    break;
                case "US":
                    cT = new TaxCalculatorForUS();
                    break;
                case "UK":
                    cT = new TaxCalculatorForUK();
                    break;
            }

            cT.TotalIncome = obj.TotalIncome;
            cT.TotalDeduction = obj.TotalDeduction;
            taxAmount = taxCalculator.Calculat(cT);
            Console.WriteLine($"Tax Amount: {taxAmount}");
        }

        public static void ShowDetail(ICountryTaxCalculator taxCalc)
        {
            decimal tax = taxCalc.CalculateTaxAmount();
            Console.WriteLine($"Tax Amount: {tax}");
            Console.ReadLine();
        }
    }
}
