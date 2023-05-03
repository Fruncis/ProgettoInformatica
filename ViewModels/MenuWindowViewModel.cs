using ProgettoInformatica.Commands;
using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgettoInformatica.ViewModels
{

    
    class MenuWindowViewModel : ViewModelBase
    {
        public ICommand NavigateGameCommand { get; }
        public ICommand NavigateShopCommand { get; }
        public string MyName { get; set; }

        public RelayCommand ClickCommandEvent { get; set; }
        public MenuWindowViewModel(NavigationStore navigationStore)
        {
            NavigateGameCommand = new NavigateCommand<GameWindowViewModel>(navigationStore, () => new GameWindowViewModel(navigationStore, null));
            NavigateShopCommand = new NavigateCommand<ShopWindowViewModel>(navigationStore, () => new ShopWindowViewModel(navigationStore));
            MyName = "Menu";
            ClickCommandEvent = new RelayCommand(ClickExecute);
        }

        public void ClickExecute(object param)
        {
            System.Diagnostics.Debug.WriteLine($"Clicked: Button");
        }
    }
}
