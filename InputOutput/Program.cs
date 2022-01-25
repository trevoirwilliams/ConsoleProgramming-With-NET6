// See https://aka.ms/new-console-template for more information


// Declare Variable - a storage space in memory for the time an application is running 
/*
    Data types
    string - Words/numbers (Name, license plate number) - "Trevoir", "Hello World"
    int - whole numbers | double/float - decimals
    char - One Character ('A', '7', '%')
 */

string fullName; //camelCase

// Allow user input and store in variable
Console.WriteLine("Enter Your Full Name: ");
fullName = Console.ReadLine();

//Print contents of variable/user's input
Console.Write("Your Full Name Is: ");
Console.WriteLine(fullName);