using System;
using System.Windows;

namespace WPFRegisterStudent
{
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            App app = new App();
            MainWindow mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }

    public partial class MainWindow : Window
    {
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox gradeTextBox;

        public MainWindow()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Initialize UI elements here (e.g., textboxes, labels, buttons)

            // Example:
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            gradeTextBox = new TextBox();

            Button registerButton = new Button();
            registerButton.Content = "Register";
            registerButton.Click += RegisterButton_Click;

            // Add UI elements to the window (e.g., using a Grid)
            // ...

            Content = new Grid(); // Replace with the appropriate layout

            // Example:
            ((Grid)Content).Children.Add(nameTextBox);
            ((Grid)Content).Children.Add(ageTextBox);
            ((Grid)Content).Children.Add(gradeTextBox);
            ((Grid)Content).Children.Add(registerButton);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate input and create a Student object
            if (int.TryParse(ageTextBox.Text, out int age) && IsValidGrade(gradeTextBox.Text))
            {
                Student student = new Student
                {
                    Name = nameTextBox.Text,
                    Age = age,
                    Grade = gradeTextBox.Text
                };

                // Display student information in a MessageBox
                MessageBox.Show($"Student Details:\nName: {student.Name}\nAge: {student.Age}\nGrade: {student.Grade}", "Registration Successful");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid information.", "Error");
            }
        }

        private bool IsValidGrade(string grade)
        {
            // Implement grade validation logic (e.g., check against a list of valid grades)
            // Return true if valid, false otherwise
            return !string.IsNullOrWhiteSpace(grade); // Placeholder logic, replace with actual validation
        }
    }
}
