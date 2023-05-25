using ProgettoInformatica.ViewModels;
using ProgettoInformatica.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Commands
{
    public class ButtonSaveCommand : CommandBase
    {
        private MenuWindowViewModel _menuWindowViewModel;
        public ButtonSaveCommand(MenuWindowViewModel menuWindowViewModel)
        {
            _menuWindowViewModel = menuWindowViewModel;
        }

        public override void Execute(object? parameter)
        {
            if(_menuWindowViewModel.IsLoadSavePressed)
            {
                _menuWindowViewModel.IsLoadSavePressed = false;
            }
            else
            {
                _menuWindowViewModel.IsLoadSavePressed = true;
            }
        }
    }
}
