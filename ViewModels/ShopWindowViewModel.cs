﻿using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
using ProgettoInformatica.Properties;
using ProgettoInformatica.Store;
using ProgettoInformatica.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProgettoInformatica.ViewModels
{
    public class ShopWindowViewModel : ViewModelBase
    {
        private const int cardNumber = 3;
        public ICommand NavigateMenuCommand { get; }

        public List<ICommand> BuyDeck { get; set; }
        public List<Mazzo> mazzi { get; set; }

        /*private bool[] _isDeckLocked;
        public bool[] IsDeckLocked
        {
            get
            {
                return _isDeckLocked;
            }
            set
            {
                _isDeckLocked = value;
                OnPropertyChanged(nameof(IsDeckLocked));
            }
        }*/

        private ObservableCollection<bool> _isDeckLocked;
        public ObservableCollection<bool> AreDeckLocked
        {
            get
            {
                return _isDeckLocked;
            }
            set
            {
                _isDeckLocked = value;
                //OnPropertyChanged(nameof(ArePurchased));
            }
        }

        void ChangeShop()
        {
            DateTime currentDateTime = DateTime.Now;

            string text = File.ReadAllText("C:\\Users\\Simone\\Downloads\\ProgettoInformatica-main\\Data\\change-shop.txt");//da caricare nel resource 00/00/0000 00:00:00


            ;

            DateTime dateValue = new DateTime(Convert.ToInt32(text.Substring(0, 2)),
                                              Convert.ToInt32(text.Substring(3, 5)),
                                              Convert.ToInt32(text.Substring(6, 8)),
                                              Convert.ToInt32(text.Substring(9, 10)),
                                              Convert.ToInt32(text.Substring(11, 13)),
                                              Convert.ToInt32(text.Substring(14, 16)));

            dateValue.AddHours(24);

            int result = DateTime.Compare(currentDateTime, dateValue);

            if (result >= 0)
            {
                //aggiungi carte allo shop
            }
        }

        private bool _isAnyDeckPurchased;
        public bool IsAnyDeckPurchased
        {
            get
            {
                return _isAnyDeckPurchased;
            }
            set
            {
                _isAnyDeckPurchased = value;
                OnPropertyChanged(nameof(IsAnyDeckPurchased));
            }
        }

        private ObservableCollection<bool>? _arePurchased;
        public ObservableCollection<bool>? ArePurchased
        {
            get
            {
                return _arePurchased;
            }
            set
            {
                _arePurchased = value;
                //OnPropertyChanged(nameof(ArePurchased));
            }
        }

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

        public ShopWindowViewModel(NavigationStore navigationStore, Giocatore giocatore)
        {
            BuyDeck = new List<ICommand>();
            for (int i = 0; i < cardNumber; i++)
            {
                BuyDeck.Add(new BuyDeckCommand(this));
            }
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore, giocatore));
            mazzi = new List<Mazzo>();

            ArePurchased = new ObservableCollection<bool>();
            for(int i = 0; i < cardNumber; i++)
            {
                ArePurchased.Add(false);
            }
            AreDeckLocked = new ObservableCollection<bool>();
            for (int i = 0; i < cardNumber; i++)
            {
                AreDeckLocked.Add(false);
            }
            
            this.Giocatore = giocatore;
            mazzi.Add(new Mazzo(Resources.mazzo_sport));
            mazzi.Add(new Mazzo(Resources.mazzo_storia));
            mazzi.Add(new Mazzo(Resources.mazzo_scienze));
            FillIsDeckLoacked();
            //new VolumePopUpCommand<ShopWindowViewModel>(this);
            /*mazzi.Add(new Mazzo("C:\\Users\\francesco.santamaria\\source\\repos\\ProgettoInformatica\\Data\\mazzo-scienze.xml"));
            mazzi.Add(new Mazzo("C:\\Users\\francesco.santamaria\\source\\repos\\ProgettoInformatica\\Data\\mazzo-cinema.xml"));*/
            Giocatore.PropertyChanged += OnGiocatoreChanged;
        }
        public void OnGiocatoreChanged(object source, EventArgs args)
        {
            Giocatore = (Giocatore)source;
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

        private void FillIsDeckLoacked()
        {
            for(int i=0; i<cardNumber; i++)
            {
                System.Diagnostics.Debug.WriteLine("Livello" + mazzi[i].Livello);
                if (Int32.Parse(mazzi[i].Livello) > Giocatore.Livello)// manca livello mazzo
                {
                    AreDeckLocked[i] = true;
                }
                else
                {
                    AreDeckLocked[i] = false;
                }
            }
        }
    }
}
