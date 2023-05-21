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
    public class ShopWindowViewModel : ViewModelBase
    {
        public ICommand NavigateMenuCommand { get; }


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
            this.Giocatore = giocatore;
            giocatore.PropertyChanged += OnGiocatoreChanged;
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore,() => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore, giocatore));
        }
        public void OnGiocatoreChanged(object source, EventArgs args)
        {
            Giocatore = (Giocatore)source;
        }
    }
}
