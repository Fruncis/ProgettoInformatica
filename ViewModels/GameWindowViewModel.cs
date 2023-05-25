using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ProgettoInformatica.ViewModels
{
    public class GameWindowViewModel : ViewModelBase
    {
        
        //public Brushs
        private bool _isAnswered;
        public bool IsAnswered { get { return _isAnswered; } set { _isAnswered = value; OnPropertyChanged(nameof(IsAnswered)); } }

        private bool _isGameTeriminated;
        public bool IsGameTerminated { get { return _isGameTeriminated; } set { _isGameTeriminated = value; OnPropertyChanged(nameof(IsGameTerminated)); } }

        private string _rispostaRobot;
        public string RispostaRobot { get { return _rispostaRobot; } set { _rispostaRobot = value; OnPropertyChanged(nameof(RispostaRobot)); } }


        public GestioneGioco GestioneGioco { get; set; }

        private Carta _cartaCorrente;
        public Carta CartaCorrente
        {
            get
            {
                return _cartaCorrente;
            }
            set
            {
                _cartaCorrente = value;
                OnPropertyChanged(nameof(CartaCorrente));
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

        private int _punteggio;
        public int Punteggio { get { return _punteggio; } set { _punteggio = value; OnPropertyChanged(nameof(Punteggio)); } }

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

        public Timer timer = new Timer();//Da spostare in Gestione Gioco


        public ICommand ChangeButtonColor { get; set; }


        public ICommand VolumePopUp
        {
            get { return new RelayCommand(VolumePopUpFunc, CanVolumePopUp); }
        }

        public ICommand GameTerminatedCommand
        {
            get { return new RelayCommand(GameTerminatedFunc, CanGameTerminated); }
        }



        public ICommand NavigateMenuCommand { get; }
        public GameWindowViewModel(NavigationStore navigationStore, Giocatore giocatore)
        {
            //System.Diagnostics.Debug.WriteLine(IstanziaViewModel.Istanza);
            //System.Diagnostics.Debug.WriteLine(Giocatore.Gettoni);
            Giocatore = giocatore;
            Giocatore.PropertyChanged += OnGiocatoreChanged;
            Punteggio = 0;
            IsAnswered = false;
            IsGameTerminated = false;
            GestioneGioco = new GestioneGioco(this.Giocatore);
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore, giocatore));
            CartaCorrente = GestioneGioco.PescaCarta();
            //VolumePopUp = new VolumePopUpCommand(this.IsVolumePressed);
            ChangeButtonColor = new ChangeBackgroundCommand(this);
            timer.Interval = 30000; // In milliseconds
            timer.AutoReset = false; // Stops it from repeating
            timer.Elapsed += new ElapsedEventHandler(TimerElapsed);
            timer.Start();
        }

        
        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            GestioneGioco.PescaCarta();
            timer.Stop();
            timer.Start();
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

        private bool CanGameTerminated(object context)
        {
            return true;
        }

        private void GameTerminatedFunc(object context)
        {
            if (IsGameTerminated)
            {
                IsGameTerminated = false;
            }
            else
            {
                IsGameTerminated = true;
            }
        }




        public async void DelayedCodeExecution(int animationTime)
        {
            // Delay the execution by 2 seconds (2000 milliseconds)

            RispostaRobot = GestioneGioco.RispostaAvversario(1, CartaCorrente);
            

            await Task.Delay(TimeSpan.FromSeconds(animationTime));
            System.Diagnostics.Debug.WriteLine(CartaCorrente);
            CartaCorrente = GestioneGioco.PescaCarta();
            if (CartaCorrente != null)
            {
                IsAnswered = false;
                return;
            }
            else//Quando Finisce il Livello
            {
                IsGameTerminated = true;
                int tmp = Giocatore.Livello;
                GestioneGioco.ConvertPuntiEsperienzaGettoni(Punteggio);
                GestioneGioco.SaliDiLivello();
                /*if(tmp < Giocatore.Livello)
                {

                }*/
                CartaCorrente = GestioneGioco.PescaCarta();

                IsAnswered = false;
            }
            

        }
        public void OnGiocatoreChanged(object source, EventArgs args)
        {
            Giocatore = (Giocatore)source;
        }
        /*public GameWindowViewModel(GestioneGioco gestioneGioco)
        {
            _gestioneGioco = gestioneGioco;
            _gestioneGioco.CartaCambiata += CartaCambiata;
            
        }

        private void CartaCambiata()
        {
            OnPropertyChanged(nameof(CartaCambiata));
        }*/
    }
}
