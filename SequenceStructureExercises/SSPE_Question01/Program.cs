// See https://aka.ms/new-console-template for more information
// Iteration 1 - Hardcode the output values
//Console.WriteLine("My name is Don Iveson, my age is 45 and I hope to earn $204,747.00 per year");

// Iteration 2 - Declare variables store the name, age, and annualPay
//string name = "Rachel Notely";
//int age = 43;
//double annualPay = 133_404.00;
//Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
//Console.WriteLine("My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");

// Iteration 3 - Modify program to get user to input value for name, age, and annualPay
string name;
int age;
double annualPay;

// Prompt and read in the name
Console.Write("Enter your name: ");
name = Console.ReadLine();
// Prompt and read in the age
Console.Write("Enter your age: ");
age = int.Parse(Console.ReadLine());
// Prompt and read in the annualPay
Console.Write("Enter your annual pay: ");
annualPay = double.Parse(Console.ReadLine());   

Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
