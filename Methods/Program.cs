// See https://aka.ms/new-console-template for more information

// Prototype - Defines the function (type, name and parameters)
// Definition - Has the code. It contains the code block 
// Function Call - Makes the function
// DRY - Don't Repeat Yourself

// Void Functions - Completes a task and moves along
void PrintName()
{
    Console.WriteLine("Trevoir");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The Sum of {num1} and {num2} is {num1 + num2}");
}

// Value Returning Functions - Completes a task, returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1; 

    if(largest < num2)
    {
        largest = num2;
    }
    
    if(largest < num3)
    {
        largest = num3;
    }

    return largest;
}

PrintName();
Console.WriteLine("End of Void Function");

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
Console.WriteLine("End of Void Function");

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");
