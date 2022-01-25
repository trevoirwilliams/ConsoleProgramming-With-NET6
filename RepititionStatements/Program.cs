// See https://aka.ms/new-console-template for more information


// For Loop (Counter Controlled)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine($"Counter value: {i}");
}

Console.WriteLine();
Console.WriteLine("FOR LOOP FINISHED");

// While Loop (Condition Controlled - Pre ChecK)
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");
}

Console.WriteLine();
Console.WriteLine("WHILE LOOP FINISHED");

// Do...While Loop (Condition Controlled - Post ChecK)
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");
} while (n < 5);

Console.WriteLine();
Console.WriteLine("DO...WHILE LOOP FINISHED");

// Foreach - Honourable Mention
