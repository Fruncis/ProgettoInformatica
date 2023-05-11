using ProgettoInformatica.Commands;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using ProgettoInformatica.Views;
using System;
using System.Threading;
using System.Windows;

namespace ProgettoInformatica
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Mutex _mutex = null;
        protected override void OnStartup(StartupEventArgs e)
        {
            const string appName = "MyAppName";

            bool createdNew;

            NavigationStore  navigationStore = new NavigationStore();

            navigationStore.CurrentViewModel = new MenuWindowViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel(navigationStore)
            };
            MainWindow.Show();

            

            _mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                //app is already running! Exiting the application
                Application.Current.Shutdown();
            }

            base.OnStartup(e);
        }
    }
}
