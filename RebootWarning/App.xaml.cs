using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RebootWarning
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            // Application is running
            // Process command line args


            bool openWindow = true;

            string[] arguments = Environment.GetCommandLineArgs();

            if (arguments.GetLength(0) > 1)
            {

                if (arguments[1] == "-listenforupdate")
                {
                    openWindow = false;

                    
                }
            }


            if (openWindow)
            {
                // Create main application window, starting minimized if specified
                MainWindow mainWindow = new MainWindow();

                mainWindow.Show();

            }

        }
    }
}
