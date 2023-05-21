using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
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

        private static readonly Lazy<IstanziaViewModel<MenuWindowViewModel>> _istanziaViewModel = new Lazy<IstanziaViewModel<MenuWindowViewModel>>(() => new IstanziaViewModel<MenuWindowViewModel> { });

        public IstanziaViewModel<MenuWindowViewModel> Istanza { get; } = _istanziaViewModel.Value;
        protected override void OnStartup(StartupEventArgs e)
        {
            const string appName = "Quiz";

            bool createdNew;

            

            NavigationStore  navigationStore = new NavigationStore();
            Giocatore giocatore = new Giocatore();

            navigationStore.CurrentViewModel = IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore, giocatore);

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
