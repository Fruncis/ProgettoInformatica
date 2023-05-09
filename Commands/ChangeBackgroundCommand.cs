using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
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


        private void checkResponse(Button button)
        {
            System.Diagnostics.Debug.WriteLine("1");
            if (!button.Content.ToString().Equals(CartaCorrente.cartaCorrente.RipostaCorretta))
            {
                System.Diagnostics.Debug.WriteLine("2");
                button.Background = Brushes.Red;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("3");
                button.Background = Brushes.Green;
            }

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if (parameter is Button button)
            {
                checkResponse(button);
            }
        }
    }
}
