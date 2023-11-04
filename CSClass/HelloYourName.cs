using System.Windows;
using System.Windows.Controls;

namespace HelloYourName
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void SayHello_Click(object sender, RoutedEventArgs e)
        {
            string userName = nameTextBox.Text;

            if (!string.IsNullOrEmpty(userName))
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = "Greetings",
                    Content = $"Hello, {userName}!",
                    PrimaryButtonText = "OK"
                };

                await dialog.ShowAsync();
            }
            else
            {
                nameTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                nameErrorTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}