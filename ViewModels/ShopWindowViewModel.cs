﻿using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using ProgettoInformatica.Views;
using System;
using System.Collections.Generic;
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

        public ICommand BuyDeck { get; set; }
        public List<Mazzo> mazzi { get; set; }

        private bool[] _isDeckLocked;
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
        }
        private bool[] _isPurchased;
        public bool[] IsPurchased
        {
            get
            {
                return _isPurchased;
            }
            set
            {
                _isPurchased = value;
                OnPropertyChanged(nameof(IsPurchased));
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
        public string CheckBoxName { get; set; } = "CheckBox";

        public ShopWindowViewModel(NavigationStore navigationStore, Giocatore giocatore)
        {
            BuyDeck = new BuyDeck(this);
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore, giocatore));
            mazzi = new List<Mazzo>();
            IsPurchased = new bool[cardNumber];
            IsDeckLocked = new bool[cardNumber];
            //FillIsDeckLoacked();
            this.Giocatore = giocatore;
            mazzi.Add(new Mazzo("C:\\Users\\francesco\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml"));
            Giocatore.PropertyChanged += OnGiocatoreChanged;
        }
        public void OnGiocatoreChanged(object source, EventArgs args)
        {
            Giocatore = (Giocatore)source;
        }

        /*private void FillIsDeckLoacked()
        {
            for(int i=0; i<cardNumber; i++)
            {
                if (mazzi[i].LivelloMazzo > Giocatore.Livello)// manca livello mazzo
                {
                    IsDeckLocked[i] = true;
                }
                else
                {
                    IsDeckLocked[i] = false;
                }
            }
        }*/
    }
}
