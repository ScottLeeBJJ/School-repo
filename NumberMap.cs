using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to get the corresponding course code: ");
        int userInput = Convert.ToInt32(Console.ReadLine()); // Read user input as an integer

        // Get the corresponding course code using the GetCourseCode method
        string courseCode = GetCourseCode(userInput);

        // Display the result to the user
        if (courseCode != null)
        {
            Console.WriteLine($"The course code for {userInput} is: {courseCode}");
        }
        else
        {
            Console.WriteLine($"No course code found for {userInput}");
        }
    }

    // Method to map a number to a course code using a switch statement
    static string GetCourseCode(int number)
    {
        switch (number)
        {
            case 1:
                return "IT 145"; // If number is 1, return "IT 145"
            case 2:
                return "IT 200"; // If number is 2, return "IT 200"
            case 3:
                return "IT 201"; // If number is 3, return "IT 201"
            case 4:
                return "IT 270"; // If number is 4, return "IT 270"
            case 5:
                return "IT 315"; // If number is 5, return "IT 315"
            case 6:
                return "IT 328"; // If number is 6, return "IT 328"
            case 7:
                return "IT 330"; // If number is 7, return "IT 330"
            default:
                return null; // If number doesn't match any case, return null
        }
    }
}
