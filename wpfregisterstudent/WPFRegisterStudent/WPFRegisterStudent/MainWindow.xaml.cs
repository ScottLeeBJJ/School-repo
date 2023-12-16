using System;
using System.Windows;

namespace WPFRegisterStudent
{
    public partial class MainWindow : Window
    {
        private Course choice;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");

            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);

            this.textBox.Text = "";
            this.totalCreditHoursTextBox.Text = "0";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);

            if (choice != null && !choice.IsRegisteredAlready)
            {
                choice.SetToRegistered();
                MessageBox.Show($"Registration confirmed for {choice.Name}", "Success");

                int currentCreditHours = int.Parse(this.totalCreditHoursTextBox.Text);
                this.totalCreditHoursTextBox.Text = (currentCreditHours + 3).ToString();
            }
            else if (choice != null && choice.IsRegisteredAlready)
            {
                MessageBox.Show($"{choice.Name} is already registered", "Error");
            }
            else
            {
                MessageBox.Show("Please select a course", "Error");
            }
        }
    }
}
