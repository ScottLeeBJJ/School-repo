using System;
using System.Windows;

namespace CreateClassesObjs
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // The entry point for the application

        // This method is called when the application starts
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Your startup logic goes here

            // Creating an instance of the MainWindow and showing it
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
