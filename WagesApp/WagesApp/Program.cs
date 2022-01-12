// See https://aka.ms/new-console-template for more information
/*  Purpose:    Compute the weekly wage of an employee.
 *  
 *  Inputs:     regular hourly rate
 *              regular hours worked
 *              overtime hourly rate
 *              overtime hours worked
 *              
 *  Outputs:    regularWages
 *              overtimeWages
 *              
 *  Algorithm:  Step 1: Prompt for regular hourly rate,
 *                  regular hours worked,
 *                  overtime hourly rate,
 *                  overtime hours worked
 *              Step 2: Compute the following values:
 *                 regularWages = regularHourlyRate * regularHoursWorked
 *                 overtimeWages = overtimeHourlyRate * overtimeHoursWorked
 *                 totalWages = regularWages + overtimeWages
 *              Step 3: Display the wages for the week   
 * */
// Declare variables for inputs and outputs
double regularHoursWorked;
double regularHourlyRate;
double overtimeHoursWorked;
double overtimeHourlyRate;
double regularWages,
        overtimeWages,
        totalWages;

// Prompt and read in the values for regular hour rate
//Console.Write
