using ProgettoInformatica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProgettoInformatica.Commands
{
    class ChangeBackgroundCommand : CommandBase
    {

        /*private readonly GestioneGioco _gestioneGioco;
        public ChangeBackgroundCommand(GestioneGioco gestioneGioco)
        {
            _gestioneGioco = gestioneGioco;
        }*/
        public override void Execute(object parameter)
        {
            if (parameter is Button button)
            {
                button.Background = Brushes.Red; // Change the background color to red
            }
        }
    }
}
