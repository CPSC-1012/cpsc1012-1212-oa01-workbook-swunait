using System;

namespace RetailItemProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RetailItem itemOne = new RetailItem
            //{
            //    Description = "Gears of War 4 (Xbox One)",
            //    UnitsOnHand = 30,
            //    Price = 79.99m
            //};
            //RetailItem itemOne = new RetailItem();
            //itemOne.Description = "Gears of War 4 (Xbox One)";
            //itemOne.UnitsOnHand = 30;
            //itemOne.Price = 79.99m;

            RetailItem itemOne = new RetailItem("Gears of War 4 (Xbox One)", 30, 79.99m);
            RetailItem itemTwo = new RetailItem("Minecraft (PS4)", 100, 21.99m);
            RetailItem itemThree = new RetailItem("Skylanders Imaginators Starter Pack (Wii U)", 15, 89.99m);

            //Console.WriteLine(itemOne);
            Console.WriteLine($"{itemOne.Description, -45} {itemOne.UnitsOnHand, 5} {itemOne.Price, 10:C}");
            Console.WriteLine(itemTwo.ToString());
            Console.WriteLine(itemThree);

            // Write the code to prompt the end user for the Description, UnitsOnHand, and Price
            // for a new RetailItem.
            
            // Declare local variables for the RetailItem properties
            string description;
            int unitsOnHand;
            decimal price;
            // Prompt and read in the description, unitsOnHand, and price. Assume valid input
            Console.Write("Enter the description of the item: ");
            description = Console.ReadLine();
            Console.Write($"Enter the units on hand for {description}: ");
            unitsOnHand = int.Parse(Console.ReadLine());
            Console.Write($"Enter the price for {description}: ");
            price = decimal.Parse(Console.ReadLine());
            // Create a RetailItem object using the local variables
            RetailItem userRetailItem = new RetailItem(description, unitsOnHand, price);

            // Display the Description, UnitsOnHand, and Price of a new RetailItem object
            // with value assigned by the end user
            Console.WriteLine(userRetailItem);

            // Modify the RetailItem class to include either
            // a computed property named TotalValue thats return reslts
            // of the UnitsOnHand multiply Price
            // or code a method named TotalValue() that returns the results of multiplying
            // UnitsOnHand with Price

            // Modify the program output to display the TotalValue for each RetailItem


        }
    }
}
