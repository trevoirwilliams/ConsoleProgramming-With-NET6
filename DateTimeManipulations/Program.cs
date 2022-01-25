// See https://aka.ms/new-console-template for more information

// Empty DateTime  
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1980, 12, 31);
Console.WriteLine("My Dob is: " + dateOfBirth);
Console.WriteLine("My Dob is: " + dateOfBirth.Date);

Console.WriteLine("Day of Week:{0}", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of Year: {0}", dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day:{0}", dateOfBirth.TimeOfDay);
Console.WriteLine("Tick:{0}", dateOfBirth.Ticks);
Console.WriteLine("Kind:{0}", dateOfBirth.Kind);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now Is: " + now);

// Create a DateTime from a String  
DateTime datefromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + datefromString);

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only: " + timeOnly);
