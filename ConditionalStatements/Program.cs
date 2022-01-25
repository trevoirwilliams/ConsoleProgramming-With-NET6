// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberofOranges = Convert.ToInt32(Console.ReadLine());

// If Statements ( ==, <, >, >=, <=, != )
if (numberOfApples > numberofOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfApples < numberofOranges)
{
    Console.WriteLine("You have more oranges");
}
else if (numberOfApples == numberofOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");
}

Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Switch Statements
switch (grade)
{
    case int n when n >= 0 && n <= 59: // between 0 and 59
        Console.WriteLine("You Failed");
        break;
    case int n when n >= 60 && n <= 100: // between 60 and 100
        Console.WriteLine("You Passed");
        Console.WriteLine("You Passed");
        Console.WriteLine("You Passed");
        Console.WriteLine("You Passed");
        Console.WriteLine("You Passed");
        break;
    case 101:
        Console.WriteLine("Single Case Example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

// Ternary Operator
var message = numberOfApples > numberofOranges ? "You have more Apples" : "You have more Oranges";
Console.WriteLine(message);