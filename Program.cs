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
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            double interest;
            int annualcompound;
            int years;
            // double balance = 0;

            Console.Write("Enter the Amount:");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Interest Rate:");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter number of Years:");
            years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter annual frequency:");
            annualcompound = Convert.ToInt32(Console.ReadLine());
            CompoundInterest compoundIntrest = new CompoundInterest();
            var results = compoundIntrest.CalculateCompoundInterest(amount, interest, years, annualcompound);

            Console.WriteLine("Total Amount Balance is: {0}", results);

            Console.ReadLine();
        }
    }
 }

