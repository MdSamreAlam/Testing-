using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    /* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    public class CompoundInterest
    {
        public double CalculateCompoundInterest(double amount, double interest, int years, int annualfrequency)
        {
            double balance;

            // Formula use to calculate compound interest
            balance = amount * Math.Pow((1 + interest / annualfrequency), years * annualfrequency);
            return balance;

        }
    }
}

