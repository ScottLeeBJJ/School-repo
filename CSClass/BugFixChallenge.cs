using System;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Program class and call the Run method
            (new Program()).Run();
        }

        void Run()
        {
            // Read the daily rate and number of days from the user
            double dailyRate = ReadDouble("Enter your daily rate: ");
            int noOfDays = ReadInt("Enter the number of days: ");

            // Calculate and display the consultant's fee
            WriteFee(CalculateFee(dailyRate, noOfDays));
        }

        // Fixed the parameter type to double
        private void WriteFee(double fee)
        {
            // Display the consultant's fee with a 10% increase
            Console.WriteLine("The consultant's fee is: {0}", fee * 1.1);
        }

        // Removed the semicolon at the end of the method declaration
        private double CalculateFee(double dailyRate, int noOfDays)
        {
            // Calculate and return the consultant's fee
            return dailyRate * noOfDays;
        }

        // Updated the parameter type to string
        private int ReadInt(string prompt)
        {
            // Prompt the user and read an integer input
            Console.Write(prompt);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        // Updated the parameter type to string
        private double ReadDouble(string prompt)
        {
            // Prompt the user and read a double input
            Console.Write(prompt);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
