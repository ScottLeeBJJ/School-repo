using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a value: ");
        string input = Console.ReadLine();

        // Here, we assume that the original value is of type string.
        // You can modify this code to handle other data types.
        
        // Convert the string to an integer (int).
        if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine("Converted to int: " + intValue);
        }
        else
        {
            Console.WriteLine("Value cannot be converted to int.");
        }

        // Convert the string to a double.
        if (double.TryParse(input, out double doubleValue))
        {
            Console.WriteLine("Converted to double: " + doubleValue);
        }
        else
        {
            Console.WriteLine("Value cannot be converted to double.");
        }

        // Convert the string to a boolean (bool).
        if (bool.TryParse(input, out bool boolValue))
        {
            Console.WriteLine("Converted to bool: " + boolValue);
        }
        else
        {
            Console.WriteLine("Value cannot be converted to bool.");
        }

        // You can add more data type conversions as needed.

        Console.ReadLine(); // Keep the console window open.
    }
}
