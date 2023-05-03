using ProgettoInformatica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoInformatica.Commands
{
    internal abstract class MainWindowCommand : CommandBase
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }
        public MainWindowCommand(MainWindowViewModel mainWindowViewModel)
        {
            MainWindowViewModel = mainWindowViewModel;
        }
    }
}
