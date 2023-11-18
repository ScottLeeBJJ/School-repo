using System;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Program class and call the run method
            (new Program()).run();
        }

        void run()
        {
            // Declare three integer variables
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            // Print a header for the output
            // I wasn't sure if you wanted this changed to student copy so I left it alone
            Console.WriteLine("Teacher's Copy");

            // Test cases with different values for the variables
            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
        }

        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            // Check if firstChoice is non-zero, if true, print its value
            if (firstChoice != 0)
                Console.Write($"{firstChoice}, ");

            // Check if secondChoice is non-zero and firstChoice is non-zero, if true, print its value
            if (secondChoice != 0 && firstChoice != 0)
                Console.Write($"{secondChoice}, ");

            // Check if thirdChoice is non-zero and secondChoice is non-zero, if true, print its value
            if (thirdChoice != 0 && secondChoice != 0)
                Console.Write($"{thirdChoice}");

            // Add a newline after printing the choices
            Console.WriteLine();
        }
    }
}
