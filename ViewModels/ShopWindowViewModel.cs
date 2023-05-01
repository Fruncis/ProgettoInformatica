using ProgettoInformatica.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgettoInformatica.ViewModels
{
    class ShopWindowViewModel : ViewModelBase
    {
        public ICommand NavigationMenuCommand { get; }
        public string CheckBoxName { get; set; } = "puppa";

        public ShopWindowViewModel(NavigationStore navigationStore)
        {
            NavigationMenuCommand = new NavigateCommand<MenuWindowViewModel>(navigationStore, () => new MenuWindowViewModel(navigationStore));
        }
    }
}
