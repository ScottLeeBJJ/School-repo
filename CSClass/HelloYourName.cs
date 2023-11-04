<Window x:Class="HelloYourName.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Hello Your Name" Height="200" Width="350">
    <Grid>
        <Label Content="Enter your name:" HorizontalAlignment="Left" VerticalAlignment="Top" Margin="20,20,0,0"/>
        <TextBox x:Name="nameTextBox" HorizontalAlignment="Left" VerticalAlignment="Top" Width="200" Margin="20,50,0,0"/>
        <Button Content="Say Hello" HorizontalAlignment="Left" VerticalAlignment="Top" Width="100" Height="30" Margin="20,90,0,0" Click="SayHello_Click"/>
    </Grid>
</Window>



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
