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


        private bool _isVolumePressed;
        public bool IsVolumePressed
        {
            get
            {
                return _isVolumePressed;
            }
            set
            {
                _isVolumePressed = value;
                OnPropertyChanged(nameof(IsVolumePressed));
                System.Diagnostics.Debug.WriteLine("pressed: " + IsVolumePressed);
            }
        }

        public ICommand VolumePopUp
        {
            get { return new RelayCommand(VolumePopUpFunc, CanVolumePopUp); }
        }

        //private readonly GameWindowViewModel _gameWindowViewModel = IstanziaViewModel.IstanzaGameViewModel;
        public string MyName { get; set; }

        public RelayCommand ClickCommandEvent { get; set; }
        public MenuWindowViewModel(NavigationStore navigationStore, Giocatore giocatore)
        {
            NavigateGameCommand = new NavigateCommand<GameWindowViewModel>(navigationStore, () => IstanziaViewModel<GameWindowViewModel>.Istanzia(navigationStore, giocatore));
            NavigateShopCommand = new NavigateCommand<ShopWindowViewModel>(navigationStore, () => IstanziaViewModel<ShopWindowViewModel>.Istanzia(navigationStore, giocatore));
            MyName = "Menu";
            ClickCommandEvent = new RelayCommand(ClickExecute);
        }

        public void ClickExecute(object param)
        {
            System.Diagnostics.Debug.WriteLine($"Clicked: Button");
        }


        private bool CanVolumePopUp(object context)
        {
            return true;
        }

        private void VolumePopUpFunc(object context)
        {
            if (IsVolumePressed)
            {
                IsVolumePressed = false;
            }
            else
            {
                IsVolumePressed = true;
            }
        }
    }
}
