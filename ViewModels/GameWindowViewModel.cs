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
    class GameWindowViewModel : ViewModelBase
    {
        private readonly Mazzo mazzo = new Mazzo("C:\\Users\\francesco\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
        /*public GestioneGioco _gestioneGioco = new GestioneGioco(mazzo);
        //public Carta cartaCorrente => _gestioneGioco.CartaCorrente; */
        //private CartaCorrente _cartaCorrente;
        public string QuesitoCorrente { get; private set; }
        public string[] RisposteCorrenti { get; set; } = new string[4];


        public ICommand ChangeButtonColor { get; set; }


        public ICommand NavigateAccountCommand { get; }
        public GameWindowViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => new MenuWindowViewModel(navigationStore));
            CartaCorrente.cartaCorrente = mazzo.Carte[0];
            System.Diagnostics.Debug.WriteLine(CartaCorrente.cartaCorrente.RipostaCorretta);
            QuesitoCorrente = mazzo.Carte[0].Quesito;
            RisposteCorrenti = mazzo.Carte[0].Risposte;
            ChangeButtonColor = new ChangeBackgroundCommand();
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
