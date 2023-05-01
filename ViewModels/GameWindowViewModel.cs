using ProgettoInformatica.Commands;
using ProgettoInformatica.Model;
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
        public GameWindowViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => new MenuWindowViewModel(navigationStore));
            Mazzo primoMazzo = new Mazzo("C:\\Users\\francesco\\source\\repos\\ProgettoInformatica\\Data\\mazzo-geografia.xml");
            QuesitoCorrente = primoMazzo.Carte[0].Quesito;


        }
    }
}
