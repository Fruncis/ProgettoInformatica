using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgettoInformatica.ViewModels
{

    
    public class MenuWindowViewModel : ViewModelBase
    {
        public ICommand NavigateGameCommand { get; }
        public ICommand NavigateShopCommand { get; }

        //private readonly GameWindowViewModel _gameWindowViewModel = IstanziaViewModel.IstanzaGameViewModel;
        public string MyName { get; set; }

        public RelayCommand ClickCommandEvent { get; set; }
        public MenuWindowViewModel(NavigationStore navigationStore)
        {
            NavigateGameCommand = new NavigateCommand<GameWindowViewModel>(navigationStore, () => IstanziaViewModel<GameWindowViewModel>.Istanzia(navigationStore));
            NavigateShopCommand = new NavigateCommand<ShopWindowViewModel>(navigationStore, () => IstanziaViewModel<ShopWindowViewModel>.Istanzia(navigationStore));
            MyName = "Menu";
            ClickCommandEvent = new RelayCommand(ClickExecute);
        }

        public void ClickExecute(object param)
        {
            System.Diagnostics.Debug.WriteLine($"Clicked: Button");
        }
    }
}
