using System;
using System.Windows;

namespace CreateClassesObjs
{
    public partial class MainWindow : Window
    {
        // Class-level variable to store the selected course
        Course choice;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for the window loaded event
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Creating instances of Course and setting their names
            Course course1 = new Course();
            Course course2 = new Course();
            Course course3 = new Course();
            Course course4 = new Course();
            Course course5 = new Course();
            Course course6 = new Course();
            Course course7 = new Course();

            course1.setName("IT 145");
            course2.setName("IT 200");
            course3.setName("IT 201");
            course4.setName("IT 270");
            course5.setName("IT 315");
            course6.setName("IT 328");
            course7.setName("IT 330");

            // Adding courses to the combo box
            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);
        }

        // Event handler for the button click event
        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Adding the selected course to the list box
            choice = (Course)(this.comboBox.SelectedItem);
            this.listBox.Items.Add(choice);
        }
    }
}
