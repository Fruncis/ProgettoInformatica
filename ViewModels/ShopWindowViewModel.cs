using ProgettoInformatica.Commands;
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
        public ICommand NavigationMenuCommand { get; }
        public string CheckBoxName { get; set; } = "CheckBox";

        public ShopWindowViewModel(NavigationStore navigationStore)
        {
            NavigationMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => new MenuWindowViewModel(navigationStore));
        }
    }
}
