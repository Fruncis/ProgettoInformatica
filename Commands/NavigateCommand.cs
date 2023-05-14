using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgettoInformatica.Commands
{
    public class NavigateCommand<TviewModel> : CommandBase where TviewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TviewModel> _createViewModel;  
        public NavigateCommand(NavigationStore navigationStore, Func<TviewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
