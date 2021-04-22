using java.lang;
using System;
using Math = System.Math;

namespace Trifort
{
    public class Program
    {
        
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();

            program.Story2(5000,7.5M,1);
           


        }
        public decimal Story1(decimal principal, decimal apr, decimal years)
        {
            if (apr < 0)
            {
                throw new IllegalArgumentException("Interest rate cannot be negative.");
            }
            decimal interest = apr / (12*100);
            decimal payments = years * 12;
            decimal x = (decimal)Math.Pow((double)(1 + interest), (double)payments);
            decimal a = principal * (interest + (interest / (x - 1)));
            
            return decimal.Round(a, 2);
        }

        public void Story2(decimal principal, decimal apr, decimal years)
        {
            if (apr == 0)
            {
                throw new IllegalArgumentException("APR cannot be zero.");
            }
            if (apr < 0)
            {
                throw new IllegalArgumentException("Interest rate cannot be negative.");
            }
            decimal monthlyInterest = apr / (12 * 100);
            decimal payment = 433.79M;
            decimal balance = principal;
            for (int x = 0; x < 12; x++)
            {
                decimal interest = monthlyInterest * balance;
                balance -= (payment-interest);
           
                Console.WriteLine("payment number: " + (x+1) + " payment: " + payment + " interest: " + decimal.Round(interest, 2) + " principal: " + decimal.Round((payment - interest), 2)+ " balance: " + decimal.Round(balance, 2));
            }
            
            
        }
    }
}
