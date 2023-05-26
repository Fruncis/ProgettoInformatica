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

        private Giocatore _giocatore;
        public Giocatore Giocatore
        {
            get
            {
                return _giocatore;
            }
            set
            {
                _giocatore = value;
                OnPropertyChanged(nameof(Giocatore));
            }
        }
        private GestioneGiocatore GestioneGiocatore { get; set; }
        public ICommand NavigateGameCommand { get; }
        public ICommand NavigateShopCommand { get; }

        public ICommand ButtonSaveCommand { get; }


        private bool _isNewSavePressed;
        public bool IsNewSavePressed
        {
            get
            {
                return _isNewSavePressed;
            }
            set
            {
                _isNewSavePressed = value;
                OnPropertyChanged(nameof(IsNewSavePressed));
            }
        }

        private bool _isLoadSavePressed;
        public bool IsLoadSavePressed
        {
            get
            {
                return _isLoadSavePressed;
            }
            set
            {
                _isLoadSavePressed = value;
                OnPropertyChanged(nameof(IsLoadSavePressed));
            }
        }


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

        public ICommand NewSave
        {
            get { return new RelayCommand(NewSaveFunc, CanVolumePopUp); }
        }

        public ICommand LoadSave
        {
            get { return new RelayCommand(LoadSaveFunc, CanVolumePopUp); }
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
            IsNewSavePressed = true;
            Giocatore = giocatore;
            GestioneGiocatore = new GestioneGiocatore(Giocatore);
            ButtonSaveCommand = new ButtonSaveCommand(this);
            NavigateGameCommand = new NavigateCommand<GameWindowViewModel>(navigationStore, () => IstanziaViewModel<GameWindowViewModel>.Istanzia(navigationStore, giocatore));
            NavigateShopCommand = new NavigateCommand<ShopWindowViewModel>(navigationStore, () => IstanziaViewModel<ShopWindowViewModel>.Istanzia(navigationStore, giocatore));
            if (!GestioneGiocatore.isXMLEmpty())
            {
                System.Diagnostics.Debug.WriteLine("disadi");
                IsNewSavePressed = false;
            }
            ClickCommandEvent = new RelayCommand(ClickExecute);
        }

        public void ClickExecute(object param)
        {
            System.Diagnostics.Debug.WriteLine($"Clicked: Button");
        }

        private void NewSaveFunc(object context)
        {
            GestioneGiocatore.Salva();
            IsNewSavePressed = true;

        }

        private void LoadSaveFunc(object context)
        {


            GestioneGiocatore.CaricaSalvataggio();
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
