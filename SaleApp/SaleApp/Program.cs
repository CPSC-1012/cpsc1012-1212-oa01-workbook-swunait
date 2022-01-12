/*  Purpose:    Compute the total of a sales item using the price and tax.
 *  
 *  Inputs:     price in dollars and cents
 *  
 *  Outputs:    sale tax
 *              sales total     
 * 
 * Algorithm:   Step 1) Prompt and read in the sale price
 *              Step 2) Calculate the sale total using the formula:
 *                          salesTax = salePrice * 0.05
 *                          saleTotal = salePrice + salesTax
 *              Step 3) Display the computed sale total        
 * 
 * Last modified:   2022-01-12
 * */
using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            double salePrice;
            const double SaleTaxRate = 0.05;
            double saleTax;
            double saleTotal;
            string userInput;

            // Step 1) Prompt and read in the sale price
            Console.Write("Enter the sale price: ");
            userInput = Console.ReadLine();
            // Convert userInput from a string type to a double type
            salePrice = double.Parse(userInput);
            //salePrice = Convert.ToDouble(userInput);
            //salePrice = double.Parse(Console.ReadLine());


            // Step 2) Calculate the sale total and saleTax
            saleTax = salePrice * SaleTaxRate;
            saleTotal = salePrice + saleTax;

            //  Step 3) Display the computed sale tax and total
            /*   1234567890  12345678       
             *   Price:        $29.75
             *   Tax:           $1.76
             *   Total:        $31.51
             * */
            Console.WriteLine($"{"Price:", -10} {salePrice, 8:C}");
            Console.WriteLine($"{"Tax:", -10} {saleTax,8:C}");
            Console.WriteLine($"{"Total", -10} {saleTotal,8:C}");
            

        }
    }
}
