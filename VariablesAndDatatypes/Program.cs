// See https://aka.ms/new-console-template for more information

//Variable Declarations and Types
string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

// Prompt User for Input
Console.Write("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.Write("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please Enter Your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are You Working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine("Your name is: " + fullName);//concatenation
Console.WriteLine("Your Age is: {0}", age);
Console.WriteLine($"Your Salary is: {salary}"); //interpolation
Console.WriteLine($"Your Gender is: {gender}"); //interpolation
Console.WriteLine($"You Are Emplyed: {working}"); //interpolation
