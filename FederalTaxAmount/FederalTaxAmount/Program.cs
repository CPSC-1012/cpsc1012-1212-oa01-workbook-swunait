/* The Canadian federal income tax that a person pays is a function of the person’s taxable income. The following 
table contains the formulas for computing a single person’s tax (Federal tax rates for 2016).
Bracket Taxable Income Marginal 
tax rate
Tax paid
1 $45,282 or less 15% 15%
2 Between $45,282 and $90,563 20.5% $6792 + 20.5% of the amount over $45,282
3 Between $90,563 and $140,388 26% $16,075 + 26% of the amount over $90,563
4 Between $140,388 and $200,000 29% $29,029 + 29% of the amount over $140,388
5 Over $200,000 33% $46,317 + 33% of the amount over $200,000
The marginal tax rate is the tax rate you pay on the last dollar earned. 
This rate gives you an idea of how much 
tax would be taken from any additional earnings you might make. 
 * 
 * */
using System;

namespace FederalTaxAmount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxableIncome, taxOwed;
            Console.WriteLine("Enter your taxable income: ");
            taxableIncome = double.Parse(Console.ReadLine());
            Console.Write("Your marginal tax rate is ");
            if (taxableIncome > 200_000)
            {
                Console.WriteLine("33%");
                taxOwed = 46_317 + 0.33 * (taxableIncome - 200000);
            }
            else if (taxableIncome > 140_388)
            {
                Console.WriteLine("29%");
                taxOwed = 29_029 + 0.29 * (taxableIncome - 140_388);
            }
            else if (taxableIncome > 90_563)
            {
                Console.WriteLine("26%");
                taxOwed = 16075 + 0.26 * (taxableIncome - 90_563);
            }
            else if (taxableIncome > 45_282 ) 
            {
                Console.WriteLine("20.5%");
                taxOwed = 6792 + 0.205 * (taxableIncome - 45_282);
            }
            else
            {
                Console.WriteLine("15%");
                taxOwed = 0.15 * taxableIncome; 
            }
            taxOwed = Math.Round(taxOwed, 2);
            Console.WriteLine($"Your approximate federal tax is: {taxOwed:C}");
        }
    }
}
