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
        public string CheckBoxName { get; set; } = "CheckBox";

        public ShopWindowViewModel(NavigationStore navigationStore)
        {
            NavigateMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore,() => IstanziaViewModel<MenuWindowViewModel>.Istanzia(navigationStore));
        }
    }
}
