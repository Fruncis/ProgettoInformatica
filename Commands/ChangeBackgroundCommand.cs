using ProgettoInformatica.Model;
using ProgettoInformatica.Store;
using ProgettoInformatica.ViewModels;
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

        private  GameWindowViewModel _gameWindowViewModel;
        public ChangeBackgroundCommand(GameWindowViewModel gameWindowViewModel)
        {
            _gameWindowViewModel = gameWindowViewModel;
        }


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
                /*CartaCorrente.cartaCorrente = _gameWindowViewModel.GestioneGioco.PescaCarta();

                _gameWindowViewModel.QuesitoCorrente = CartaCorrente.cartaCorrente.Quesito;
                _gameWindowViewModel.RisposteCorrenti = CartaCorrente.cartaCorrente.Risposte;*/
                _gameWindowViewModel.isAnswered = true;


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
