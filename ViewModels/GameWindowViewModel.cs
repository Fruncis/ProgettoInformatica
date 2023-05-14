using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ProgettoInformatica.ViewModels
{
    public class GameWindowViewModel : ViewModelBase
    {
        //private readonly Mazzo mazzo = new Mazzo("C:\\Users\\Simone\\Downloads\\ProgettoInformatica-main\\Data\\mazzo-geografia.xml");
        private readonly Mazzo mazzo = new Mazzo("C:\\Users\\francesco\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
        
        //public Brush
        public bool _isAnswered { get; set; }
        public bool isAnswered { get { return _isAnswered; } set { _isAnswered = value; OnPropertyChanged(nameof(isAnswered)); _isAnswered = false; } }
        
        public GestioneGioco GestioneGioco { get; set; }

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
            isAnswered = false;
            GestioneGioco = new GestioneGioco(mazzo);
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore));
            CartaCorrente.cartaCorrente = GestioneGioco.PescaCarta();
            QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
            RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;
            ChangeButtonColor = new ChangeBackgroundCommand(this);
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
