using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
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
        //private readonly Mazzo mazzo = new Mazzo("C:\\Users\\Simone\\Downloads\\ProgettoInformatica-main\\Data\\mazzo-geografia.xml");
        private readonly Mazzo mazzo = new Mazzo("C:\\Users\\francesco\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
        // private readonly Mazzo mazzo = new Mazzo("C:\\Users\\francesco.santamaria\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
        //public Brushs
        private bool _isAnswered;
        public bool IsAnswered { get { return _isAnswered; } set { _isAnswered = value; OnPropertyChanged(nameof(IsAnswered)); } }

        private bool _isGameTeriminated;
        public bool IsGameTerminated { get { return _isGameTeriminated; } set { _isGameTeriminated = value; OnPropertyChanged(nameof(IsGameTerminated)); } }
        
        public GestioneGioco GestioneGioco { get; set; }

        public int Punti { get; set; } = 0;

        public Timer timer = new Timer();

        //public NavigationStore navigationStore { get; set; }

        /*public GestioneGioco _gestioneGioco = new GestioneGioco(mazzo);
        //public Carta cartaCorrente => _gestioneGioco.CartaCorrente; */
        //private CartaCorrente _cartaCorrente;
        private string _quesitoCorrente = "default";
        public string QuesitoCorrente 
        { 
            get
            {
                return _quesitoCorrente;
            }
            set
            {
                _quesitoCorrente = value;
                OnPropertyChanged(nameof(QuesitoCorrente));
            } 
        }
        private string[] _risposteCorrenti;
        public string[] RisposteCorrenti
        {
            get
            {
                return _risposteCorrenti;
            }
            set
            {
                _risposteCorrenti = value;
                OnPropertyChanged(nameof(RisposteCorrenti));
            }
        }


        public ICommand ChangeButtonColor { get; set; }


        public ICommand NavigateMenuCommand { get; }
        public GameWindowViewModel(NavigationStore navigationStore)
        {
            //System.Diagnostics.Debug.WriteLine(IstanziaViewModel.Istanza);
            IsAnswered = false;
            IsGameTerminated = false;
            GestioneGioco = new GestioneGioco(mazzo);
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore));
            CartaCorrente.cartaCorrente = GestioneGioco.PescaCarta();
            
            QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
            RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;
            System.Diagnostics.Debug.WriteLine(QuesitoCorrente);

            ChangeButtonColor = new ChangeBackgroundCommand(this);
            timer.Interval = 500; // In milliseconds
            timer.AutoReset = false; // Stops it from repeating
            timer.Elapsed += new ElapsedEventHandler(TimerElapsed);
            timer.Start();
        }
        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello, world!");
        }

        public async void DelayedCodeExecution(int animationTime)
        {
            // Delay the execution by 2 seconds (2000 milliseconds)
            await Task.Delay(TimeSpan.FromSeconds(animationTime));

            CartaCorrente.cartaCorrente = GestioneGioco.PescaCarta();
            if(CartaCorrente.cartaCorrente != null)
            {
                IsGameTerminated = true;
                QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
                RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;
                IsAnswered = false;
            }
            else
            {
                
            }
            
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
