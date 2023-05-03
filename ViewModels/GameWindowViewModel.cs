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
    class GameWindowViewModel : ViewModelBase
    {
        public string QuesitoCorrente { get; private set; }

        public ICommand NavigateAccountCommand { get; }
        public GameWindowViewModel(NavigationStore navigationStore, CardStore cardStore)
        {
            NavigateAccountCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => new MenuWindowViewModel(navigationStore));
            cardStore = new ClasseTemporanea();
            //cardStore = new ClasseTemporanea(cardStore);
            Mazzo primoMazzo = new Mazzo("C:\\Users\\francesco.santamaria\\Source\\Repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
            QuesitoCorrente = primoMazzo.Carte[0].Quesito;


        }
    }
}
