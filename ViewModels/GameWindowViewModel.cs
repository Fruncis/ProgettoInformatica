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
        public string[] RisposteCorrenti { get; set; } = new string[4];

        public ICommand NavigateAccountCommand { get; }
        public GameWindowViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => new MenuWindowViewModel(navigationStore));
            //cardStore = new ClasseTemporanea();
            Mazzo primoMazzo = new Mazzo("C:\\Users\\francesco\\Source\\Repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
            QuesitoCorrente = primoMazzo.Carte[0].Quesito;
            RisposteCorrenti = primoMazzo.Carte[0].Risposte;

        }
    }
}
