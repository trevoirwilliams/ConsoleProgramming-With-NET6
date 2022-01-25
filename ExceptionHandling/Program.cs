// See https://aka.ms/new-console-template for more information


/*
    try - a try block attempts an operation
    catch - catch amy fatal error or exception
    finally - whether the try or the catch was successful, do this
    throw - end program execution with the error
 */

Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
try
{
    int quotient = num1 / num2;
    Console.WriteLine("Result is: " + quotient.ToString());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal Operation: {ex.Message}");
}
catch (Exception ex)
{
    throw;
}
finally
{
    Console.WriteLine("This is the end of the program");
}
