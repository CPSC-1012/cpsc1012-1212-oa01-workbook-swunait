/*
 * Write a program that can allow the user to perform some simple unit conversions. 
 * The program should display a menu of available options to the user, 
 * prompt for the desired option, and then prompt for the value. 
 * The conversion should be performed and the new value should be displayed. 
 * 
 * Use the following table for conversions:
    CONVERSION FORMULA
    POUNDS TO KILOGRAMS kg = lb / 2.2046
    FLUID OUNCES (U.S.) TO LITERS 1 liter = 33.8140226 ounces
    INCHES TO CENTIMETERS cm = in / 0.39370
    FAHRENHEIT TO CELSIUS C = (F - 32) / 1.800
As an option, also allow for conversions in the opposite direction (e.g. kilograms to pounds)

Purpose: Allow the user to select a unit of conversion to perform

Inputs: menuChoice
        conversionFromValue

Outputs:    conversionToValue

Algorithm:   Step 1) Prompt and read in a menu choice
                    1 for weight, 
                    2 for volume, 
                    3 for length, 
                    4 for temperature, 
                    99 to exit program
            Step 2) Process the menu choice as follows:
                If menuChoice = 1 Then do the following:
                    Prompt and read in the weight in pounds
                    Compute the weight in kilogram using the formula:
                        weightInKilogram = weightInPounds / 2.2046
                    Display the calculated results
                Else if menuChoice = 2 then do the following:
                    Prompt and read in the volume in fluid ounces
                    Compute the volume in liters using the formula:
                        volumeInLiters =  volumeInFluidOunces / 33.8140226
                    Display the calculated results
                Else if menuChoice = 3 then doing the following
                    Prompt and read in the length in inches
                    Compute the length in centimeters using the formula:
                        lengthInCentimeters = lengthInInches / 0.39370
                    Display the calculated results
                Else if menuChoice = 4 then do the following
                    Prompt and read in the temperature in fahrenheit
                    Compute the temperature in celisus using the formula:
                        temperatureCelsius =  (temperatureFanhrenheit - 32) / 1.800
                    Display the calculated results
                Else if menuChoice = 99 then do the following 
                    Display a good bye message
                Else
                    Display an invalid menu choice message
                End If

Test Plan:
    Test Case           Test Data               Expected Results    Passed
    --------            ---------               ----------------    ------
    convert weight      menuChoice: 1           180 lb = 81.6 kg
                        lbs = 180

    convert volume     menuChoice: 2            5 oz = 0.15 liter
                       oz = 5

    convert length      menuChoice: 3           15 inches = 38.1 cm
                        inches = 15

    convert temp        menuChoice: 4           30 F = -1.1 C
                        F = 30

    exit program        menuChoice: 99          Good-bye message

    invalid menuChoice  menuChoice: 0           Invalid menu choice


 * 
 * */
using System;

namespace DMP_SwitchQuestion02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;

            // Prompt and read in the menu choice
            Console.WriteLine("*** Conversion Program ***");
            Console.WriteLine("Please choose one of the following choices: ");
            Console.WriteLine("1. Convert weight from pounds to kilogram,");
            Console.WriteLine("2. Convert volume from fluid ounces to liters,");
            Console.WriteLine("3. Convert length from centimeters to inches,");
            Console.WriteLine("4. Convert temperature from fahrenheit to celsius,");
            Console.WriteLine("99. Exit program");
            Console.Write("\tYour choice: ");
            menuChoice = int.Parse(Console.ReadLine());

            // Process the menu choice
            switch (menuChoice)
            {
                case 1: // convert weigt
                    {
                        double  pounds,
                                kilograms;
                        Console.Write("Enter weight in pounds: ");
                        pounds = double.Parse(Console.ReadLine());
                        kilograms = pounds / 2.2046;
                        Console.WriteLine($"{pounds:F1} pounds = {kilograms:F1} kilograms");
                    }
                    break;
                case 2: // convert volume
                    {
                        double fluidOunces,
                                liters;
                        Console.Write("Enter volume in fluid ounces: ");
                        fluidOunces = double.Parse(Console.ReadLine());
                        liters = fluidOunces / 33.8140226;
                        Console.WriteLine($"{fluidOunces:F2}oz = {liters:F2}L");
                    }
                    break;
                case 3: // convert length
                    {
                        double centimeters,
                                inches;
                        Console.Write("Enter length in inches: ");
                        inches = double.Parse(Console.ReadLine());
                        centimeters = inches / 0.39370;
                        Console.WriteLine($"{inches:F2}inch = {centimeters:F2}cm");
                    }
                    break;
                case 4: // convert temperature
                    {
                        double celisus,
                                fahrenheit;
                        Console.Write("Enter temperature in fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine());
                        celisus = (fahrenheit - 32) / 1.800;
                        Console.WriteLine($"{fahrenheit:F1} F = {celisus:F1} C");
                    }
                    break;
                case 99:    // exit program
                    Console.WriteLine("Good-bye and come back again.");
                    break;
                default:    // invalid menu choice
                    Console.WriteLine($"Invalid menu choice of {menuChoice}.");
                    break;
            }
        }
    }
}
