using System;

class AddMultiplyFourInts
{
    static void Main()
    {
        // Create and initialize four integer variables
        int num1 = 13;
        int num2 = 55;
        int num3 = 123;
        int num4 = 325;

        // Calculate the sum and product
        int sum = num1 + num2 + num3 + num4;
        int product = num1 * num2 * num3 * num4;

        // Print the results
        Console.WriteLine("Sum of the four integers: " + sum);
        Console.WriteLine("Product of the four integers: " + product);

        // Keep the console window open
        Console.ReadLine();
    }
}
