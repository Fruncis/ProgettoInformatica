using ProgettoInformatica.Commands;
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
            List<Mazzo> duplicato = new List<Mazzo>();

            duplicato.Add(new Mazzo(Resources.mazzo_arte));
            duplicato.Add(new Mazzo(Resources.mazzo_cinema));
            duplicato.Add(new Mazzo(Resources.mazzo_cucina));
            duplicato.Add(new Mazzo(Resources.mazzo_geografia));
            duplicato.Add(new Mazzo(Resources.mazzo_musica));
            duplicato.Add(new Mazzo(Resources.mazzo_religione));
            duplicato.Add(new Mazzo(Resources.mazzo_scienze));
            duplicato.Add(new Mazzo(Resources.mazzo_sport));
            duplicato.Add(new Mazzo(Resources.mazzo_storia));
            duplicato.Add(new Mazzo(Resources.mazzo_tecnologia));

            DateTime currentDateTime = DateTime.Now;

            string text = File.ReadAllText("change-shop.txt");//da caricare nel resource 00/00/0000 00:00:00



            DateTime dateValue = new DateTime(Convert.ToInt32(text.Substring(6, 4)),
                                              Convert.ToInt32(text.Substring(3, 2)),
                                              Convert.ToInt32(text.Substring(0, 2)),
                                              Convert.ToInt32(text.Substring(11, 2)),
                                              Convert.ToInt32(text.Substring(14, 2)),
                                              Convert.ToInt32(text.Substring(17, 2)));

            dateValue.AddHours(24);

            int result = DateTime.Compare(currentDateTime, dateValue);

            if (result >= 0)
            {
                mazzi = new List<Mazzo>();

                for(int i = 0; i < 10; i++)
                {
                    
                    if (Giocatore.Livello == Convert.ToInt32(duplicato[i].Livello))
                    {
                        System.Diagnostics.Debug.WriteLine(i);
                        mazzi.Add(duplicato[i]);
                        duplicato.Remove(duplicato[i]);
                        break;
                    }
                }
                
                Random rnd = new Random();
                
                int r = rnd.Next(0, 8);
                mazzi.Add(duplicato[r]);
                duplicato.Remove(duplicato[r]);

                r = rnd.Next(0, 7);
                mazzi.Add(duplicato[r]);
                duplicato.Remove(duplicato[r]);

                File.WriteAllText("change-shop.txt", currentDateTime.ToString());
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
            ChangeShop();
            /*mazzi.Add(new Mazzo(Resources.mazzo_sport));
            mazzi.Add(new Mazzo(Resources.mazzo_storia));
            mazzi.Add(new Mazzo(Resources.mazzo_scienze));*/
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
