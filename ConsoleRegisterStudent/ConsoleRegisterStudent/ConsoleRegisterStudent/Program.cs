using System;

namespace ConsoleRegisterStudent
{
    class Program
    {
        // Constants
        const int CreditHoursPerCourse = 3;
        const int CreditHoursLimit = 9;

        // Array to map choices to course names
        static string[] CourseNames = { "", "IT 145", "IT 200", "IT 201", "IT 270", "IT 315", "IT 328", "IT 330" };

        // Entry point of the program
        static void Main()
        {
            // Create an instance of the Program class and start the program
            new Program().Run();
        }

        // Main program logic
        void Run()
        {
            // Variables to track user choices and credit hours
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;
            int totalCredit = 0;
            string yesOrNo;

            // Initial message
            Console.WriteLine("Teacher's Copy");

            // Main loop for course registration
            do
            {
                // Display course menu and prompt for user input
                WritePrompt();

                // Read user input and validate it
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    // Validate the user choice and perform actions accordingly
                    int validationResult = ValidateChoice(choice, firstChoice, secondChoice, thirdChoice, totalCredit);

                    switch (validationResult)
                    {
                        case 0:
                            // If choice is valid, register the student for the course
                            Console.WriteLine($"Registration Confirmed for course {ChoiceToCourse(choice)}.");
                            totalCredit += CreditHoursPerCourse;

                            // Update the first, second, or third choice based on availability
                            UpdateCourseChoice(choice, ref firstChoice, ref secondChoice, ref thirdChoice);
                            break;
                        case -1:
                            // If choice is not recognized, display an error message
                            Console.WriteLine($"Your entered selection {choice} is not a recognized course.");
                            break;
                        case -2:
                            // If already registered for the course, display an error message
                            Console.WriteLine($"You have already registered for {ChoiceToCourse(choice)} course.");
                            break;
                        case -3:
                            // If exceeding credit limit, display an error message
                            Console.WriteLine("You cannot register for more than 9 credit hours.");
                            break;
                        default:
                            // Handle unexpected validation results
                            Console.WriteLine($"Unexpected validation result: {validationResult}");
                            break;
                    }

                    // Display the current registration status
                    WriteCurrentRegistration(firstChoice, secondChoice, thirdChoice);
                }
                else
                {
                    // Handle invalid input (non-integer)
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                // Prompt the user to register for another course
                Console.Write("\nDo you want to try again? (Y|N)? : ");
                yesOrNo = Console.ReadLine().ToUpper();
            } while (yesOrNo == "Y");

            // Display a thank you message when the user finishes registering
            Console.WriteLine("Thank you for registering with us");
        }

        // Display the course menu
        void WritePrompt()
        {
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1] IT 145\n[2] IT 200\n[3] IT 201\n[4] IT 270\n[5] IT 315\n[6] IT 328\n[7] IT 330");
            Console.Write("Enter your choice : ");
        }

        // Validate the user choice based on business rules
        int ValidateChoice(int choice, int firstChoice, int secondChoice, int thirdChoice, int totalCredit)
        {
            return (choice < 1 || choice > 7) ? -1 : // Choice not recognized
                (choice == firstChoice || choice == secondChoice || choice == thirdChoice) ? -2 : // Already registered for the course
                (totalCredit + CreditHoursPerCourse > CreditHoursLimit) ? -3 : // Exceeding credit limit
                0; // Valid choice
        }

        // Display the current registration status
        void WriteCurrentRegistration(int firstChoice, int secondChoice, int thirdChoice)
        {
            Console.Write("You are currently registered for ");
            Console.WriteLine(secondChoice == 0
                ? $"{ChoiceToCourse(firstChoice)}"
                : thirdChoice == 0
                    ? $"{ChoiceToCourse(firstChoice)}, {ChoiceToCourse(secondChoice)}"
                    : $"{ChoiceToCourse(firstChoice)}, {ChoiceToCourse(secondChoice)}, {ChoiceToCourse(thirdChoice)}");
        }

        // Convert course choice to course name
        string ChoiceToCourse(int choice)
        {
            return CourseNames[choice];
        }

        // Update the course choice based on availability
        void UpdateCourseChoice(int choice, ref int firstChoice, ref int secondChoice, ref int thirdChoice)
        {
            if (firstChoice == 0)
                firstChoice = choice;
            else if (secondChoice == 0)
                secondChoice = choice;
            else if (thirdChoice == 0)
                thirdChoice = choice;
        }
    }
}
