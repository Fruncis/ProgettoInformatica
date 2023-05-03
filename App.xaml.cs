using ProgettoInformatica.Commands;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using ProgettoInformatica.Views;
using System;
using System.Windows;

namespace ProgettoInformatica
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore  navigationStore = new NavigationStore();

            navigationStore.CurrentViewModel = new MenuWindowViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
