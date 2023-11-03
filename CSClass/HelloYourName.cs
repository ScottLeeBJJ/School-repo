using System.Windows;

namespace HelloYourName
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SayHello_Click(object sender, RoutedEventArgs e)
        {
            string userName = nameTextBox.Text;

            if (!string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Hello, " + userName + "!", "Greetings");
            }
            else
            {
                MessageBox.Show("Please enter your name.", "Error");
            }
        }
    }
}
